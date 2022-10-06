using System;
using System.Collections;
using System.Collections.Generic;

namespace DSALab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Task 01*/
            /*int[] arr = { 2, 5, 6, 7, 1, 4 };
            Console.WriteLine("\tMenu");
            Console.WriteLine("Which Sorting Algo You Would Like To Apply?\n" +
                              "1. Bubble Sort\n" +
                              "2. Selection Sort\n" +
                              "3. Insertion Sort");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1: Console.WriteLine("\tBubble Sort\n"); bubble_Sort(arr); break;
                case 2: Console.WriteLine("\tSelection Sort\n"); selection_Sort(arr); break;
                case 3: Console.WriteLine("\tInsertion Sort\n"); insertion_Sort(arr); break;

                default:
                    Console.WriteLine("Wrong Input...");
                    break;
            }
            Console.Write("After Sorting : ");
            foreach (var item in arr) {
                Console.Write("{0}, " , item);
            }*/


            /*Task 02*/

            /*string[] arr = { "Rizan", "Harry", "Steve", "Thor" };
            Console.Write("Before Sorting : ");
            displayArray(arr);
            selection_Sort(arr);
            Console.Write("After Sorting : ");
            displayArray(arr);*/



            /* Task 03*/

            /*string[,] chemicals = { {"HCL", "12", "123" },
                                    { "CH3", "10", "321" },
                                    { "H2SO4", "24", "541"},
                                    { "NaCl", "23", "544"} };

            sortChemicals(chemicals);

            Console.WriteLine("Chemicals\tVolume\tConcentration");
            for (int t = 0; t < chemicals.GetLength(0); t++)
            {
                for (int j = 0; j < chemicals.GetLength(1); j++)
                    Console.Write("{0}\t\t", chemicals[t, j]);
                Console.WriteLine();
            }*/


            /* Task 04*/

            /*Console.Write("Input Length Of Array : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input Index[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            selection_Sort(arr);
            Console.Write("After Sorting : ");
            foreach (var item in arr)
            {
                Console.Write("{0}, ", item);
            }*/

            /* Task 05*/

            Console.Write("Input No. Of Products : ");
            int len = Convert.ToInt32(Console.ReadLine());
            string[,] products = new string[len, 2];

            for (int i = 0; i < products.GetLength(0); i++)
            {
                Console.Write("Input Product Name : ");
                products[i, 0] = Console.ReadLine();
                Console.Write("Input Price : ");
                products[i, 1] = Console.ReadLine();
            }
            sortProducts(products);


            Console.ReadLine();

        }

        public static void bubble_Sort(int[] array)
        {
            int n = array.Length;
            int k;
            for (int m = n; m >= 0; m--)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    k = i + 1;
                    if (array[i] > array[k])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[k];
                        array[k] = temp;
                    }
                }
            }
        }
        public static void selection_Sort(int[] arr)
        {
            int temp, smallest;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
        public static void insertion_Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }

        public static void selection_Sort(string[] str)
        {
            int smallest;
            string temp;
            int n = str.Length;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (str[j].CompareTo(str[smallest]) > 0) {
                        smallest = j;
                    }
                }
                temp = str[smallest];
                str[smallest] = str[i];
                str[i] = temp;
            }
        }
        public static void displayArray(string[] arr) {
            foreach (var item in arr) {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine();
        }


        public static void sortChemicals(string[,] chemicals)
        {
            int smallest;
            string temp, temp2, temp3;
            int n = chemicals.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (int.Parse(chemicals[j, 1]) < int.Parse(chemicals[smallest, 1]))
                        smallest = j;
                }

                temp = chemicals[smallest, 1];
                temp2 = chemicals[smallest, 0];
                temp3 = chemicals[smallest, 2];

                chemicals[smallest, 0] = chemicals[i, 0];
                chemicals[smallest, 1] = chemicals[i, 1];
                chemicals[smallest, 2] = chemicals[i, 2];

                chemicals[i, 1] = temp;
                chemicals[i, 0] = temp2;
                chemicals[i, 2] = temp3;
            }
        }
        public static void sortProducts(string[,] products)
        {
            int smallest;
            char ans = 'y';
            string temp, temp2;
            int n = products.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (int.Parse(products[j, 1]) < int.Parse(products[smallest, 1]))
                        smallest = j;
                }

                temp = products[smallest, 1];
                temp2 = products[smallest, 0];

                products[smallest, 0] = products[i, 0];
                products[smallest, 1] = products[i, 1];

                products[i, 1] = temp;
                products[i, 0] = temp2;
            }
            Console.WriteLine("'\nProduct\t\tPrice");
            for (int t = 0; t < products.GetLength(0); t++)
            {
                for (int j = 0; j < products.GetLength(1); j++)
                    Console.Write("{0}\t\t", products[t, j]);
                Console.WriteLine();
            }

            do
            {
                Console.Write("\nEnter Product Name: ");
                string product = Console.ReadLine();
                for (int i = 0; i < products.GetLength(0); i++)
                {
                    for (int j = 0; j < products.GetLength(1); j++)
                    {
                        if (product.Equals(products[j,0]))
                        {
                            Console.WriteLine("\tProduct Found!!\n");
                            Console.WriteLine("Product\tPrice");
                            Console.Write("{0}\t\t", products[j, 0]);
                            Console.Write("{0}\t\t", products[j, 1]);
                            Console.WriteLine("\nDo You Want To Search Another Product [Y/n]");
                            ans = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                        else {
                            Console.WriteLine("\tProduct Not Found!!\n");
                            Console.Write("Do You Want To Search Another Product [Y/n]");
                            ans = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    }
                }
                
            } while (ans.Equals('y') || ans.Equals('Y'));
        }

    }
}
