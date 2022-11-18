using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiGame
{
    public static class rntm
    {
        public static Form mainform;
        public static Random rng = new Random();
        public static Thread timerthread = new Thread(timerth);
        public static List<string> log = new List<string>();
        public static List<string> passcodes = new List<string> {"$sct"};
        public static string endecode = "1234";
        public static string username = "Player";
        public static bool[] advance = { false, false };
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
        public static bool shop2shown = false;
        public static bool aboutshown = false;
        public static bool magicshown = false;
        public static bool magicpowergeneratorshown = false;
        public static bool devmode = false;
        public static bool cheat = false;
        public static bool companywork = false;
        public static bool alwaysontop = false;
        public static bool autocollectboosts = false;
        public static bool automaticupgrade = false;
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
        public static BigInteger magicpower = 0;
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
        public static void upadd1()
        {
            if (money >= add1n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add1);
                money -= add1n;
                add1n *= 2;
                add1++;
            }
        }
        public static void upadd2()
        {
            if (money >= add2n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add2 now:" + add2);
                money -= add2n;
                add2n *= 2;
                add2++;
            }
        }
        public static void upadd3()
        {
            if (money >= add3n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add3 now:" + add3);
                money -= add3n;
                add3n *= 2;
                add3++;
            }
        }
        public static void upadd4()
        {
            if (money >= add4n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add4 now:" + add4);
                money -= add4n;
                add4n *= 2;
                add4++;
            }
        }
        public static void upadd5()
        {
            if (money >= add5n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add5);
                money -= add5n;
                add5n *= 2;
                add5++;
            }
        }
        public static void upadd6()
        {
            if (money >= add6n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add6 now:" + add6);
                money -= add6n;
                add6n *= 2;
                add6++;
            }
        }
        public static void upadd7()
        {
            if (money >= add7n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add7 now:" + add7);
                money -= add7n;
                add7n *= 2;
                add7++;
            }
        }
        public static void upadd8()
        {
            if (money >= add8n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add8 now:" + add8);
                money -= add8n;
                add8n *= 2;
                add8++;
            }
        }
        public static void upadd9()
        {
            if (money >= add9n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add9 now:" + add9);
                money -= add9n;
                add9n *= 2;
                add9++;
            }
        }
        public static void upadd10()
        {
            if (money >= add10n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add10 now:" + add10);
                money -= add10n;
                add10n *= 2;
                add10++;
            }
        }
        public static void upmult1()
        {
            if (money >= mult1n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult1 now:" + mult1);
                money -= mult1n;
                mult1n *= 3;
                mult1++;
            }
        }
        public static void upmult2()
        {
            if (money >= mult2n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult2 now:" + mult2);
                money -= mult2n;
                mult2n *= 3;
                mult2++;
            }
        }
        public static void upmult3()
        {
            if (money >= mult3n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult3 now:" + mult3);
                money -= mult3n;
                mult3n *= 3;
                mult3++;
            }
        }
        public static void upmult4()
        {
            if (money >= mult4n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult4 now:" + mult4);
                money -= mult4n;
                mult4n *= 3;
                mult4++;
            }
        }
        public static void upmult5()
        {
            if (money >= mult5n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult5 now:" + mult5);
                money -= mult5n;
                mult5n *= 3;
                mult5++;
            }
        }
        public static void upmult6()
        {
            if (money >= mult6n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult6 now:" + mult6);
                money -= mult6n;
                mult6n *= 3;
                mult6++;
            }
        }
        public static void upmult7()
        {
            if (money >= mult7n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult7 now:" + mult7);
                money -= mult7n;
                mult7n *= 3;
                mult7++;
            }
        }
        public static void upmult8()
        {
            if (money >= mult8n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult8 now:" + mult8);
                money -= mult8n;
                mult8n *= 3;
                mult8++;
            }
        }
        public static void upmult9()
        {
            if (money >= mult9n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult9 now:" + mult9);
                money -= mult9n;
                mult9n *= 3;
                mult9++;
            }
        }
        public static void upmult10()
        {
            if (money >= mult10n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + mult10);
                money -= mult10n;
                mult10n *= 3;
                mult10++;
            }
        }
        public static void upautogenmult()
        {
            if (money >= autogenmultn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + autogenmult);
                money -= autogenmultn;
                autogenmultn *= 5;
                autogenmult++;
            }
        }
        public static void upautoclickerspeed()
        {
            if (autoclickerinterval > 2)
            {
                if (money >= autoclickerintervaln)
                {
                    log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased autoclicker speed now:" + autoclickerinterval);
                    money -= autoclickerintervaln;
                    autoclickerintervaln *= 7;
                    autoclickerinterval--;
                }
            }
        }
        public static void savegame(string filepath)
        {
            if (!string.IsNullOrEmpty(filepath))
            {
                string[] masterfile =
                {
                    encode(endecode),
                    encode(username),
                    encode(logupdateinterval.ToString()),
                    encode(autoclickerinterval.ToString()),
                    encode(money.ToString()),
                    encode(generation.ToString()),
                    encode(outcome.ToString()),
                    encode(autogenmult.ToString()),
                    encode(level.ToString()),
                    encode(xp.ToString()),
                    encode(xpn.ToString()),
                    encode(add1.ToString()),
                    encode(add2.ToString()),
                    encode(add3.ToString()),
                    encode(add4.ToString()),
                    encode(add5.ToString()),
                    encode(add6.ToString()),
                    encode(add7.ToString()),
                    encode(add8.ToString()),
                    encode(add9.ToString()),
                    encode(add10.ToString()),
                    encode(mult1.ToString()),
                    encode(mult2.ToString()),
                    encode(mult3.ToString()),
                    encode(mult4.ToString()),
                    encode(mult5.ToString()),
                    encode(mult6.ToString()),
                    encode(mult7.ToString()),
                    encode(mult8.ToString()),
                    encode(mult9.ToString()),
                    encode(mult10.ToString()),
                    encode(timespent.ToString()),
                    encode(workers.ToString()),
                    encode(inventions.ToString()),
                    encode(minicompanies.ToString()),
                    encode(companynetworth.ToString()),
                    encode(invested.ToString()),
                    encode(autocollectboosts.ToString()),
                    encode(automaticupgrade.ToString()),
                    encode(magicpower.ToString())
                };
                File.WriteAllLines(filepath, masterfile);
            }
        }
        public static void opengame(string filepath,string passcodes)
        {
            string[] masterfile = File.ReadAllLines(filepath);
            string endest = endecode;
            endecode = passcodes;
            if (decode(masterfile[0]) == passcodes)
            {
                endecode = passcodes;
                try { username = decode(masterfile[1]); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { logupdateinterval = Convert.ToInt32(decode(masterfile[2])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autoclickerinterval = Convert.ToInt32(decode(masterfile[3])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { money = BigInteger.Parse(decode(masterfile[4])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { generation = BigInteger.Parse(decode(masterfile[5])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { outcome = BigInteger.Parse(decode(masterfile[6])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autogenmult = BigInteger.Parse(decode(masterfile[7])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { level = BigInteger.Parse(decode(masterfile[8])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xp = BigInteger.Parse(decode(masterfile[9])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xpn = BigInteger.Parse(decode(masterfile[10])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add1 = BigInteger.Parse(decode(masterfile[11])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add2 = BigInteger.Parse(decode(masterfile[12])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add3 = BigInteger.Parse(decode(masterfile[13])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add4 = BigInteger.Parse(decode(masterfile[14])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add5 = BigInteger.Parse(decode(masterfile[15])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add6 = BigInteger.Parse(decode(masterfile[16])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add7 = BigInteger.Parse(decode(masterfile[17])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add8 = BigInteger.Parse(decode(masterfile[18])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add9 = BigInteger.Parse(decode(masterfile[19])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add10 = BigInteger.Parse(decode(masterfile[20])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult1 = BigInteger.Parse(decode(masterfile[21])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult2 = BigInteger.Parse(decode(masterfile[22])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult3 = BigInteger.Parse(decode(masterfile[23])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult4 = BigInteger.Parse(decode(masterfile[24])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult5 = BigInteger.Parse(decode(masterfile[25])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult6 = BigInteger.Parse(decode(masterfile[26])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult7 = BigInteger.Parse(decode(masterfile[27])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult8 = BigInteger.Parse(decode(masterfile[28])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult9 = BigInteger.Parse(decode(masterfile[29])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult10 = BigInteger.Parse(decode(masterfile[30])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { timespent = BigInteger.Parse(decode(masterfile[31])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { workers = BigInteger.Parse(decode(masterfile[32])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { inventions = BigInteger.Parse(decode(masterfile[33])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { minicompanies = BigInteger.Parse(decode(masterfile[34])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { companynetworth = BigInteger.Parse(decode(masterfile[35])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { invested = BigInteger.Parse(decode(masterfile[36])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autocollectboosts = bool.Parse(decode(masterfile[37])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { automaticupgrade = bool.Parse(decode(masterfile[38])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { magicpower = BigInteger.Parse(decode(masterfile[39])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { recalculatevars(); } catch (Exception) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at recalculating varirables"); }
            }
            else
            {
                endecode = endest;
            }
        }
    }
}
