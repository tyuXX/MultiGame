using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace MultiGame
{
    public static class rntm
    {
        public static List<string> log = new List<string>();
        public static List<string> passcodes = new List<string> {"$sct"};
        public static string endecode = "";
        public static string username = "";
        public static bool clshown = false;
        public static bool fnfshown = false;
        public static bool logshown = false;
        public static bool addlogshown = false;
        public static bool toggledevmodeshown = false;
        public static bool shopshown = false;
        public static bool changeusernameshown = false;
        public static bool changepasscodeshown = false;
        public static bool devmode = false;
        public static int logupdateinterval = 10000;
        public static int autoclickerinterval = 1000;
        public static BigInteger money = 0;
        public static BigInteger generation = 1;
        public static BigInteger autogenmult = 0;
        public static BigInteger level = 1;
        public static BigInteger xp = 0;
        public static BigInteger xpn = 2;
        public static BigInteger add1 = 1;
        public static BigInteger add2 = 0;
        public static BigInteger add3 = 0;
        public static BigInteger add4 = 0;
        public static BigInteger add5 = 0;
        public static BigInteger add6 = 0;
        public static BigInteger add7 = 0;
        public static BigInteger add8 = 0;
        public static BigInteger add9 = 0;
        public static BigInteger add10 = 0;
        public static BigInteger mult1 = 1;
        public static BigInteger mult2 = 1;
        public static BigInteger mult3 = 1;
        public static BigInteger mult4 = 1;
        public static BigInteger mult5 = 1;
        public static BigInteger mult6 = 1;
        public static BigInteger mult7 = 1;
        public static BigInteger mult8 = 1;
        public static BigInteger mult9 = 1;
        public static BigInteger mult10 = 1;
        public static BigInteger getmoney()
        {
            return level*generation*((add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8 + add9 + add10) * (mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8 * mult9 * mult10));
        }
        public static BigInteger exponent(BigInteger n,BigInteger e)
        {
            BigInteger nn = n;
            for (BigInteger i = 0; i < (e-1); i++)
            {
                nn *= n;
            }
            return nn;
        }
        public static string encode(string toen)
        {
            byte[] data = UnicodeEncoding.Unicode.GetBytes(toen);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(endecode));
                using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripdes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string decode(string tode) 
        {
            byte[] data = Convert.FromBase64String(tode);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(endecode));
                using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripdes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UnicodeEncoding.Unicode.GetString(results);
                }
            }
        }
    }
}
