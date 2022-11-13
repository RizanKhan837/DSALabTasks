using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALab_6
{
    class Program
    {
        public static Dictionary<string, string> errors = new Dictionary<string, string>();
        public static List<string> result = new List<string>();

        static void Main(string[] args)
        {
            
            /*recSeq(6);
            Console.WriteLine();*/

            /*SqrOdd(1);
            Console.ReadLine();*/

            /*SumOfDigit(123);
            Console.ReadLine();*/

            /* int x = 250;
            int y = 475;
            Console.WriteLine("HCF of " + x + " and " + y + " is: " + Hcf(x, y));
            Console.ReadLine();*/

            /*Console.WriteLine();*/

            //SumOfDigit(123);

            /*SqrOdd(1);*/

            /* Hcf Of 2 Digit */

            /*SearchForFile("D:\\Movies");
            foreach (var item in result) {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/


            Console.ReadLine();
        }
        public int Recursive(int param)
        {
            return (param == 0) ? 0 : Recursive(param - 1) + param;
            /* Rec(5)
                Rec(4) + 5 => 10+5
                    Rec(3) + 4 => 6+4
                        Rec(2) + 3 => 3+3
                            Rec(1) + 2 => 1+2
                                Rec(0) + 1 => 0+1*/
        }

        public long Factorial(int n)
        {  // Iterative
            if (n == 0)
                return 1;
            long value = 1;
            for (int i = n; i > 0; i--)
                value *= i;

            return value;
        }

        static int Hcf(int x, int y)
        {
            if (y == 0)
                return x;
            return Hcf(y, x % y);
        }
        public long FactorialRec(int n)
        {
            if (n == 0)  // The condition that limits the method for calling itself
                return 1; // Base Case
            return n * FactorialRec(n - 1);
            /* 5 * Fac(4) => 5 * 24
                  4 * Fac(3) => 4 * 6
                     3 * Fac(2) => 3 * 2
                         2 * Fac(1) => 2 * 1
                             1 * Fac(0) => 1*/
        }

        public static double Series(int n)
        {
            if (n == 0) {
                return 1;
            }
            else {
                return Series(n - 1) * 2;
            }
        }

        static void recSeq(int n)
        {
            if (n > 1)
            {
                recSeq(n - 1);
                /* Rec(5) => 2**4
                      Rec(4) => 2**3
                          Rec(3) => 2**2
                             Rec(2) => 2**1 */
                Console.WriteLine("{0}", Math.Pow(2, n - 1));
            }
            else
                Console.WriteLine(1);
        }
        public static int SqrOdd(int num)
        {
            if (num > 20) {
                return 1;
            }
            Console.WriteLine(Math.Pow(num, 2));
            return SqrOdd(num + 2);
        }

        public static void SumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0) {
                sum += num % 10; // 123 = 3
                num /= 10; // 12
            }
            Console.WriteLine(sum);
        }

        public static void SearchForFile(string path)
        {
            try
            {
                foreach (string fileName in Directory.GetFiles(path))
                { //Gets aLL fiLes in the current path
                    result.Add(fileName);
                }

                foreach (string directory in Directory.GetDirectories(path))
                { //Gets aLL foLders in the current path 
                    SearchForFile(directory); //The methods caLLs itseLf with a new parameter, here! 
                }
            }
            catch (System.Exception ex)
            {
                errors.Add(path, ex.Message); //Stores Error Messages in a dictionary with path in key 
            }
        }
    }
}


