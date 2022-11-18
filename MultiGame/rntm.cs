using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace MultiGame
{
    public static class rntm
    {
        public static Random rng = new Random();
        public static Thread timerthread = new Thread(timerth);
        public static List<string> log = new List<string>();
        public static List<string> passcodes = new List<string> {"$sct"};
        public static string endecode = "1234";
        public static string username = "Player";
        public static bool clshown = false;
        public static bool fnfshown = false;
        public static bool logshown = false;
        public static bool addlogshown = false;
        public static bool toggledevmodeshown = false;
        public static bool shopshown = false;
        public static bool changeusernameshown = false;
        public static bool changepasscodeshown = false;
        public static bool savegameshown = false;
        public static bool opengameshown = false;
        public static bool gamesincshown = false;
        public static bool devmode = false;
        public static bool cheat = false;
        public static bool companywork = false;
        public static bool alwaysontop = false;
        public static int logupdateinterval = 10000;
        public static int autoclickerinterval = 1000;
        public static BigInteger autoclickerintervaln = 5000 * exponent(7, 1001 - autoclickerinterval);
        public static BigInteger timespent = 0;
        public static BigInteger money = 0;
        public static BigInteger generation = 1;
        public static BigInteger outcome = 0;
        public static BigInteger autogenmult = 0;
        public static BigInteger autogenmultn = 1000 * (exponent(5, autogenmult) + 1);
        public static BigInteger level = 0;
        public static BigInteger xp = 0;
        public static BigInteger xpn = 2;
        public static BigInteger add1 = 1;
        public static BigInteger add1n = 250 * (exponent(2, add1) + 1);
        public static BigInteger add2 = 0;
        public static BigInteger add2n = 250 * (exponent(2, add2) + 1);
        public static BigInteger add3 = 0;
        public static BigInteger add3n = 250 * (exponent(2, add3) + 1);
        public static BigInteger add4 = 0;
        public static BigInteger add4n = 250 * (exponent(2, add4) + 1);
        public static BigInteger add5 = 0;
        public static BigInteger add5n = 250 * (exponent(2, add5) + 1);
        public static BigInteger add6 = 0;
        public static BigInteger add6n = 250 * (exponent(2, add6) + 1);
        public static BigInteger add7 = 0;
        public static BigInteger add7n = 250 * (exponent(2, add7) + 1);
        public static BigInteger add8 = 0;
        public static BigInteger add8n = 250 * (exponent(2, add8) + 1);
        public static BigInteger add9 = 0;
        public static BigInteger add9n = 250 * (exponent(2, add9) + 1);
        public static BigInteger add10 = 0;
        public static BigInteger add10n = 250 * (exponent(2, add10) + 1);
        public static BigInteger mult1 = 1;
        public static BigInteger mult1n = 500 * (exponent(3, mult1) + 1);
        public static BigInteger mult2 = 1;
        public static BigInteger mult2n = 500 * (exponent(3, mult2) + 1);
        public static BigInteger mult3 = 1;
        public static BigInteger mult3n = 500 * (exponent(3, mult3) + 1);
        public static BigInteger mult4 = 1;
        public static BigInteger mult4n = 500 * (exponent(3, mult4) + 1);
        public static BigInteger mult5 = 1;
        public static BigInteger mult5n = 500 * (exponent(3, mult5) + 1);
        public static BigInteger mult6 = 1;
        public static BigInteger mult6n = 500 * (exponent(3, mult6) + 1);
        public static BigInteger mult7 = 1;
        public static BigInteger mult7n = 500 * (exponent(3, mult7) + 1);
        public static BigInteger mult8 = 1;
        public static BigInteger mult8n = 500 * (exponent(3, mult8) + 1);
        public static BigInteger mult9 = 1;
        public static BigInteger mult9n = 500 * (exponent(3, mult9) + 1);
        public static BigInteger mult10 = 1;
        public static BigInteger mult10n = 500 * (exponent(3, mult10) + 1);
        public static BigInteger workers = 0;
        public static BigInteger workersn = 250 * (exponent(2, workers) + 1);
        public static BigInteger inventions = 0;
        public static BigInteger inventionsn = 100 * (exponent(3, inventions) + 1);
        public static BigInteger minicompanies = 1;
        public static BigInteger minicompaniesn = 500 * (exponent(9, minicompanies) + 1);
        public static BigInteger companynetworth = 0;
        public static BigInteger invested = 1;
        public static BigInteger investedn = 250 * (exponent(2, invested) + 1);
        public static BigInteger boost1 = 1;
        public static BigInteger boost1t = 0;
        public static BigInteger boost2 = 1;
        public static BigInteger boost2t = 0;
        public static BigInteger boost3 = 1;
        public static BigInteger boost3t = 0;
        public static BigInteger boost4 = 1;
        public static BigInteger boost4t = 0;
        public static BigInteger boost5 = 1;
        public static BigInteger boost5t = 0;
        public static BigInteger boost6 = 1;
        public static BigInteger boost6t = 0;
        public static BigInteger boost7 = 1;
        public static BigInteger boost7t = 0;
        public static BigInteger boost8 = 1;
        public static BigInteger boost8t = 0;
        public static BigInteger boost9 = 1;
        public static BigInteger boost9t = 0;
        public static BigInteger boost10 = 1;
        public static BigInteger boost10t = 0;
        public static void recalculatevars()
        {
            investedn = 250 * (exponent(2, invested) + 1);
            minicompaniesn = 500 * (exponent(9, minicompanies) + 1);
            inventionsn = 100 * (exponent(3, inventions) + 1);
            workersn = 250 * (exponent(2, workers) + 1);
            mult10n = 500 * (exponent(3, mult10) + 1);
            mult9n = 500 * (exponent(3, mult9) + 1);
            mult8n = 500 * (exponent(3, mult8) + 1);
            mult7n = 500 * (exponent(3, mult7) + 1);
            mult6n = 500 * (exponent(3, mult6) + 1);
            mult5n = 500 * (exponent(3, mult5) + 1);
            mult4n = 500 * (exponent(3, mult4) + 1);
            mult3n = 500 * (exponent(3, mult3) + 1);
            mult2n = 500 * (exponent(3, mult2) + 1);
            mult1n = 500 * (exponent(3, mult1) + 1);
            add10n = 250 * (exponent(2, add10) + 1);
            add9n = 250 * (exponent(2, add9) + 1);
            add8n = 250 * (exponent(2, add8) + 1);
            add7n = 250 * (exponent(2, add7) + 1);
            add6n = 250 * (exponent(2, add6) + 1);
            add5n = 250 * (exponent(2, add5) + 1);
            add4n = 250 * (exponent(2, add4) + 1);
            add3n = 250 * (exponent(2, add3) + 1);
            add2n = 250 * (exponent(2, add2) + 1);
            add1n = 250 * (exponent(2, add1) + 1);
            autogenmultn = 1000 * (exponent(5, autogenmult) + 1);
            autoclickerintervaln = 5000 * exponent(7, 1001 - autoclickerinterval);
        }
        public static BigInteger getmoney()
        {
            BigInteger rt = (level * generation * ((add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8 + add9 + add10) * (mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8 * mult9 * mult10 * boost1 * boost2 * boost3 * boost4 * boost5 * boost6 * boost7 * boost8 * boost9 * boost10))) - (outcome / minicompanies);
            if(rt < 1) 
            {
                return 1;
            }
            else
            {
                return rt;
            }
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
        public static void timerth()
        {
            while (true)
            {
                Thread.Sleep(999);
                timespent++;
            }
        }
    }
}
