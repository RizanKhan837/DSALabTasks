using System;

namespace DSALab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", func(123));
            Console.ReadLine();
        }

        public static int func(int n) {
            int sum = 0;
            while (n >= 0) {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
