﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PrivacyVault
{
    public class cryptoHandler
    {
        #region Declarations
        // Define default min and max password lengths.
        private static int DEFAULT_MIN_PASSWORD_LENGTH = 8;
        private static int DEFAULT_MAX_PASSWORD_LENGTH = 12;

        // Define supported password characters divided into groups.
        // You can add (or remove) characters to (from) these groups.
        private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";
        private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";
        private static string PASSWORD_CHARS_NUMERIC = "23456789";
        private static string PASSWORD_CHARS_SPECIAL = "*$-+?_=!%{}/";

        //Constant encryption values
        const int passwordIterations = 3;
        const string hashAlgorithm = "SHA1";
        const int keySize = 256;

        #endregion

        #region Data Elements

        private string key, initializationVector, salt;
        public string saltAndIV;
        private int i;
        HashManager hm;

        #endregion


        #region Constructor
        //Contructor for a new crypto object
        public cryptoHandler(string keyMaterial, int iterations)
        {
            hm = new HashManager("SHA256", iterations);
            key = keyMaterial + flip(keyMaterial);
            string token = hm.compute(flip(key) + key, false);
            salt = Left(hm.compute(flip(token), false), 8);
            initializationVector = flip(Right(hm.compute(token, false), 16));
            i = iterations;
        }

        #endregion

        #region Member Methods

        public string Encrypt(string plainText)
        {
            if (i == 0) return plainText;

            string cipherText = plainText;

            for (int x = 0; x < i; x++)
            {
                cipherText = EncryptData(plainText);
                plainText = cipherText;
            }

            return cipherText;
        }

        private string EncryptData(string plainText)
        {
            // Convert strings into byte arrays.
            // Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initializationVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);

            // Convert our plaintext into a byte array.
            // Let us assume that plaintext contains UTF8-encoded characters.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // First, we must create a password, from which the key will be derived.
            // This password will be generated from the specified passphrase and 
            // salt value. The password will be created using the specified hash 
            // algorithm. Password creation can be done in several iterations.
            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            key,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            // Use the password to generate pseudo-random bytes for the encryption
            // key. Specify the size of the key in bytes (instead of bits).
            byte[] keyBytes = password.GetBytes(keySize / 8);

            // Create uninitialized Rijndael encryption object.
            RijndaelManaged symmetricKey = new RijndaelManaged();

            // It is reasonable to set encryption mode to Cipher Block Chaining
            // (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC;

            // Generate encryptor from the existing key bytes and initialization 
            // vector. Key size will be defined based on the number of the key 
            // bytes.
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            // Define memory stream which will be used to hold encrypted data.
            MemoryStream memoryStream = new MemoryStream();

            // Define cryptographic stream (always use Write mode for encryption).
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         encryptor,
                                                         CryptoStreamMode.Write);
            // Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            // Finish encrypting.
            cryptoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memoryStream.ToArray();

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert encrypted data into a base64-encoded string.
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            // Return encrypted string.
            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            if (i == 0) return cipherText;

            string plainText = null;

            for (int x = 0; x < i; x++)
            {
                plainText = DecryptData(cipherText);
                cipherText = plainText;
            }

            return plainText;
        }

        private string DecryptData(string cipherText)
        {
            // Convert strings defining encryption key characteristics into byte
            // arrays. Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initializationVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);

            // Convert our ciphertext into a byte array.
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            // First, we must create a password, from which the key will be 
            // derived. This password will be generated from the specified 
            // passphrase and salt value. The password will be created using
            // the specified hash algorithm. Password creation can be done in
            // several iterations.
            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            key,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            // Use the password to generate pseudo-random bytes for the encryption
            // key. Specify the size of the key in bytes (instead of bits).
            byte[] keyBytes = password.GetBytes(keySize / 8);

            // Create uninitialized Rijndael encryption object.
            RijndaelManaged symmetricKey = new RijndaelManaged();

            // It is reasonable to set encryption mode to Cipher Block Chaining
            // (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC;

            // Generate decryptor from the existing key bytes and initialization 
            // vector. Key size will be defined based on the number of the key 
            // bytes.
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            // Define memory stream which will be used to hold encrypted data.
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            // Define cryptographic stream (always use Read mode for encryption).
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                          decryptor,
                                                          CryptoStreamMode.Read);

            // Since at this point we don't know what the size of decrypted data
            // will be, allocate the buffer long enough to hold ciphertext;
            // plaintext is never longer than ciphertext.
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            // Start decrypting.
            int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                       0,
                                                       plainTextBytes.Length);

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert decrypted data into a string. 
            // Let us assume that the original plaintext string was UTF8-encoded.
            string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                       0,
                                                       decryptedByteCount);

            // Return decrypted string.   
            return plainText;
        }

        #endregion

        #region Static Methods

        public static string GenerateRandomPassword()
        {

            return GeneratePassword(DEFAULT_MIN_PASSWORD_LENGTH,
                        DEFAULT_MAX_PASSWORD_LENGTH);

        }

        public static string GenerateRandomPassword(int length)
        {
            return GeneratePassword(length, length);
        }

        public static string GeneratePassword(int minLength, int maxLength)
        {
            // Make sure that input parameters are valid.
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
                return null;

            // Create a local array containing supported password characters
            // grouped by types. You can remove character groups from this
            // array, but doing so will weaken the password strength.
            char[][] charGroups = new char[][] {
                        PASSWORD_CHARS_LCASE.ToCharArray(),
                        PASSWORD_CHARS_UCASE.ToCharArray(),
                        PASSWORD_CHARS_NUMERIC.ToCharArray(),
                        PASSWORD_CHARS_SPECIAL.ToCharArray()
                };

            // Use this array to track the number of unused characters in each
            // character group.
            int[] charsLeftInGroup = new int[charGroups.Length];

            // Initially, all characters in each group are not used.
            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = charGroups[i].Length;

            // Use this array to track (iterate through) unused character groups.
            int[] leftGroupsOrder = new int[charGroups.Length];

            // Initially, all character groups are not used.
            for (int i = 0; i < leftGroupsOrder.Length; i++)
                leftGroupsOrder[i] = i;

            // Because we cannot use the default randomizer, which is based on the
            // current time (it will produce the same "random" number within a
            // second), we will use a random number generator to seed the
            // randomizer.

            // Use a 4-byte array to fill it with random bytes and convert it then
            // to an integer value.
            byte[] randomBytes = new byte[4];

            // Generate 4 random bytes.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            // Convert 4 bytes into a 32-bit integer value.
            int seed = (randomBytes[0] & 0x7f) << 24 |
                        randomBytes[1] << 16 |
                        randomBytes[2] << 8 |
                        randomBytes[3];

            // Now, this is real randomization.
            Random random = new Random(seed);

            // This array will hold password characters.
            char[] password = null;

            // Allocate appropriate memory for the password.
            if (minLength < maxLength)
                password = new char[random.Next(minLength, maxLength + 1)];
            else
                password = new char[minLength];

            // Index of the next character to be added to password.
            int nextCharIdx;

            // Index of the next character group to be processed.
            int nextGroupIdx;

            // Index which will be used to track not processed character groups.
            int nextLeftGroupsOrderIdx;

            // Index of the last non-processed character in a group.
            int lastCharIdx;

            // Index of the last non-processed group.
            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

            // Generate password characters one at a time.
            for (int i = 0; i < password.Length; i++)
            {
                // If only one character group remained unprocessed, process it;
                // otherwise, pick a random character group from the unprocessed
                // group list. To allow a special character to appear in the
                // first position, increment the second parameter of the Next
                // function call by one, i.e. lastLeftGroupsOrderIdx + 1.
                if (lastLeftGroupsOrderIdx == 0)
                    nextLeftGroupsOrderIdx = 0;
                else
                    nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx);

                // Get the actual index of the character group, from which we will
                // pick the next character.
                nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

                // Get the index of the last unprocessed characters in this group.
                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                // If only one unprocessed character is left, pick it; otherwise,
                // get a random character from the unused character list.
                if (lastCharIdx == 0)
                    nextCharIdx = 0;
                else
                    nextCharIdx = random.Next(0, lastCharIdx + 1);

                // Add this character to the password.
                password[i] = charGroups[nextGroupIdx][nextCharIdx];

                // If we processed the last character in this group, start over.
                if (lastCharIdx == 0)
                    charsLeftInGroup[nextGroupIdx] = charGroups[nextGroupIdx].Length;
                // There are more unprocessed characters left.
                else
                {
                    // Swap processed character with the last unprocessed character
                    // so that we don't pick it until we process all characters in
                    // this group.
                    if (lastCharIdx != nextCharIdx)
                    {
                        char temp = charGroups[nextGroupIdx][lastCharIdx];
                        charGroups[nextGroupIdx][lastCharIdx] = charGroups[nextGroupIdx][nextCharIdx];
                        charGroups[nextGroupIdx][nextCharIdx] = temp;
                    }
                    // Decrement the number of unprocessed characters in
                    // this group.
                    charsLeftInGroup[nextGroupIdx]--;
                }

                // If we processed the last group, start all over.
                if (lastLeftGroupsOrderIdx == 0)
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                // There are more unprocessed groups left.
                else
                {
                    // Swap processed group with the last unprocessed group
                    // so that we don't pick it until we process all groups.
                    if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                    {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] = leftGroupsOrder[nextLeftGroupsOrderIdx];
                        leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                    }
                    // Decrement the number of unprocessed groups.
                    lastLeftGroupsOrderIdx--;
                }
            }

            // Convert password characters into a string and return the result.
            return new string(password);
        }

        public static string MD5(string textToHash)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] emailBytes = System.Text.Encoding.UTF8.GetBytes(textToHash.ToLower());
            byte[] hashedEmailBytes = md5.ComputeHash(emailBytes);
            System.Text.StringBuilder sb = new StringBuilder();
            foreach (var b in hashedEmailBytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        public static string hashFileMD5(string filePath)
        {
            string strResult = "";
            string strHashData = "";

            byte[] arrbytHashValue;

            System.IO.FileStream oFileStream = null;

            System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();

            try
            {

                oFileStream = GetFileStream(filePath);
                arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);
                oFileStream.Close();

                strHashData = System.BitConverter.ToString(arrbytHashValue);
                strHashData = strHashData.Replace("-", "");
                strResult = strHashData;
            }

            catch (System.Exception ex)
            {
                return "An Exception was encountered:" + Environment.NewLine + Environment.NewLine + ex.ToString();
            }

            return (strResult);
        }

        private static System.IO.FileStream GetFileStream(string pathName)
        {
            return (new System.IO.FileStream(pathName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite));
        }

        public static bool importPFX(string pfxFile, string password, string storeLoc, string serialnumber)
        {
            try
            {
                X509Certificate2 certificate = new X509Certificate2(pfxFile, password);

                X509Store store = openStore(storeLoc);

                if (store != null)
                {
                    store.Add(certificate);
                    store.Close();

                    return certFoundInStore(storeLoc, serialnumber);
                }
                else
                    return false;
            }

            catch (CryptographicException)
            {
                return false;
            }
        }

        public static bool certFoundInStore(string storeLoc, string sn)
        {
            X509Store store = openStore(storeLoc);
            string currentCertSN;
            string serialnumber = sn.ToUpper();

            foreach (X509Certificate2 cert in store.Certificates)
            {
                currentCertSN = cert.GetSerialNumberString();
                if (currentCertSN.ToUpper() == serialnumber)
                    return true;
            }

            return false;
        }

        private static X509Store openStore(string storeLoc)
        {
            X509Store store;
            switch (storeLoc)
            {
                case "CurrentUser":
                    store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                    break;
                case "LocalMachine":
                    store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                    break;
                default:
                    return null;
            }
            store.Open(OpenFlags.MaxAllowed);
            return store;
        }

        public static string flip(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string Left(string param, int length)
        {
            if (length > param.Length)
                return null;
            else
                return param.Substring(0, length);
        }

        public static string Right(string param, int index)
        {
            if (index > param.Length)
                return null;
            else
                return param.Substring(param.Length - index, index);
        }

        #endregion
    }

    class HashManager
    {
        #region Declarations

        HashAlgorithm hash;
        int hashSize;
        int i;

        #endregion

        #region Constructors

        public HashManager(string hashAlgorithm, int iterations)
        {
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hash = new SHA1Managed();
                    hashSize = 20;
                    break;

                case "SHA256":
                    hash = new SHA256Managed();
                    hashSize = 32;
                    break;

                case "SHA384":
                    hash = new SHA384Managed();
                    hashSize = 48;
                    break;

                case "SHA512":
                    hash = new SHA512Managed();
                    hashSize = 64;
                    break;

                case "MD5":
                    hash = new MD5CryptoServiceProvider();
                    hashSize = 16;
                    break;

                default:
                    hash = new SHA256Managed();
                    hashSize = 32;
                    break;
            }

            i = iterations;
        }
        #endregion

        #region Member Methods

        public string compute(string message, bool useSalt)
        {
            if (useSalt)
                return compute(message);
            else
                return computeNoSalt(message);
        }

        public string compute(string message, string salt)
        {
            return computeWithKnownSalt(message, salt);
        }

        private string compute(string message)
        {
            if ((message == null) || (message == ""))
                return null;

            byte[] salt = getBytes(cryptoHandler.GeneratePassword(4, 8));

            byte[] messageBytes = getBytes(message);
            byte[] messageBytesWithSalt = concatenate(messageBytes, salt);
            byte[] hashValue = messageBytes;

            for (int x = 0; x < i; x++)
            {
                hashValue = hash.ComputeHash(messageBytesWithSalt);
                messageBytesWithSalt = hashValue;
            }

            //MessageBox.Show("Computed hash with a new salt..." + Environment.NewLine + "Message: " + message + Environment.NewLine + "Hash Value: " + Convert.ToBase64String(hashValue) + Environment.NewLine + "Salt: " + Convert.ToBase64String(salt));
            return Convert.ToBase64String(concatenate(hashValue, salt));
        }

        private string computeWithKnownSalt(string message, string salt)
        {
            if ((message == null) || (message == ""))
                return null;

            byte[] saltBytes = getBytes(salt);

            byte[] messageBytes = getBytes(message);
            byte[] messageBytesWithSalt = concatenate(messageBytes, saltBytes);
            byte[] hashValue = messageBytes;

            for (int x = 0; x < i; x++)
            {
                hashValue = hash.ComputeHash(messageBytesWithSalt);
                messageBytesWithSalt = hashValue;
            }

            //MessageBox.Show("Computed hash with known salt..." + Environment.NewLine + "Message: " + message + Environment.NewLine + "Hash Value: " + Convert.ToBase64String(hashValue) + Environment.NewLine + "Salt: " + salt);
            return Convert.ToBase64String(concatenate(hashValue, saltBytes));
        }

        private string computeNoSalt(string plaintext)
        {
            if ((plaintext == null) || (plaintext == ""))
                return null;

            byte[] plainTextBytes = getBytes(plaintext);
            byte[] hashValue = plainTextBytes;

            for (int x = 0; x < i; x++)
            {
                hashValue = hash.ComputeHash(plainTextBytes);
                plainTextBytes = hashValue;
            }

            return Convert.ToBase64String(hashValue);
        }

        public bool verify(string message, string digest)
        {
            if (digest.Length < hashSize)
                return false;

            if (digest.Length > hashSize)
            {
                byte[] saltBytes = getSalt(digest);
                string salt = ASCIIEncoding.ASCII.GetString(saltBytes);
                return verifyWithSalt(message, digest, salt);
            }

            return verifyNoSalt(message, digest);
        }

        private bool verifyWithSalt(string message, string expectedDigest, string salt)
        {
            string actualDigest = computeWithKnownSalt(message, salt);
            return (expectedDigest == actualDigest);
        }

        private bool verifyNoSalt(string message, string expectedDigest)
        {
            string actualDigest = computeNoSalt(message);
            return (expectedDigest == actualDigest);
            /*byte[] plainTextBytes = getBytes(plaintext);
            byte[] expectedHash = plainTextBytes;

            for (int x = 0; x < i; x++)
            {
                expectedHash = hash.ComputeHash(plainTextBytes);
                plainTextBytes = expectedHash;
            }

            return (Convert.ToBase64String(expectedHash) == digest); */
        }

        private byte[] getBytes(string message)
        {
            try
            {
                byte[] value = Encoding.UTF8.GetBytes(message);
                return value;
            }
            catch (System.FormatException)
            {
                return null;
            }
        }

        private byte[] getSalt(string digest)
        {
            byte[] hashWithSaltBytes = Convert.FromBase64String(digest);
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSize];

            for (int index = 0; index < saltBytes.Length; index++)
                saltBytes[index] = hashWithSaltBytes[hashSize + index];

            return saltBytes;
        }

        private byte[] concatenate(byte[] messageBytes, byte[] saltBytes)
        {
            byte[] combinedMessage = new byte[messageBytes.Length + saltBytes.Length];

            for (int index = 0; index < messageBytes.Length; index++)
                combinedMessage[index] = messageBytes[index];
            for (int index = 0; index < saltBytes.Length; index++)
                combinedMessage[messageBytes.Length + index] = saltBytes[index];

            return combinedMessage;
        }

        #endregion

    }
}
