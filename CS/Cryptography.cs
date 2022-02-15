using System.IO;
using System.Security.Cryptography;

namespace Encryptor
{
    public class Cryptography
    {
        public static byte[] Encrypt(byte[] data, byte[] key, byte[] initVector)
        {
            Aes algorithm = Aes.Create();
            byte[] encryptedData;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform encryptor = algorithm.CreateEncryptor(key, initVector);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            encryptedData = memoryStream.ToArray();

            algorithm.Dispose();
            return encryptedData;
        }

        public static byte[] Decrypt(byte[] data, byte[] key, byte[] initVector)
        {
            Aes algorithm = Aes.Create();
            byte[] unencryptedData;
            ICryptoTransform decryptor = algorithm.CreateDecryptor(key, initVector);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write);

            cryptoStream.Write(data, 0, data.Length);
            try
            {
                cryptoStream.FlushFinalBlock();
            }
            catch
            {
                return null;
            }
            unencryptedData = memoryStream.ToArray();

            algorithm.Dispose();
            return unencryptedData;
        }

        public static byte[] DefaultInitVector(int lenght)
        {
            byte[] IV = new byte[lenght];
            for (int i = 0; i < lenght; i++) IV[i] = (byte)i;
            return IV;
        }
    }
}
