using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PasswordManager
{
    public class Database
    {
        public class Profile
        {
            public Profile(string name, string phrasehash)
            {
                Name = name;
                PhraseHash = phrasehash;
                Accounts = new List<Account>();
            }

            //TODO: remove?
            /*[JsonConstructor]
            public Profile(string name, string phrasehash, List<Account> accounts)
            {
                Name = name;
                PhraseHash = phrasehash;
                Accounts = accounts;
            }*/

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("PhraseHash")] // Encrypted phrase hash
            public string PhraseHash { get; set; }

            [JsonProperty("Accounts")]
            public List<Account> Accounts { get; set; }
        }

        public class Account
        {
            public Account(string servicename, string username, string encryptedpassword)
            {
                ServiceName = servicename;
                Username = username;
                EncryptedPassword = encryptedpassword;
            }

            [JsonProperty("ServiceName")]
            public string ServiceName { get; set; }

            [JsonProperty("Username")]
            public string Username { get; set; }

            [JsonProperty("EncryptedPassword")]
            public string EncryptedPassword { get; set; }
        }

        public class PhraseHashJson
        {
            public PhraseHashJson(string phrasehash)
            {
                PhraseHash = phrasehash;
            }

            [JsonProperty("PhraseHash")]
            public string PhraseHash { get; set; }
        }
        
        public static bool IsProfile(string name)
        {
            return File.Exists(name + ".mpr");
        }

        public static void CreateProfile(string profilename, string profilepassword, string phrase)
        {
            var passhash = Crypto.GenerateHash(profilepassword);
            var phrasehash = Crypto.GenerateHash(phrase);

            var json = new PhraseHashJson(phrasehash);
            var encryptedphrasehash = Crypto.EncryptStringAES(JsonConvert.SerializeObject(json), passhash);

            var newProfile = new Profile(profilename, encryptedphrasehash); //create new profile object
            var text = Crypto.EncryptStringAES(JsonConvert.SerializeObject(newProfile), "b_@_51C-$33d");

            File.WriteAllText(profilename + ".mpr", text);
        }

        public static void SaveProfile(Profile profile)
        {
            var text = Crypto.EncryptStringAES(JsonConvert.SerializeObject(profile), "b_@_51C-$33d");

            File.WriteAllText(profile.Name + ".mpr", text);
        }

        public static void DeleteProfile(string profilename)
        {
            File.Delete(profilename + ".mpr");
        }

        public static Profile GetProfile(string profilename)
        {
            var encryptedProfile = File.ReadAllText(profilename + ".mpr");
            var json = Crypto.DecryptStringAES(encryptedProfile, "b_@_51C-$33d");

            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public static Profile GetProfileByPath(string path)
        {
            var encryptedProfile = File.ReadAllText(path);
            var json = Crypto.DecryptStringAES(encryptedProfile, "b_@_51C-$33d");

            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public static List<Profile> GetProfiles()
        {
            var paths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.mpr");
            var profiles = paths.Select(GetProfileByPath).ToList();

            return profiles;
        }

        public static string GeneratePhrase()
        {
            var r = new Random(DateTime.Now.Millisecond);

            var lphrase = new List<string>();
            var wordlist = Properties.Resources.wordlist.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            for (var i = 0; i < 12; i++)
                lphrase.Add(wordlist[r.Next(wordlist.Count)]);
            
            return string.Join(" ", lphrase);
        } 
    }
}
