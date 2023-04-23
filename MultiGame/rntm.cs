using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace MultiGame;

internal static class rntm
{
    internal static Main mainform;
    internal static Random rng = new();
    internal static Thread timerthread = new(timerth);
    internal static List<string> passcodes = new() { "$sct", "cheat4life", "24/7 debugging" };
    internal static List<Tools.Message> popups = new() { };
    internal static string path = "";
    internal static string endecode = "1234";
    internal static string username = "Player";
    internal static string lastfile = "";
    internal static string resourcefolder = @".\rsc";
    internal static bool[ ] advance = { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
    internal static bool clshown = false;
    internal static bool fnfshown = false;
    internal static bool logshown = false;
    internal static bool addlogshown = false;
    internal static bool toggledevmodeshown = false;
    internal static bool shopshown = false;
    internal static bool changeusernameshown = false;
    internal static bool changepasscodeshown = false;
    internal static bool savegameshown = false;
    internal static bool opengameshown = false;
    internal static bool gamesincshown = false;
    internal static bool shop2shown = false;
    internal static bool aboutshown = false;
    internal static bool magicshown = false;
    internal static bool magicpowergeneratorshown = false;
    internal static bool debugvarsshown = false;
    internal static bool shopthshown = false;
    internal static bool varsshown = false;
    internal static bool shop4shown = false;
    internal static bool rankstartershown = false;
    internal static bool shop5shown = false;
    internal static bool devmode = false;
    internal static bool cheat = false;
    internal static bool companywork = false;
    internal static bool alwaysontop = false;
    internal static bool autocollectboosts = false;
    internal static bool automaticupgrade = false;
    internal static bool automaticrank = false;
    internal static bool automaticrebirth = false;
    internal static bool tooltips = false;
    internal static bool formatnums = false;
    internal static bool dialout = false;
    internal static bool dialset = false;
    internal static bool autosave = false;
    internal static bool maxbuy = false;
    internal static bool formatranks = false;
    internal static bool statusopen = false;
    internal static bool pausetickers = false;
    internal static bool advanceshown = false;
    internal static bool messagesend = true;
    internal static bool settingswindowshown = false;
    internal static bool updatewindowshown = false;
    internal static int logupdateinterval = 10000;
    internal static int autoclickerinterval = 1000;
    internal static int autoupgradeinterval = 3000;
    internal static int moneybagc = 298;
    internal static int genboostc = 598;
    internal static BigInteger totalclicks = 0;
    internal static BigInteger totalclicksdirect = 0;
    internal static BigInteger autoclickerintervaln = 5000 * exponent(7, 1001 - autoclickerinterval);
    internal static BigInteger autoupgradeintervaln = 6000 * exponent(13, 3001 - autoupgradeinterval);
    internal static BigInteger moneybagcn = 10000 * exponent(15, 300 - moneybagc);
    internal static BigInteger genboostcn = 10000 * exponent(25, 600 - genboostc);
    internal static BigInteger timespent = 0;
    internal static BigInteger money = 0;
    internal static BigInteger generation = 1;
    internal static BigInteger outcome = 0;
    internal static Upgrade autogenmultu = new("AutoGenerationMultiplier", true, 0, 0, 5, 1000, true);
    internal static BigInteger level = 0;
    internal static BigInteger xp = 0;
    internal static BigInteger xpn = Xpnt;
    internal static Upgrade add1u = new("Add1", true, 0, 0, 2, 250);
    internal static Upgrade add2u = new("Add2", true, 0, 0, 2, 250);
    internal static Upgrade add3u = new("Add3", true, 0, 0, 2, 250);
    internal static Upgrade add4u = new("Add4", true, 0, 0, 2, 250);
    internal static Upgrade add5u = new("Add5", true, 0, 0, 2, 250);
    internal static Upgrade add6u = new("Add6", true, 0, 0, 2, 250);
    internal static Upgrade add7u = new("Add7", true, 0, 0, 2, 250);
    internal static Upgrade add8u = new("Add8", true, 0, 0, 2, 250);
    internal static Upgrade add9u = new("Add9", true, 0, 0, 2, 250);
    internal static Upgrade add10u = new("Add10", true, 0, 0, 2, 250);
    internal static Upgrade mult1u = new("Mult1", true, 1, 1, 3, 500, true);
    internal static Upgrade mult2u = new("Mult2", true, 1, 1, 3, 500, true);
    internal static Upgrade mult3u = new("Mult3", true, 1, 1, 3, 500, true);
    internal static Upgrade mult4u = new("Mult4", true, 1, 1, 3, 500, true);
    internal static Upgrade mult5u = new("Mult5", true, 1, 1, 3, 500, true);
    internal static Upgrade mult6u = new("Mult6", true, 1, 1, 3, 500, true);
    internal static Upgrade mult7u = new("Mult7", true, 1, 1, 3, 500, true);
    internal static Upgrade mult8u = new("Mult8", true, 1, 1, 3, 500, true);
    internal static Upgrade mult9u = new("Mult9", true, 1, 1, 3, 500, true);
    internal static Upgrade mult10u = new("Mult10", true, 1, 1, 3, 500, true);
    internal static Upgrade levelupmultu = new("LevelUpMultiplier", true, 1, 1, 1000, exponent(10, 1000), false, true, true);
    internal static BigInteger workers = 0;
    internal static BigInteger workersn = 250 * (exponent(2, workers) + 1);
    internal static BigInteger inventions = 0;
    internal static BigInteger inventionsn = 100 * (exponent(3, inventions) + 1);
    internal static BigInteger minicompanies = 1;
    internal static BigInteger minicompaniesn = 500 * (exponent(9, minicompanies) + 1);
    internal static BigInteger companynetworth = 0;
    internal static BigInteger invested = 1;
    internal static BigInteger investedn = 250 * (exponent(2, invested) + 1);
    internal static BigInteger boost1 = 1;
    internal static BigInteger boost1t = 0;
    internal static BigInteger boost2 = 1;
    internal static BigInteger boost2t = 0;
    internal static BigInteger boost3 = 1;
    internal static BigInteger boost3t = 0;
    internal static BigInteger boost4 = 1;
    internal static BigInteger boost4t = 0;
    internal static BigInteger boost5 = 1;
    internal static BigInteger boost5t = 0;
    internal static BigInteger boost6 = 1;
    internal static BigInteger boost6t = 0;
    internal static BigInteger boost7 = 1;
    internal static BigInteger boost7t = 0;
    internal static BigInteger boost8 = 1;
    internal static BigInteger boost8t = 0;
    internal static BigInteger boost9 = 1;
    internal static BigInteger boost9t = 0;
    internal static BigInteger boost10 = 1;
    internal static BigInteger boost10t = 0;
    internal static BigInteger magicpower = 0;
    internal static BigInteger rank = 1;
    internal static BigInteger rankmult = 1;
    internal static BigInteger rebirth = 1;
    internal static BigInteger rebirthmult = 1;
    internal static World currentworld;
    internal static readonly string mid = GenRandomStr(10);
    internal static readonly string tid = GenRandomStr(10);
    internal static void VSplash()
    {
        Resource.Splash splash = new Resource.Splash();
        splash.Show();
    }
    internal static void ToggleTickers() => mainform.Toggletickers();
    internal static string FormatLogStr(object sender, string[ ] param, string mstr)
    {
        StringBuilder merger = new();
        foreach (string str in param)
        {
            merger.Append($"{str},");
        }
        return $"[{DateTime.Now}][{sender}]({merger}){mstr}";
    }
    internal static string BoolArrayToString(bool[ ] array)
    {
        StringBuilder sb = new();
        foreach (bool bol in array)
        {
            sb.Append(bol.ToString());
            sb.Append(',');
        }
        return sb.ToString();
    }
    internal static bool[ ] StringToBoolArray(string str, char split)
    {
        string[ ] array = str.Split(split);
        bool[ ] barray = new bool[ array.Length ];
        for (int i = 0; i < array.Length - 1; i++)
        {
            barray[ i ] = bool.Parse(array[ i ]);
        }
        return barray;
    }
    internal static void download(string link, string name)
    {
        using WebClient client = new WebClient();
        client.DownloadFile(link, name);
    }
    internal static string GenRandomStr(BigInteger length, bool withsybols = true)
    {
        StringBuilder sb = new StringBuilder();
        for (BigInteger i = 0; i < length; i++)
        {
            sb.Append(GenRandomChar(withsybols));
        }
        return sb.ToString();
    }
    internal static char GenRandomChar(bool withsybols = true)
    {
        const string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        const string symbols = @"1234567890*-!'^+%&/()=?_#${[]}\@€.:~,;`<>|¨";
        const string charmap = letters + symbols;
        if (withsybols)
        {
            return charmap[ rng.Next(0, charmap.Length) ];
        }
        else
        {
            return letters[ rng.Next(0, letters.Length) ];
        }
    }
    internal static string RankCalc(BigInteger rank)
    {
        const byte sl = 3;
        const byte mindef = 3;
        const byte plusl = 3;
        const byte rnkl = 10;
        const byte ul = 10;
        StringBuilder sb = new StringBuilder();
        BigInteger rk = rank;
        byte minus = mindef;
        byte plus = 0;
        byte rnk = 0;
        BigInteger us = 0;
        BigInteger ps = 0;
        while (rk > 0)
        {
            if (minus > 0)
            {
                minus--;
            }
            else
            {
                if (plus >= plusl)
                {
                    minus = mindef;
                    plus = 0;
                    rnk++;
                }
                else
                {
                    plus++;
                }
            }
            if (rnk > rnkl)
            {
                us++;
                rnk = 0;
            }
            if (us > ul)
            {
                ps++;
                us = 0;
            }
            rk--;
        }
        for (int i = 0; i < ps; i++)
        {
            sb.Append("P");
        }
        for (int i = 0; i < us; i++)
        {
            sb.Append("U");
        }
        if (rnk > 6)
        {
            for (int i = 0; (i < (rnk - 6)) && (i < sl); i++)
            {
                sb.Append("S");
            }
        }
        else
        {
            switch (rnk)
            {
                case 0:
                    {
                        sb.Append("G");
                        break;
                    }
                case 1:
                    {
                        sb.Append("F");
                        break;
                    }
                case 2:
                    {
                        sb.Append("E");
                        break;
                    }
                case 3:
                    {
                        sb.Append("D");
                        break;
                    }
                case 4:
                    {
                        sb.Append("C");
                        break;
                    }
                case 5:
                    {
                        sb.Append("B");
                        break;
                    }
                case 6:
                    {
                        sb.Append("A");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        for (int i = 0; i < minus; i++)
        {
            sb.Append("-");
        }
        for (int i = 0; i < plus; i++)
        {
            sb.Append("+");
        }
        return sb.ToString();
    }
    internal static void XpUp()
    {
        level++;
        xp -= xpn;
        xpn *= Xpt;
        NewMessageWindow("Level Up!", "You are now LvL:" + level, 1);
    }
    internal static void updateapp()
    {
        download("https://github.com/tyuXX/MultiGame/raw/master/MultiGameUpdate/bin/Release/MultiGameUpdate.exe", "MultiGameUpdate.exe");
        File.WriteAllText(@".\upf.m", path);
        Process.Start(@".\MultiGameUpdate.exe");
        Environment.Exit(0);
    }
    internal static void recalculatevars()
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
    internal static BigInteger getmoney
    {
        get
        {
            BigInteger rt = (currentworld.mult * level * rebirthmult * rankmult * ((totalclicks / Tcb) + 1) * ((totalclicksdirect / Tcdb) + 1) * generation * ((add1u.rankvalue + add2u.rankvalue + add3u.rankvalue + add4u.rankvalue + add5u.rankvalue + add6u.rankvalue + add7u.rankvalue + add8u.rankvalue + add9u.rankvalue + add10u.rankvalue + 1) * (((mult1u.rankvalue * mult2u.rankvalue * mult3u.rankvalue * mult4u.rankvalue * mult5u.rankvalue * mult6u.rankvalue * mult7u.rankvalue * mult8u.rankvalue * mult9u.rankvalue * mult10u.rankvalue) + 1) * boost1 * boost2 * boost3 * boost4 * boost5 * boost6 * boost7 * boost8 * boost9 * boost10))) - (outcome / minicompanies);
            if (rt < 1)
            {
                return 1;
            }
            else
            {
                return rt;
            }
        }
    }
    internal static void NewMessageWindow(string l1, string l2, short lf)
    {
        if (popups.Count >= 10)
        {
            foreach (Tools.Message msg in popups)
            {
                msg.Close();
            }
        }
        if (messagesend)
        {
            Tools.Message msg = new()
            {
                MdiParent = mainform,
                life = lf
            };
            msg.label1.Text = l1;
            msg.label2.Text = l2;
            popups.Add(msg);
            msg.Show();
        }
    }

    internal static void RebirtUp(bool bypass = false)
    {
        if ((rank >= (rebirth + 1)) || bypass)
        {
            rebirth++;
            rebirthmult = exponent(rebirth, rebirth);
            rank = 1;
            xp = 0;
            level = 0;
            money = 0;
            xpn = Xpnt;
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
    internal static void RankUp(bool bypass = false)
    {
        if ((level >= exponent(rank, 2) * Rut) || bypass)
        {
            rank++;
            rankmult = rank * rank;
            xp = 0;
            level = 0;
            money = 0;
            xpn = Xpnt;
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
    internal static string FormatBigNum(BigInteger num)
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
    internal static BigInteger exponent(BigInteger n, BigInteger e)
    {
        BigInteger nn = BigInteger.One;
        for (BigInteger i = 0; i < e; i++)
        {
            nn *= n;
        }
        return nn;
    }
    internal static string encode(string toen)
    {
        byte[ ] data = Encoding.Unicode.GetBytes(toen);
        using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[ ] keys = md5.ComputeHash(Encoding.Unicode.GetBytes(endecode));
        using TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
        ICryptoTransform transform = tripdes.CreateEncryptor();
        byte[ ] results = transform.TransformFinalBlock(data, 0, data.Length);
        return Convert.ToBase64String(results, 0, results.Length);
    }
    internal static string decode(string tode)
    {
        byte[ ] data = Convert.FromBase64String(tode);
        using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[ ] keys = md5.ComputeHash(Encoding.Unicode.GetBytes(endecode));
        using TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
        ICryptoTransform transform = tripdes.CreateDecryptor();
        byte[ ] results = transform.TransformFinalBlock(data, 0, data.Length);
        return Encoding.Unicode.GetString(results);
    }
    internal static void timerth()
    {
        while (true)
        {
            Thread.Sleep(999);
            timespent++;
        }
    }
    internal static void levelth()
    {
        while (true)
        {
            if (xp >= xpn)
            {
                level++;
                xp -= xpn;
                xpn *= Xpt;
            }
        }
    }
    internal static void upadd1() => add1u.Up(ref money, maxbuy);
    internal static void upadd2() => add2u.Up(ref money, maxbuy);
    internal static void upadd3() => add3u.Up(ref money, maxbuy);
    internal static void upadd4() => add4u.Up(ref money, maxbuy);
    internal static void upadd5() => add5u.Up(ref money, maxbuy);
    internal static void upadd6() => add6u.Up(ref money, maxbuy);
    internal static void upadd7() => add7u.Up(ref money, maxbuy);
    internal static void upadd8() => add8u.Up(ref money, maxbuy);
    internal static void upadd9() => add9u.Up(ref money, maxbuy);
    internal static void upadd10() => add10u.Up(ref money, maxbuy);
    internal static void upmult1() => mult1u.Up(ref money, maxbuy);
    internal static void upmult2() => mult2u.Up(ref money, maxbuy);
    internal static void upmult3() => mult3u.Up(ref money, maxbuy);
    internal static void upmult4() => mult4u.Up(ref money, maxbuy);
    internal static void upmult5() => mult5u.Up(ref money, maxbuy);
    internal static void upmult6() => mult6u.Up(ref money, maxbuy);
    internal static void upmult7() => mult7u.Up(ref money, maxbuy);
    internal static void upmult8() => mult8u.Up(ref money, maxbuy);
    internal static void upmult9() => mult9u.Up(ref money, maxbuy);
    internal static void upmult10() => mult10u.Up(ref money, maxbuy);
    internal static void upautogenmult() => autogenmultu.Up(ref money, maxbuy);
    internal static void upautoclickerspeed()
    {
        if (maxbuy)
        {
            while ((money >= autoclickerintervaln) && (autoclickerinterval > 2))
            {
                money -= autoclickerintervaln;
                autoclickerintervaln *= 7;
                autoclickerinterval--;
            }
        }
        else
        {
            if ((money >= autoclickerintervaln) && (autoclickerinterval > 2))
            {
                money -= autoclickerintervaln;
                autoclickerintervaln *= 7;
                autoclickerinterval--;
            }
        }
    }
    internal static void upautoupgradespeed()
    {
        if (maxbuy)
        {
            while ((money >= autoupgradeintervaln) && (autoupgradeinterval > 2))
            {
                money -= autoupgradeintervaln;
                autoupgradeintervaln *= 13;
                autoupgradeinterval--;
            }
        }
        else
        {
            if ((money >= autoupgradeintervaln) && (autoupgradeinterval > 2))
            {
                money -= autoupgradeintervaln;
                autoupgradeintervaln *= 13;
                autoupgradeinterval--;
            }
        }
    }
    internal static void upmoneybagc()
    {
        if (maxbuy)
        {
            while ((money >= moneybagcn) && (moneybagc > 2))
            {
                money -= moneybagcn;
                moneybagcn *= 15;
                moneybagc--;
            }
        }
        else
        {
            if ((money >= moneybagcn) && (moneybagc > 2))
            {
                money -= moneybagcn;
                moneybagcn *= 15;
                moneybagc--;
            }
        }
    }
    internal static void upgenboostc()
    {
        if (maxbuy)
        {
            while ((money >= genboostcn) && (genboostc > 2))
            {
                money -= genboostcn;
                genboostcn *= 25;
                genboostc--;
            }
        }
        else
        {
            if ((money >= genboostcn) && (genboostc > 2))
            {
                money -= genboostcn;
                genboostcn *= 25;
                genboostc--;
            }
        }
    }
    internal static void uplevelupmult() => levelupmultu.Up(ref money, maxbuy);
    internal static void savegame(string filepath, Form form = null)
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
                encode(levelupmultu.value.ToString()),
                encode(totalclicks.ToString()),
                encode(totalclicksdirect.ToString()),
                encode(add1u.rank.ToString()),
                encode(add2u.rank.ToString()),
                encode(add3u.rank.ToString()),
                encode(add4u.rank.ToString()),
                encode(add5u.rank.ToString()),
                encode(add6u.rank.ToString()),
                encode(add7u.rank.ToString()),
                encode(add8u.rank.ToString()),
                encode(add9u.rank.ToString()),
                encode(add10u.rank.ToString()),
                encode(mult1u.rank.ToString()),
                encode(mult2u.rank.ToString()),
                encode(mult3u.rank.ToString()),
                encode(mult4u.rank.ToString()),
                encode(mult5u.rank.ToString()),
                encode(mult6u.rank.ToString()),
                encode(mult7u.rank.ToString()),
                encode(mult8u.rank.ToString()),
                encode(mult9u.rank.ToString()),
                encode(mult10u.rank.ToString()),
                encode(autogenmultu.rank.ToString()),
                encode(BoolArrayToString(advance))
            };
            File.WriteAllLines(filepath, masterfile);
            lastfile = filepath;
            form?.Close();
        }
    }
    internal static void opengame(string filepath, string passcodes, Form form = null)
    {
        string[ ] masterfile = File.ReadAllLines(filepath);
        string endest = endecode;
        endecode = passcodes;
        if (decode(masterfile[ 0 ]) == passcodes)
        {
            endecode = passcodes;
            try { username = decode(masterfile[ (int)saveorder.username ]); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { logupdateinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.logupdateinterval ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { autoclickerinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.autoclickerinterval ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { autoupgradeinterval = Convert.ToInt32(decode(masterfile[ (int)saveorder.autoupgradeinterval ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { money = BigInteger.Parse(decode(masterfile[ (int)saveorder.money ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { generation = BigInteger.Parse(decode(masterfile[ (int)saveorder.generation ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { outcome = BigInteger.Parse(decode(masterfile[ (int)saveorder.outcome ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { autogenmultu.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.autogenmult ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { level = BigInteger.Parse(decode(masterfile[ (int)saveorder.level ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { xp = BigInteger.Parse(decode(masterfile[ (int)saveorder.xp ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { xpn = BigInteger.Parse(decode(masterfile[ (int)saveorder.xpn ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add1u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add1 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add2u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add2 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add3u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add3 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add4u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add4 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add5u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add5 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add6u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add6 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add7u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add7 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add8u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add8 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add9u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add9 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add10u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.add10 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult1u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult1 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult2u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult2 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult3u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult3 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult4u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult4 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult5u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult5 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult6u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult6 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult7u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult7 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult8u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult8 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult9u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult9 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult10u.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult10 ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { timespent = BigInteger.Parse(decode(masterfile[ (int)saveorder.timespent ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { workers = BigInteger.Parse(decode(masterfile[ (int)saveorder.workers ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { inventions = BigInteger.Parse(decode(masterfile[ (int)saveorder.inventions ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { minicompanies = BigInteger.Parse(decode(masterfile[ (int)saveorder.minicompanies ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { companynetworth = BigInteger.Parse(decode(masterfile[ (int)saveorder.companynetworth ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { invested = BigInteger.Parse(decode(masterfile[ (int)saveorder.invested ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { autocollectboosts = bool.Parse(decode(masterfile[ (int)saveorder.autocollectboosts ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { automaticupgrade = bool.Parse(decode(masterfile[ (int)saveorder.automaticupgrade ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { magicpower = BigInteger.Parse(decode(masterfile[ (int)saveorder.magicpower ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { currentworld.mult = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldmult ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { currentworld.name = decode(masterfile[ (int)saveorder.currentworldname ]); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { currentworld.population = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulation ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { currentworld.populationgrowth = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulationgrowth ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { currentworld.populationgrowthpercent = BigInteger.Parse(decode(masterfile[ (int)saveorder.currentworldpopulationgrowthpercent ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { moneybagc = Convert.ToInt32(decode(masterfile[ (int)saveorder.moneybagchance ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { genboostc = Convert.ToInt32(decode(masterfile[ (int)saveorder.genboostchance ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.rank ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { rebirth = BigInteger.Parse(decode(masterfile[ (int)saveorder.rebirth ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { levelupmultu.value = BigInteger.Parse(decode(masterfile[ (int)saveorder.levelupmult ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { totalclicks = BigInteger.Parse(decode(masterfile[ (int)saveorder.totalclicks ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { totalclicksdirect = BigInteger.Parse(decode(masterfile[ (int)saveorder.totalclicksdirect ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add1u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add1r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add2u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add2r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add3u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add3r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add4u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add4r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add5u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add5r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add6u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add6r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add7u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add7r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add8u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add8r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add9u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add9r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { add10u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.add10r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult1u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult1r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult2u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult2r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult3u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult3r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult4u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult4r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult5u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult5r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult6u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult6r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult7u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult7r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult8u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult8r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult9u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult9r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { mult10u.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.mult10r ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            try { autogenmultu.rank = BigInteger.Parse(decode(masterfile[ (int)saveorder.autogenmultr ])); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            //try { advance = StringToBoolArray(decode(masterfile[ (int)saveorder.advance ]),','); } catch (Exception ex) { NewMessageWindow("Error",ex.Message,25); }
            advance = StringToBoolArray(decode(masterfile[ (int)saveorder.advance ]), ',');
            try { recalculatevars(); } catch (Exception ex) { NewMessageWindow("Error", ex.Message, 25); }
            lastfile = filepath;
            form?.Close();
        }
        else
        {
            endecode = endest;
        }
    }
    internal static void newworld()
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
internal struct World
{
    internal string name;
    internal BigInteger population;
    internal BigInteger populationgrowth;
    internal BigInteger populationgrowthpercent;
    internal BigInteger mult;
    internal Guid ID = Guid.NewGuid();
    internal World(string namep, BigInteger pop, BigInteger popg, BigInteger popgp, BigInteger mul) : this()
    {
        name = namep;
        population = pop;
        populationgrowth = popg;
        populationgrowthpercent = popgp;
        mult = mul;
    }
}
internal struct TaskBar
{
    internal Func<object> func;
    internal BigInteger value;
    internal BigInteger maxvalue;
    internal Guid ID = Guid.NewGuid();
    internal TaskBar(Func<object> funcp, BigInteger valuep, BigInteger maxvaluep) : this()
    {
        func = funcp;
        value = valuep;
        maxvalue = maxvaluep;
    }
}
internal struct Boost
{
    internal string name;
    internal BigInteger value;
    internal BigInteger time;
    internal Guid ID = Guid.NewGuid();
    internal Boost(string namep, BigInteger valuep, BigInteger timep) : this()
    {
        name = namep;
        value = valuep;
        time = timep;
    }
}
internal struct Upgrade
{
    internal string name;
    internal bool isbought;
    internal BigInteger value;
    internal BigInteger rankvalue { get { return rank * value; } set => this.value = value; }
    internal BigInteger dvalue;
    internal BigInteger mult;
    internal BigInteger cache;
    internal BigInteger scache;
    internal BigInteger dcache;
    internal BigInteger rcache;
    internal BigInteger rscache;
    internal BigInteger rdcache;
    internal BigInteger rank = 1;
    internal bool dopo;
    internal bool isrankpersistent;
    internal bool isrebirtpersistent;
    internal BigInteger cap;
    internal Guid ID = Guid.NewGuid();
    internal Upgrade Parse(string str)
    {
        string[ ] array = str.Split('|');
        return new(array[ 0 ], bool.Parse(array[ 1 ]), BigInteger.Parse(array[ 2 ]), BigInteger.Parse(array[ 3 ]), BigInteger.Parse(array[ 4 ]), BigInteger.Parse(array[ 5 ]), bool.Parse(array[ 6 ]), bool.Parse(array[ 7 ]), bool.Parse(array[ 8 ]));
    }
    public override string ToString() => $"{name.Replace("|", "")}|{isbought}|{value}|{dvalue}|{mult}|{scache}|{dopo}|{isrankpersistent}|{isrebirtpersistent}|{rank}";
    internal void Up(ref BigInteger moneyp, bool maxbuy = false, bool recache = false)
    {
        if (recache) { ReCalc(); }
        if (maxbuy)
        {
            while (moneyp >= cache)
            {
                moneyp -= cache;
                value++;
                cache *= mult;
            }
        }
        else
        {
            if (moneyp >= cache)
            {
                moneyp -= cache;
                value++;
                cache *= mult;
            }
        }
    }
    internal void RUp(ref BigInteger moneyp, bool maxbuy = false, bool recache = false)
    {
        if (recache) { ReCalc(); }
        if (maxbuy)
        {
            while (moneyp >= rcache)
            {
                moneyp -= rcache;
                rank++;
                rcache *= mult * 5;
            }
        }
        else
        {
            if (moneyp >= rcache)
            {
                moneyp -= rcache;
                rank++;
                rcache *= mult * 5;
            }
        }
    }
    internal BigInteger GetN()
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
    internal void ReCalc()
    {
        if (dopo)
        {
            cache = scache * (exponent(mult * 5, value) + 1);
        }
        else
        {
            cache = scache * exponent(mult * 5, value);
        }
    }
    internal void RReCalc()
    {
        if (dopo)
        {
            rcache = rscache * (exponent(mult, rankvalue) + 1);
        }
        else
        {
            rcache = rscache * exponent(mult, rankvalue);
        }
    }
    internal void Restore(bool force = false)
    {
        value = dvalue;
        if (force)
        {
            cache = dcache;
        }
    }
    internal void RRestore(bool rorr = false)
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
        ReCalc();
    }
    internal Upgrade(string namep, bool isboughtp, BigInteger valuep, BigInteger dvaluep, BigInteger multp, BigInteger scachep, bool dopop = false, bool isrankpersistentp = false, bool isrebirtpersistentp = false) : this()
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
internal enum saveorder
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
    levelupmult,
    totalclicks,
    totalclicksdirect,
    add1r,
    add2r,
    add3r,
    add4r,
    add5r,
    add6r,
    add7r,
    add8r,
    add9r,
    add10r,
    mult1r,
    mult2r,
    mult3r,
    mult4r,
    mult5r,
    mult6r,
    mult7r,
    mult8r,
    mult9r,
    mult10r,
    autogenmultr,
    advance
}
