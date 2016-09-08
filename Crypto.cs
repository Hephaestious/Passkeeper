using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager
{
    public class Crypto
    {
        private static readonly byte[] Salt = Encoding.ASCII.GetBytes("P&s$w0<rd__>_^*_M6n2g#r"); //todo: do something about this

        public static string GenerateHash(string plaintext)
        {
            var plainText = Encoding.UTF8.GetBytes(plaintext);
            HashAlgorithm algorithm = new SHA256Managed();

            var plainTextWithSaltBytes = new byte[plainText.Length + Salt.Length];

            for (var i = 0; i < plainText.Length; i++)
                plainTextWithSaltBytes[i] = plainText[i];
            
            for (var i = 0; i < Salt.Length; i++)
                plainTextWithSaltBytes[plainText.Length + i] = Salt[i];

            return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        }
        public static string GenerateHashWithSeed(string plaintext, string salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            
            var plainText = Encoding.UTF8.GetBytes(plaintext);
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var plainTextWithSaltBytes = new byte[plainText.Length + saltBytes.Length];

            for (var i = 0; i < plainText.Length; i++)
                plainTextWithSaltBytes[i] = plainText[i];
            
            for (var i = 0; i < saltBytes.Length; i++)
                plainTextWithSaltBytes[plainText.Length + i] = saltBytes[i];

            return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        }
        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr; // encrypted string to return

            try
            {
                // generate the key from the shared secret and the salt
                var key = new Rfc2898DeriveBytes(sharedSecret, Salt);

                // Create a RijndaelManaged object
                var aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize/8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof (int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                            swEncrypt.Write(plainText); //Write all data to the stream.

                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }

                aesAlg.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
                return "";
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext;

            try
            {
                // generate the key from the shared secret and the salt
                var key = new Rfc2898DeriveBytes(sharedSecret, Salt);

                // Create the streams used for decryption.                
                var bytes = Convert.FromBase64String(cipherText);

                using (var msDecrypt = new MemoryStream(bytes))
                {
                    var aesAlg = new RijndaelManaged(); // Create a RijndaelManaged object with the specified key and IV.
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);

                    // Create a decrytor to perform the stream transform.
                    var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        using (var srDecrypt = new StreamReader(csDecrypt))
                            plaintext = srDecrypt.ReadToEnd(); // Read the decrypted bytes from the decrypting stream and place them in a string.

                    aesAlg.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
                return "";
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            var rawLength = new byte[sizeof(int)];

            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
                throw new SystemException("Stream did not contain properly formatted byte array");

            var buffer = new byte[BitConverter.ToInt32(rawLength, 0)];

            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
                throw new SystemException("Did not read byte array properly");

            return buffer;
        }
    }
}
