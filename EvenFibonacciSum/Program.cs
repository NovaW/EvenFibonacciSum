using System;

namespace EvenFibonacciSum
{
    class Program
    {
        const int MAX = 5000000;
        static void Main(string[] args)
        {
            var sequence = new FibonacciSequence();
            var nextSum = 0;

            int sum;
            int nextEven;

            do
            {
                sum = nextSum;
                nextEven = sequence.NextEven();
                nextSum = sum + nextEven; //just minimizing number of additions at the expense of memory
            }
            while (nextSum < MAX);

            Console.WriteLine(sum);
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
