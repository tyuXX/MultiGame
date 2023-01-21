using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace MultiGame
{
    public static class rntm
    {
        public static Main mainform;
        public static Random rng = new();
        public static Thread timerthread = new(timerth);
        public static List<string> log = new();
        public static List<string> passcodes = new() { "$sct", "cheat4life", "24/7 debugging" };
        public static string path = "";
        public static string endecode = "1234";
        public static string username = "Player";
        public static string lastfile = "";
        public static bool[ ] advance = { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
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
        public static bool debugvarsshown = false;
        public static bool shopthshown = false;
        public static bool varsshown = false;
        public static bool shop4shown = false;
        public static bool rankstartershown = false;
        public static bool shop5shown = false;
        public static bool devmode = false;
        public static bool cheat = false;
        public static bool companywork = false;
        public static bool alwaysontop = false;
        public static bool autocollectboosts = false;
        public static bool automaticupgrade = false;
        public static bool automaticrank = false;
        public static bool automaticrebirth = false;
        public static bool tooltips = false;
        public static bool formatnums = false;
        public static bool dialout = false;
        public static bool dialset = false;
        public static bool autosave = false;
        public static bool clearlog = true;
        public static int logupdateinterval = 10000;
        public static int autoclickerinterval = 1000;
        public static int autoupgradeinterval = 3000;
        public static int moneybagc = 298;
        public static int genboostc = 598;
        public static BigInteger autoclickerintervaln = 5000 * exponent(7, 1001 - autoclickerinterval);
        public static BigInteger autoupgradeintervaln = 6000 * exponent(13, 3001 - autoupgradeinterval);
        public static BigInteger moneybagcn = 10000 * exponent(15, 300 - moneybagc);
        public static BigInteger genboostcn = 10000 * exponent(25, 600 - genboostc);
        public static BigInteger timespent = 0;
        public static BigInteger money = 0;
        public static BigInteger generation = 1;
        public static BigInteger outcome = 0;
        public static Upgrade autogenmultu = new("AutoGenerationMultiplier", true, 0, 0, 5, 1000, true);
        public static BigInteger level = 0;
        public static BigInteger xp = 0;
        public static BigInteger xpn = xpnt;
        public static Upgrade add1u = new("Add1", true, 0, 0, 2, 250);
        public static Upgrade add2u = new("Add2", true, 0, 0, 2, 250);
        public static Upgrade add3u = new("Add3", true, 0, 0, 2, 250);
        public static Upgrade add4u = new("Add4", true, 0, 0, 2, 250);
        public static Upgrade add5u = new("Add5", true, 0, 0, 2, 250);
        public static Upgrade add6u = new("Add6", true, 0, 0, 2, 250);
        public static Upgrade add7u = new("Add7", true, 0, 0, 2, 250);
        public static Upgrade add8u = new("Add8", true, 0, 0, 2, 250);
        public static Upgrade add9u = new("Add9", true, 0, 0, 2, 250);
        public static Upgrade add10u = new("Add10", true, 0, 0, 2, 250);
        public static Upgrade mult1u = new("Mult1", true, 1, 1, 3, 500, true);
        public static Upgrade mult2u = new("Mult2", true, 1, 1, 3, 500, true);
        public static Upgrade mult3u = new("Mult3", true, 1, 1, 3, 500, true);
        public static Upgrade mult4u = new("Mult4", true, 1, 1, 3, 500, true);
        public static Upgrade mult5u = new("Mult5", true, 1, 1, 3, 500, true);
        public static Upgrade mult6u = new("Mult6", true, 1, 1, 3, 500, true);
        public static Upgrade mult7u = new("Mult7", true, 1, 1, 3, 500, true);
        public static Upgrade mult8u = new("Mult8", true, 1, 1, 3, 500, true);
        public static Upgrade mult9u = new("Mult9", true, 1, 1, 3, 500, true);
        public static Upgrade mult10u = new("Mult10", true, 1, 1, 3, 500, true);
        public static Upgrade levelupmultu = new("LevelUpMultiplier", true, 1, 1, 1000, exponent(10, 1000), false, true, true);
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
        public static BigInteger rank = 1;
        public static BigInteger rankmult = 1;
        public static BigInteger rebirth = 1;
        public static BigInteger rebirthmult = 1;
        public static World currentworld;
        public static readonly int mid = rng.Next(int.MinValue, int.MaxValue);
        public static readonly int tid = rng.Next(int.MinValue, int.MaxValue);
        public const bool Autoupdateshops = true;
        public const short xpt = 3;
        public const short xpnt = 1;
        public const int lbm = 100;
        public const short rut = 10;
        public const string Updatev = "Betav0.5.3";
        public static void VSplash()
        {
            Resource.Splash splash = new Resource.Splash();
            splash.Show();
        }
        public static string FormatLogStr(object sender, string[ ] param, string mstr)
        {
            StringBuilder merger = new();
            foreach (string str in param)
            {
                merger.Append($"{str},");
            }
            return $"[{DateTime.Now}][{sender}]({merger}){mstr}";
        }
        public static void download(string link, string name)
        {
            using WebClient client = new WebClient();
            client.DownloadFile(link, name);
        }
        public static void updateapp()
        {
            download("https://github.com/tyuXX/MultiGame/raw/master/MultiGameUpdate/bin/Release/MultiGameUpdate.exe", "MultiGameUpdate.exe");
            File.WriteAllText(@".\upf.m", path);
            Process.Start(@".\MultiGameUpdate.exe");
            Environment.Exit(0);
        }
        public static void recalculatevars()
        {
            investedn = 250 * (exponent(2, invested) + 1);
            minicompaniesn = 500 * (exponent(9, minicompanies) + 1);
            inventionsn = 100 * (exponent(3, inventions) + 1);
            workersn = 250 * (exponent(2, workers) + 1);
            add1u.ReCalc();
            add2u.ReCalc();
            add3u.ReCalc();
            add4u.ReCalc();
            add5u.ReCalc();
            add6u.ReCalc();
            add7u.ReCalc();
            add8u.ReCalc();
            add9u.ReCalc();
            add10u.ReCalc();
            mult1u.ReCalc();
            mult2u.ReCalc();
            mult3u.ReCalc();
            mult4u.ReCalc();
            mult5u.ReCalc();
            mult6u.ReCalc();
            mult7u.ReCalc();
            mult8u.ReCalc();
            mult9u.ReCalc();
            mult10u.ReCalc();
            autogenmultu.ReCalc();
            autoclickerintervaln = 5000 * exponent(7, 1001 - autoclickerinterval);
            autoupgradeintervaln = 6000 * exponent(13, 3001 - autoupgradeinterval);
            moneybagcn = 10000 * exponent(15, 300 - moneybagc);
            genboostcn = 10000 * exponent(25, 600 - genboostc);
        }
        public static BigInteger getmoney()
        {
            BigInteger rt = (currentworld.mult * level * rebirthmult * (rankmult) * generation * ((add1u.value + add2u.value + add3u.value + add4u.value + add5u.value + add6u.value + add7u.value + add8u.value + add9u.value + add10u.value + 1) * (((mult1u.value * mult2u.value * mult3u.value * mult4u.value * mult5u.value * mult6u.value * mult7u.value * mult8u.value * mult9u.value * mult10u.value) + 1) * boost1 * boost2 * boost3 * boost4 * boost5 * boost6 * boost7 * boost8 * boost9 * boost10))) - (outcome / minicompanies);
            if (rt < 1)
            {
                return 1;
            }
            else
            {
                return rt;
            }
        }
        public static void RebirtUp()
        {
            if (rank >= (rebirth + 1))
            {
                rebirth++;
                rebirthmult = exponent(rebirth, rebirth);
                rank = 1;
                xp = 0;
                level = 0;
                money = 0;
                xpn = xpnt;
                add1u.RRestore(true);
                add2u.RRestore(true);
                add3u.RRestore(true);
                add4u.RRestore(true);
                add5u.RRestore(true);
                add6u.RRestore(true);
                add7u.RRestore(true);
                add8u.RRestore(true);
                add9u.RRestore(true);
                add10u.RRestore(true);
                mult1u.RRestore(true);
                mult2u.RRestore(true);
                mult3u.RRestore(true);
                mult4u.RRestore(true);
                mult5u.RRestore(true);
                mult6u.RRestore(true);
                mult7u.RRestore(true);
                mult8u.RRestore(true);
                mult9u.RRestore(true);
                mult10u.RRestore(true);
                autogenmultu.RRestore(true);
            }
        }
        public static void RankUp()
        {
            if (level >= exponent(rank, 2) * rut)
            {
                rank++;
                rankmult = rank * rank;
                xp = 0;
                level = 0;
                money = 0;
                xpn = xpnt;
                add1u.RRestore(false);
                add2u.RRestore(false);
                add3u.RRestore(false);
                add4u.RRestore(false);
                add5u.RRestore(false);
                add6u.RRestore(false);
                add7u.RRestore(false);
                add8u.RRestore(false);
                add9u.RRestore(false);
                add10u.RRestore(false);
                mult1u.RRestore(false);
                mult2u.RRestore(false);
                mult3u.RRestore(false);
                mult4u.RRestore(false);
                mult5u.RRestore(false);
                mult6u.RRestore(false);
                mult7u.RRestore(false);
                mult8u.RRestore(false);
                mult9u.RRestore(false);
                mult10u.RRestore(false);
                autogenmultu.RRestore(false);
                recalculatevars();
            }
        }
        public static string FormatBigNum(BigInteger num)
        {
            if (num.ToString().Length > 5)
            {
                return $"{num.ToString()[ 0 ]}e+{num.ToString().Length - 1}";
            }
            else
            {
                return num.ToString();
            }
        }
        public static BigInteger exponent(BigInteger n, BigInteger e)
        {
            BigInteger nn = n;
            for (BigInteger i = 0; i < (e - 1); i++)
            {
                nn *= n;
            }
            return nn;
        }
        public static string encode(string toen)
        {
            byte[ ] data = UnicodeEncoding.Unicode.GetBytes(toen);
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[ ] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(endecode));
            using TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform transform = tripdes.CreateEncryptor();
            byte[ ] results = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(results, 0, results.Length);
        }
        public static string decode(string tode)
        {
            byte[ ] data = Convert.FromBase64String(tode);
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[ ] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(endecode));
            using TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform transform = tripdes.CreateDecryptor();
            byte[ ] results = transform.TransformFinalBlock(data, 0, data.Length);
            return UnicodeEncoding.Unicode.GetString(results);
        }
        public static void timerth()
        {
            while (true)
            {
                Thread.Sleep(999);
                timespent++;
            }
        }
        public static void levelth()
        {
            while (true)
            {
                if (xp >= xpn)
                {
                    level++;
                    xp -= xpn;
                    xpn *= xpt;
                }
            }
        }
        public static void upadd1()
        {
            add1u.Up(ref money);
        }
        public static void upadd2()
        {
            add2u.Up(ref money);
        }
        public static void upadd3()
        {
            add3u.Up(ref money);
        }
        public static void upadd4()
        {
            add4u.Up(ref money);
        }
        public static void upadd5()
        {
            add5u.Up(ref money);
        }
        public static void upadd6()
        {
            add6u.Up(ref money);
        }
        public static void upadd7()
        {
            add7u.Up(ref money);
        }
        public static void upadd8()
        {
            add8u.Up(ref money);
        }
        public static void upadd9()
        {
            add9u.Up(ref money);
        }
        public static void upadd10()
        {
            add10u.Up(ref money);
        }
        public static void upmult1()
        {
            mult1u.Up(ref money);
        }
        public static void upmult2()
        {
            mult2u.Up(ref money);
        }
        public static void upmult3()
        {
            mult3u.Up(ref money);
        }
        public static void upmult4()
        {
            mult4u.Up(ref money);
        }
        public static void upmult5()
        {
            mult5u.Up(ref money);
        }
        public static void upmult6()
        {
            mult6u.Up(ref money);
        }
        public static void upmult7()
        {
            mult7u.Up(ref money);
        }
        public static void upmult8()
        {
            mult8u.Up(ref money);
        }
        public static void upmult9()
        {
            mult9u.Up(ref money);
        }
        public static void upmult10()
        {
            mult10u.Up(ref money);
        }
        public static void upautogenmult()
        {
            autogenmultu.Up(ref money);
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
        public static void upautoupgradespeed()
        {
            if (autoupgradeinterval > 2)
            {
                if (money >= autoupgradeintervaln)
                {
                    log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop3/Game]{(Log)}Purchased autoupgrader speed now:" + autoupgradeinterval);
                    money -= autoupgradeintervaln;
                    autoupgradeintervaln *= 13;
                    autoupgradeinterval--;
                }
            }
        }
        public static void upmoneybagc()
        {
            if (moneybagc > 2)
            {
                if (money >= moneybagcn)
                {
                    money -= moneybagcn;
                    moneybagcn *= 15;
                    moneybagc--;
                }
            }
        }
        public static void upgenboostc()
        {
            if (genboostc > 2)
            {
                if (money >= genboostcn)
                {
                    money -= genboostcn;
                    genboostcn *= 25;
                    genboostc--;
                }
            }
        }
        public static void uplevelupmult()
        {
            levelupmultu.Up(ref money);
        }
        public static void savegame(string filepath, Form form = null)
        {
            if (!string.IsNullOrEmpty(filepath))
            {
                string[ ] masterfile =
                {
                    encode(endecode),
                    encode(username),
                    encode(logupdateinterval.ToString()),
                    encode(autoclickerinterval.ToString()),
                    encode(autoupgradeinterval.ToString()),
                    encode(money.ToString()),
                    encode(generation.ToString()),
                    encode(outcome.ToString()),
                    encode(autogenmultu.value.ToString()),
                    encode(level.ToString()),
                    encode(xp.ToString()),
                    encode(xpn.ToString()),
                    encode(add1u.value.ToString()),
                    encode(add2u.value.ToString()),
                    encode(add3u.value.ToString()),
                    encode(add4u.value.ToString()),
                    encode(add5u.value.ToString()),
                    encode(add6u.value.ToString()),
                    encode(add7u.value.ToString()),
                    encode(add8u.value.ToString()),
                    encode(add9u.value.ToString()),
                    encode(add10u.value.ToString()),
                    encode(mult1u.value.ToString()),
                    encode(mult2u.value.ToString()),
                    encode(mult3u.value.ToString()),
                    encode(mult4u.value.ToString()),
                    encode(mult5u.value.ToString()),
                    encode(mult6u.value.ToString()),
                    encode(mult7u.value.ToString()),
                    encode(mult8u.value.ToString()),
                    encode(mult9u.value.ToString()),
                    encode(mult10u.value.ToString()),
                    encode(timespent.ToString()),
                    encode(workers.ToString()),
                    encode(inventions.ToString()),
                    encode(minicompanies.ToString()),
                    encode(companynetworth.ToString()),
                    encode(invested.ToString()),
                    encode(autocollectboosts.ToString()),
                    encode(automaticupgrade.ToString()),
                    encode(magicpower.ToString()),
                    encode(currentworld.mult.ToString()),
                    encode(currentworld.name.ToString()),
                    encode(currentworld.population.ToString()),
                    encode(currentworld.populationgrowth.ToString()),
                    encode(currentworld.populationgrowthpercent.ToString()),
                    encode(moneybagc.ToString()),
                    encode(genboostc.ToString()),
                    encode(rank.ToString()),
                    encode(rebirth.ToString()),
                    encode(levelupmultu.value.ToString())
                };
                File.WriteAllLines(filepath, masterfile);
                lastfile = filepath;
                form?.Close();
            }
        }
        public static void opengame(string filepath, string passcodes, Form form = null)
        {
            string[ ] masterfile = File.ReadAllLines(filepath);
            string endest = endecode;
            endecode = passcodes;
            if (decode(masterfile[ 0 ]) == passcodes)
            {
                endecode = passcodes;
                try { username = decode(masterfile[ (int)saveorder.username ]); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { logupdateinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.logupdateinterval ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autoclickerinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.autoclickerinterval ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autoupgradeinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.autoupgradeinterval ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { money = BigInteger.Parse(decode(masterfile[ (int)saveorder.money ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { generation = BigInteger.Parse(decode(masterfile[ (int)saveorder.generation ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { outcome = BigInteger.Parse(decode(masterfile[ (int)saveorder.outcome ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autogenmultu.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.autogenmult ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { level = BigInteger.Parse(decode(masterfile[ (int)saveorder.level ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xp = BigInteger.Parse(decode(masterfile[ (int)saveorder.xp ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xpn = BigInteger.Parse(decode(masterfile[ (int)saveorder.xpn ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add1u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add1 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add2u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add2 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add3u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add3 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add4u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add4 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add5u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add5 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add6u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add6 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add7u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add7 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add8u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add8 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add9u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add9 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add10u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add10 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult1u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult1 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult2u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult2 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult3u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult3 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult4u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult4 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult5u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult5 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult6u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult6 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult7u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult7 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult8u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult8 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult9u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult9 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult10u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult10 ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { timespent = BigInteger.Parse(decode(masterfile[ (int)saveorder.timespent ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { workers = BigInteger.Parse(decode(masterfile[ (int)saveorder.workers ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { inventions = BigInteger.Parse(decode(masterfile[ (int)saveorder.inventions ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { minicompanies = BigInteger.Parse(decode(masterfile[ (int)saveorder.minicompanies ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { companynetworth = BigInteger.Parse(decode(masterfile[ (int)saveorder.companynetworth ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { invested = BigInteger.Parse(decode(masterfile[ (int)saveorder.invested ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autocollectboosts = bool.Parse(decode(masterfile[ (int)saveorder.autocollectboosts ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { automaticupgrade = bool.Parse(decode(masterfile[ (int)saveorder.automaticupgrade ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { magicpower = BigInteger.Parse(decode(masterfile[ (int)saveorder.magicpower ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { currentworld.mult = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldmult ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { currentworld.name = decode(masterfile[ (int)saveorder.currentworldname ]); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { currentworld.population = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulation ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { currentworld.populationgrowth = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulationgrowth ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { currentworld.populationgrowthpercent = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulationgrowthpercent ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { moneybagc = Convert.ToInt32(decode(masterfile[ (int)saveorder.moneybagchance ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { genboostc = Convert.ToInt32(decode(masterfile[ (int)saveorder.genboostchance ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.rank ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { rebirth = BigInteger.Parse(decode(masterfile[ (int)saveorder.rebirth ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { levelupmultu.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.levelupmult ])); } catch (Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { recalculatevars(); } catch (Exception) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at recalculating varirables"); }
                lastfile = filepath;
                form?.Close();
            }
            else
            {
                endecode = endest;
            }
        }
        public static void newworld()
        {
            currentworld.name = "World";
            if (level * 100 > int.MaxValue)
            {
                currentworld.populationgrowthpercent = rng.Next(0, int.MaxValue);
                currentworld.populationgrowth = rng.Next(0, int.MaxValue);
                currentworld.population = rng.Next(0, int.MaxValue) * rng.Next(0, int.MaxValue);

            }
            else
            {
                int icst = int.Parse(level.ToString());
                currentworld.populationgrowthpercent = rng.Next(0, 100 * icst);
                currentworld.populationgrowth = rng.Next(0, int.MaxValue);
                currentworld.population = rng.Next(0, int.MaxValue) * rng.Next(0, int.MaxValue);
            }
            if (level > int.MaxValue)
            {
                currentworld.mult = rng.Next(0, int.MaxValue);
            }
            else
            {
                int icst = int.Parse(level.ToString());
                currentworld.mult = rng.Next(0, icst);
            }
        }
    }
    public struct World
    {
        public string name;
        public BigInteger population;
        public BigInteger populationgrowth;
        public BigInteger populationgrowthpercent;
        public BigInteger mult;
        public World(string namep, BigInteger pop, BigInteger popg, BigInteger popgp, BigInteger mul) : this()
        {
            name = namep;
            population = pop;
            populationgrowth = popg;
            populationgrowthpercent = popgp;
            mult = mul;
        }
    }
    public struct TaskBar
    {
        public Func<object> func;
        public BigInteger value;
        public BigInteger maxvalue;
        public TaskBar(Func<object> funcp, BigInteger valuep, BigInteger maxvaluep) : this()
        {
            func = funcp;
            value = valuep;
            maxvalue = maxvaluep;
        }
    }
    public struct Boost
    {
        public string name;
        public BigInteger value;
        public BigInteger time;
        public Boost(string namep, BigInteger valuep, BigInteger timep) : this()
        {
            name = namep;
            value = valuep;
            time = timep;
        }
    }
    public struct Upgrade
    {
        public string name;
        public bool isbought;
        public BigInteger value;
        public BigInteger dvalue;
        public BigInteger mult;
        public BigInteger cache;
        public BigInteger scache;
        public BigInteger dcache;
        public bool dopo;
        public bool isrankpersistent;
        public bool isrebirtpersistent;
        public Upgrade Parse(string str)
        {
            string[ ] array = str.Split('|');
            return new(array[ 0 ], bool.Parse(array[ 1 ]), BigInteger.Parse(array[ 2 ]), BigInteger.Parse(array[ 3 ]), BigInteger.Parse(array[ 4 ]), BigInteger.Parse(array[ 5 ]), bool.Parse(array[ 6 ]), bool.Parse(array[ 7 ]), bool.Parse(array[ 8 ]));
        }
        public override string ToString()
        {
            return $"{name.Replace("|", "")}|{isbought}|{value}|{dvalue}|{mult}|{scache}|{dopo}|{isrankpersistent}|{isrebirtpersistent}";
        }
        public void Up(ref BigInteger moneyp, bool recache = false)
        {
            if (recache) { ReCalc(); }
            if (moneyp >= cache)
            {
                moneyp -= cache;
                value++;
                cache *= mult;
            }
        }
        public BigInteger GetN()
        {
            if (dopo)
            {
                cache = scache * (exponent(mult, value) + 1);
            }
            else
            {
                cache = scache * exponent(mult, value);
            }
            return cache;
        }
        public void ReCalc()
        {
            if (dopo)
            {
                cache = scache * (exponent(mult, value) + 1);
            }
            else
            {
                cache = scache * exponent(mult, value);
            }
        }
        public void Restore(bool force = false)
        {
            value = dvalue;
            if (force)
            {
                cache = dcache;
            }
        }
        public void RRestore(bool rorr = false)
        {
            if (rorr)
            {
                if (!isrebirtpersistent)
                {
                    value = dvalue;
                }
            }
            else
            {
                if (!isrankpersistent)
                {
                    value = dvalue;
                }
            }
        }
        public Upgrade(string namep, bool isboughtp, BigInteger valuep, BigInteger dvaluep, BigInteger multp, BigInteger scachep, bool dopop = false, bool isrankpersistentp = false, bool isrebirtpersistentp = false) : this()
        {
            name = namep;
            isbought = isboughtp;
            value = valuep;
            dvalue = dvaluep;
            mult = multp;
            scache = scachep;
            isrankpersistent = isrankpersistentp;
            isrebirtpersistent = isrebirtpersistentp;
            dopo = dopop;
            if (dopo)
            {
                cache = scache * (exponent(mult, value) + 1);
            }
            else
            {
                cache = scache * exponent(mult, value);
            }
            dcache = cache;
        }
    }
    public enum saveorder
    {
        empty,
        username,
        logupdateinterval,
        autoclickerinterval,
        autoupgradeinterval,
        money,
        generation,
        outcome,
        autogenmult,
        level,
        xp,
        xpn,
        add1,
        add2,
        add3,
        add4,
        add5,
        add6,
        add7,
        add8,
        add9,
        add10,
        mult1,
        mult2,
        mult3,
        mult4,
        mult5,
        mult6,
        mult7,
        mult8,
        mult9,
        mult10,
        timespent,
        workers,
        inventions,
        minicompanies,
        companynetworth,
        invested,
        autocollectboosts,
        automaticupgrade,
        magicpower,
        currentworldmult,
        currentworldname,
        currentworldpopulation,
        currentworldpopulationgrowth,
        currentworldpopulationgrowthpercent,
        moneybagchance,
        genboostchance,
        rank,
        rebirth,
        levelupmult
    }
}
