using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace PasswordManager
{
    public class Database
    {
        public class DBProfile
        {
            public DBProfile(string name, string phrasehash)
            {
                Name = name;
                EncryptedPhraseHash = phrasehash;
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

            [JsonProperty("EncryptedPhraseHash")] // Encrypted phrase hash
            public string EncryptedPhraseHash { get; set; }

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

        public static DBProfile CreateProfile(string profilename, string profilepassword, string phrase)
        {
            var passhash = Crypto.GenerateHash(profilepassword);
            var phrasehash = Crypto.GenerateHash(phrase);

            var json = new PhraseHashJson(phrasehash);
            var encryptedphrasehash = Crypto.EncryptStringAES(JsonConvert.SerializeObject(json), passhash);

            var newProfile = new DBProfile(profilename, encryptedphrasehash); //create new profile object
            var text = Crypto.EncryptStringAES(JsonConvert.SerializeObject(newProfile), "b_@_51C-$33d");

            File.WriteAllText(profilename + ".mpr", text);
            return newProfile;
        }

        public static void SaveProfile(DBProfile dbProfile)
        {
            var text = Crypto.EncryptStringAES(JsonConvert.SerializeObject(dbProfile), "b_@_51C-$33d");

            File.WriteAllText(dbProfile.Name + ".mpr", text);
        }

        public static void DeleteProfile(string profilename)
        {
            File.Delete(profilename + ".mpr");
        }

        public static DBProfile GetProfile(string profilename)
        {
            var encryptedProfile = File.ReadAllText(profilename + ".mpr");
            var json = Crypto.DecryptStringAES(encryptedProfile, "b_@_51C-$33d");

            return JsonConvert.DeserializeObject<DBProfile>(json);
        }

        public static DBProfile GetProfileByPath(string path)
        {
            var encryptedProfile = File.ReadAllText(path);
            var json = Crypto.DecryptStringAES(encryptedProfile, "b_@_51C-$33d");

            return JsonConvert.DeserializeObject<DBProfile>(json);
        }

        public static List<DBProfile> GetProfiles()
        {
            var paths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.mpr");
            var profiles = paths.Select(GetProfileByPath).ToList();

            return profiles;
        }

        public static string GeneratePhrase()
        {
            byte[] data = new byte[4];
            var lphrase = new List<string>();
            var wordlist = Properties.Resources.wordlist.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            for (var i = 0; i < 12; i++)
            {
                rngCsp.GetBytes(data);
                int randomNum = BitConverter.ToInt32(data, 0);
                int place = Mod(randomNum, wordlist.Count); 
                lphrase.Add(wordlist[place]);
            }
            
            return string.Join(" ", lphrase);
        }

        public static int Mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}
