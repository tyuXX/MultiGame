using System.Numerics;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Test1()
        {
            BigInteger e = exponent( 44, 44 );
        }
        [Test]
        public void Test2()
        {
            BigInteger e = exponent( 88888, 88888 );
        }
        [Test]
        public void Test3()
        {
            for (; ; )
            {

            }
        }
        public static BigInteger exponent( BigInteger n, BigInteger e )
        {
            BigInteger nn = 1;
            for (BigInteger i = 0; i < e; i++)
            {
                nn *= n;
            }
            return nn;
        }
    }
}