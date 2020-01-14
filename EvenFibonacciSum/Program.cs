using System;

namespace EvenFibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class FibonacciSequence
    {
        private int Xn = 1;
        private int XnMinusOne = 0;

        public int Current() => Xn;

        public int Next()
        {
            var holding = XnMinusOne;
            XnMinusOne = Xn;
            Xn += holding;
            return Xn;
        }

        public int NextEven()
        {
            var num = Next();
            while (num % 2 != 0)
            {
                num = Next();
            }
            return num;
        }
    }
}
