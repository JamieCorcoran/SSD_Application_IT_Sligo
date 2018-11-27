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
        public List<string> BreakUpValues(string value)
        {
            List<string> newValue = new List<string>();
            int count = 0;
            while (!string.IsNullOrEmpty(value))
            {
                newValue.Add(value.Substring(0, 4));
                value = value.Remove(0, 4);
                count++;
            }
            return newValue;
        }
        public string GetKey(string type)
        {
            List<long> seqKey = new List<long>(new long[] { 1, 8, 2, 3, 9, 0, 6, 5, 4, 7, 10 });
            string value = "";
            string key = "";
            List<string> keyBreakUp = new List<string>();
            using (var reader = new StreamReader(tempDir + "Keys.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if(values[2] == type)
                        value = values[0];
                }
            }
            keyBreakUp = BreakUpValues(value);
            foreach (long number in seqKey)
            {
                key = key + keyBreakUp[Convert.ToInt32(number)];
            }
            return key;
        }
        public string GetIV(string type)
        {
            List<long> seqIV = new List<long>(new long[] { 0, 4, 3, 2, 5, 1 });
            string value = "";
            string iv = "";
            List<string> ivBreakUp = new List<string>();
            using (var reader = new StreamReader(tempDir + "Keys.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[2] == type)
                        value = values[1];
                }
            }
            ivBreakUp = BreakUpValues(value);
            foreach (long number in seqIV)
            {
                iv = iv + ivBreakUp[Convert.ToInt32(number)];
            }
            return iv;
        }
        public void StoreKey(AesCryptoServiceProvider _aesEncrypt,string type)
        {
            if (CheckForFile(tempDir) == tempDir + "Keys.csv")
            {
                string keyStored;
                string ivStored;
                List<string> keyBreakUp = new List<string>();
                List<string> ivBreakUp = new List<string>();

                keyBreakUp = BreakUpValues(Convert.ToBase64String(_aesEncrypt.Key));
                ivBreakUp = BreakUpValues(Convert.ToBase64String(_aesEncrypt.IV));
                keyStored = newEncyptValues(keyBreakUp);
                ivStored = newEncyptValues(ivBreakUp);

                using (StreamWriter w = new StreamWriter(tempDir + "Keys.csv", append: true))
                {
                    var line = string.Format(keyStored + "," + ivStored + "," + type);
                    w.WriteLine(line);
                    w.Flush();
                    w.Close();
                }
                File.SetAttributes(tempDir + "Keys.csv", FileAttributes.Hidden);
            }
        }
    }
}
