﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiGame
{
    public static class rntm
    {
        public static BigInteger money = 0;
        public static BigInteger generation = 0;
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
            return generation*((add1 + add2 + add3 + add4 + add5 + add6 + add7 + add8 + add9 + add10) * (mult1 * mult2 * mult3 * mult4 * mult5 * mult6 * mult7 * mult8 * mult9 * mult10));
        }
    }
}
