using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace PasswordManager {
    public static class RawBytes {
        public static byte[] GetBytes(this string data) => Encoding.UTF8.GetBytes(data);
        public static string GetString(this byte[] bytes) => Encoding.UTF8.GetString(bytes);
        public static byte[] GetHash(this string password) {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return SHA256.Create().ComputeHash(passwordBytes);
        }

        public static byte[] EncryptBytes(this string data, byte[] master) {
            if (string.IsNullOrEmpty(data) || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            return Encrypt(Encoding.UTF8.GetBytes(data), master);
        }
        public static byte[] EncryptBytes(byte[] data, byte[] master) {
            if (data.EmptyOrNull() || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            return Encrypt(data, master);
        }
        public static string Encrypt(string password, byte[] master) {
            if (string.IsNullOrEmpty(password) || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            var bytesToBeEncrypted = Encoding.UTF8.GetBytes(password);
            var bytesEncrypted = Encrypt(bytesToBeEncrypted, master);
            return Convert.ToBase64String(bytesEncrypted);

        }
        public static string Encrypt(string password, string master) {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(master))
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");
            
            var masterBytes = Encoding.UTF8.GetBytes(master);
            masterBytes = SHA256.Create().ComputeHash(masterBytes);
            return Encrypt(password, masterBytes);
        }

        public static string DecryptToString(this byte[] data, byte[] master) {
            if (data.EmptyOrNull() || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            var bytesDecrypted = Decrypt(data, master);
            return Encoding.UTF8.GetString(bytesDecrypted);
        }
        public static byte[] DecryptBytes(byte[] data, byte[] master) {
            if (data.EmptyOrNull() || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            return Decrypt(data, master);
        }
        public static string Decrypt(string password, byte[] master) {
            if (string.IsNullOrEmpty(password) || master.EmptyOrNull())
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            var bytesToBeDecrypted = Convert.FromBase64String(password);
            var bytesDecrypted = Decrypt(bytesToBeDecrypted, master);
            return Encoding.UTF8.GetString(bytesDecrypted);
        }
        public static string Decrypt(string password, string master) {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(master))
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");
            
            var masterBytes = Encoding.UTF8.GetBytes(master);
            masterBytes = SHA256.Create().ComputeHash(masterBytes);
            return Decrypt(password, masterBytes);
        }

        public static string[] DecryptAll(byte[] master, string[] passwords) {
            if (master.EmptyOrNull() || passwords == null || passwords.Length == 0)
                throw new ArgumentNullException("password/master", "Either master password on encoded password is null");

            var output = new string[passwords.Length];
            for (int i = 0; i < passwords.Length; i++) {
                var bytesToBeDecrypted = Convert.FromBase64String(passwords[i]);
                var bytesDecrypted = Decrypt(bytesToBeDecrypted, master);
                output[i] = Encoding.UTF8.GetString(bytesDecrypted);
            }
            return output;
        }

        private static byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes) {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] { 145, 137, 221, 93, 46, 107, 105, 80, 70, 139, 15, 27, 122, 28, 185, 42, 188, 13, 52, 156, 173, 190, 83, 78, 84 };

            using (MemoryStream ms = new MemoryStream()) {
                using (RijndaelManaged AES = new RijndaelManaged()) {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write)) {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }

                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes) {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] { 145, 137, 221, 93, 46, 107, 105, 80, 70, 139, 15, 27, 122, 28, 185, 42, 188, 13, 52, 156, 173, 190, 83, 78, 84 };

            using (MemoryStream ms = new MemoryStream()) {
                using (RijndaelManaged AES = new RijndaelManaged()) {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write)) {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }

                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static byte[] GetBytes(this System.Drawing.Image image) {
            using (var ms = new MemoryStream()) {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static System.Drawing.Image GetImage(this byte[] imagedata) {
            if (imagedata.EmptyOrNull())
                throw new ArgumentNullException("ImageData", "ImageData is null");

            MemoryStream ms = new MemoryStream(imagedata);
            var image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        private static bool EmptyOrNull(this byte[] data) {
            return data == null || data.Length == 0;
        }

    }
}
