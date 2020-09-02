using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Util
{
    class Services
    {
        public static string Convert_RTSGeoCodeQuality(Int32 p_ID)
        {
            // 0000 - NOT GEOCODED
            // 5601 - STREET EXACT
            // 5501 - HIGH CONFIDENCE
            // 5401 - MEDIUM CONFIDENCE
            // 5301 - LOW CONFIDENCE
            // 5201 - AMBIGUOUS STREET
            // 5001 - AUTO STREET
            // 5100 - MANUAL STREET
            // 5200 - AUTO CROSS STREET
            // 9001 - SELF GEOCODED
            // 9003 - USER SUPPLIED
            // 9004 - GPS
            // 1001 - POSTAL
            // 1004 - POSTAL EXTENDED
            // 1005 - CITY

            string DESC;

            switch (p_ID)
            {
                case 5601:
                    {
                        DESC = "STREET EXACT";
                        break;
                    }
                case 5501:
                    {
                        DESC = "HIGH CONFIDENCE";
                        break;
                    }
                case 5401:
                    {
                        DESC = "MEDIUM CONFIDENCE ";
                        break;
                    }
                case 5301:
                    {
                        DESC = "LOW CONFIDENCE";
                        break;
                    }
                case 5201:
                    {
                        DESC = "AMBIGUOUS STREET";
                        break;
                    }
                case 5001:
                    {
                        DESC = "AUTO STREET";
                        break;
                    }
                case 5100:
                    {
                        DESC = "MANUAL STREET";
                        break;
                    }
                case 5200:
                    {
                        DESC = "AUTO CROSS STREET";
                        break;
                    }
                case 9001:
                    {
                        DESC = "SELF GEOCODED";
                        break;
                    }
                case 9003:
                    {
                        DESC = "USER SUPPLIED";
                        break;
                    }
                case 9004:
                    {
                        DESC = "GPS";
                        break;
                    }
                case 1001:
                    {
                        DESC = "POSTAL";
                        break;
                    }
                case 1004:
                    {
                        DESC = "POSTAL EXTENDED";
                        break;
                    }
                case 1005:
                    {
                        DESC = "CITY";
                        break;
                    }
                case 0:
                    {
                        DESC = "NOT GEOCODED";
                        break;
                    }
                default:
                    {
                        DESC = "UNKNOW";
                        break;
                    }
            }

            return DESC;
        }

        public static string Convert_RTSGeoCodeVerified(string p_COD)
        {
            string DESC;

            switch (p_COD)
            {
                case "T":
                    {
                        DESC = "X";
                        break;
                    }
                case "F":
                    {
                        DESC = "";
                        break;
                    }
                default:
                    {
                        DESC = "?";
                        break;
                    }
            }

            return DESC;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "@Omnitracs";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
