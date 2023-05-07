using System.Numerics;
using MultiGame.Shared.Structs;

namespace MultiGame.Shared;

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
