using System;
using System.Collections;
using System.Collections.Generic;

namespace DSALab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Selection_Sort(hello);

            /*Console.Write("Input Length Of Array : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            inputArray(arr);
            selection_Sort(arr);
            displayArray(arr);*/

            /*string[,] chemicals = { {"HCL", "12", "123" },
                                    { "CH3", "10", "321" },
                                    { "H2SO4", "24", "541"},
                                    { "NaCl", "23", "544"} };

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

            Console.WriteLine("Chemicals\tVolume\tConcentration");
            for (int t = 0; t < chemicals.GetLength(0); t++)
            {
                for (int j = 0; j < chemicals.GetLength(1); j++)
                    Console.Write("{0}\t\t", chemicals[t, j]);
                Console.WriteLine();
            }*/

            Console.Write("Input No. Of Products : ");
            int len = Convert.ToInt32(Console.ReadLine());

            string[,] products = new string[2, len];


            input2dArray(products);


            Console.ReadLine();



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
            foreach (var item in str)    
            {
                Console.WriteLine(item);
            }
        }

        public static void inputArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input Value At Index[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void displayArray(int[] arr) {
            foreach (var item in arr) {
                Console.WriteLine("{0}, ", item);
            }
        }

        public static void menu()
        {
            int[] arr = { 2, 5, 6, 7, 1, 4 };
            Console.WriteLine("Hello World!");
            Console.WriteLine("\tMenu");
            Console.WriteLine("Which Sorting Algo You Would Like To Apply?\n" +
                              "1. Bubble Sort\n" +
                              "2. Selection Sort\n" +
                              "3. Insertion Sort");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1: bubble_Sort(arr); break;
                case 2: selection_Sort(arr); break;
                case 3: insertion_Sort(arr); break;

                default:
                    Console.WriteLine("Wrong Input...");
                    break;
            }
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

        public static void input2dArray(string[,] arr) {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Input Product Name : ");
                    arr[j, 0] = Console.ReadLine();
                    Console.Write("Input Price : ");
                    arr[j, 1] = Console.ReadLine();
                }
            }
        }

    }
}
