using System.Numerics;

namespace MultiGame.Shared.Structs;

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
