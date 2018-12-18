using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SSD_CRUD_APP
{
    class KeyClass
    {
        private string tempDir = Path.GetTempPath();
        public string CheckForFile(string tempDir)
        {
            var fileToFind = "Keys.csv";
            var result = Directory
                .EnumerateFiles(tempDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            return result;
        }
        public string newEncyptValues(List<string> oldValues)
        {
            List<long> seqKey = new List<long>(new long[] { 5, 0, 2, 3, 8, 7, 6, 9, 1, 4, 10 });
            List<long> seqIV = new List<long>(new long[] { 0, 5, 3, 2, 1, 4 });
            string newValue = "";
            if (oldValues.Count == 11)
            {
                foreach (long value in seqKey)
                {
                    newValue = newValue + oldValues[Convert.ToInt32(value)];
                }
            }
            else
            {
                foreach (long value in seqIV)
                {
                    newValue = newValue + oldValues[Convert.ToInt32(value)];
                }
            }

            return newValue;
        }
        private void StoreKeyIV(byte[] aesKey, byte[] aesIV)
        {
            if (CheckForFile(tempDir) != tempDir + "Keys.csv")
            {
                RSACryptoServiceProvider rsa =  GetKeyFromContainer("MyKeys");
                byte[] key = rsa.Encrypt(aesKey, false);
                byte[] iv = rsa.Encrypt(aesIV, false);
                string encryptKey = Convert.ToBase64String(key);
                string encryptIv = Convert.ToBase64String(iv);
                using (StreamWriter w = new StreamWriter(tempDir + "Keys.csv", append: true))
                {
                    var line = string.Format(encryptKey+","+encryptIv);
                    w.WriteLine(line);
                    w.Flush();
                    w.Close();
                }
                File.SetAttributes(tempDir + "Keys.csv", FileAttributes.Hidden);
            }
        }

        public void GenKey_SaveInContainer(string ContainerName)
        {
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
        }

        public RSACryptoServiceProvider GetKeyFromContainer(string ContainerName)
        {
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            return rsa;
        }
        public void MakePrivateKeyIV(AesCryptoServiceProvider aesEncrypt, string stringEncrypt)
        {
            MD5 md5 = MD5.Create();
            byte[] passbytes = Encoding.ASCII.GetBytes(stringEncrypt);
            aesEncrypt.Key = md5.ComputeHash(passbytes);
            aesEncrypt.IV = md5.ComputeHash(passbytes);
            StoreKeyIV(aesEncrypt.Key, aesEncrypt.IV);
        }
        public byte[] GetIV(AesCryptoServiceProvider aesEncrypt)
        {
            string line = "", value = "";
            byte[] DecryptedKey = { };
            if (CheckForFile(tempDir) == tempDir + "Keys.csv")
            {
                using (StreamReader reader = new StreamReader(tempDir + "Keys.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        var values = line.Split(',');
                        value = values[1];
                    }
                }
                RSACryptoServiceProvider rsa = GetKeyFromContainer("MyKeys");
                byte[] iv =  Convert.FromBase64String(value);
                DecryptedKey = rsa.Decrypt(iv, false);
            }
            return DecryptedKey;
        }
        public byte[] GetPrivateKey(AesCryptoServiceProvider aesEncrypt)
        {
            string line = "", value = "";
            byte[] DecryptedKey = { };
            if (CheckForFile(tempDir) == tempDir + "Keys.csv")
            {
                using (StreamReader reader = new StreamReader(tempDir + "Keys.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        var values = line.Split(',');
                        value = values[0];
                    }
                }
                RSACryptoServiceProvider rsa = GetKeyFromContainer("MyKeys");
                byte[] key = Convert.FromBase64String(value);
                DecryptedKey = rsa.Decrypt(key, false);
            }
            return DecryptedKey;
        }
    }
}
