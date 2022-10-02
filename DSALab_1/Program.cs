using System;

namespace DSALabTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task 01 */
            /*int[] arr = new int[10];
            Random random = new Random();
            Console.Write("Array Of Length 10: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 50);
                Console.Write("{0}, ", arr[i]);
            }
            Console.WriteLine();

            *//* Task 01 (a)*//*
            Console.Write("\nPairs Of 25 Are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 25)
                        Console.Write("{0}, {1} | ", arr[i], arr[j]);
                }
            }
            Console.WriteLine();
            *//* Task 01 (b)*//*
            int even = 0;
            int odd = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("\nEven {0}", even);
            Console.WriteLine("Odd {0}", odd);

            *//* Task 01 (c) *//*
            Console.WriteLine();
            average(arr);*/

            /* Task 04 */
            /*Console.Write("Input Row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Col: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] array1 = new int[row, col];
            int[,] array2 = new int[row, col];
            int[,] add = new int[row, col];
            int[,] sub = new int[row, col];

            Console.WriteLine("Array 1");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Input Values At[{0}, {1}] : ", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array 2");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Input Values At[{0}, {1}] : ", i, j);
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Original Array \n");

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++)
                    Console.Write(array1[i, j] + "\t");
                Console.WriteLine("\n");
            }

            Console.WriteLine("Addition \n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    add[i, j] = array1[i, j] + array2[i, j];
                    Console.Write(add[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Subtraction \n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sub[i, j] = array1[i, j] - array2[i, j];
                    Console.Write(sub[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }*/



            /* Task 05 */
            /*            int i, j, k;
                        int[,] matrix1 = new int[,] { { 3, 4 }, { 6, 7 } };
                        int[,] matrix2 = new int[,] { { 6, 4 }, { 5, 2 } };
                        if (matrix1.GetLength(1) != matrix2.GetLength(0))
                        {
                            Console.WriteLine("Matrix Not Possible");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

                        for (i = 0; i < matrix1.GetLength(0); i++)
                        {
                            for (j = 0; j < matrix2.GetLength(1); j++)
                            {
                                result[i, j] = 0;
                                for (k = 0; k < matrix1.GetLength(1); k++)
                                {
                                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                                }
                            }
                        }
                        Console.Write("Matrix Multiplication Of Two Above Matrices Are \n");
                        for (i = 0; i < result.GetLength(0); i++)
                        {
                            for (j = 0; j < result.GetLength(1); j++)
                                Console.Write("     {0}  ", result[i, j]);
                            Console.WriteLine();
                        }*/

            /* Task 06 */
            /*int[,] matrix = new int[,] { { 3, 4 },
                                         { 6, 7 } };
            int res = 0;
            Console.WriteLine("\nThe original matrix is ");
            for (int i = 0; i < 2; i++) { 
                for (int j = 0; j < 2; j++)
                    Console.Write("{0:0}  ", matrix[i, j]);
                Console.WriteLine();
            }
            res = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            Console.WriteLine("\nThe determinent of a 2*2 matrix is {0} ", res);*/

            /* Task 07 */
            int[,] matrix = new int[,] { { 4, 6 },
                                           { 1, 2 } };
            double determinant = 0;
            int[,] adjoint = new int[2, 2];
            double[,] inverse = new double[2, 2];

            determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (determinant == 0)
                Console.WriteLine("Determinant Can't Be Zero...");

            Console.WriteLine("The determinent of a 2*2 matrix is {0} ", determinant);

            adjoint[0, 0] = matrix[1, 1];
            adjoint[0, 1] = matrix[0, 1] * (-1);
            adjoint[1, 0] = matrix[1, 0] * (-1);
            adjoint[1, 1] = matrix[0, 0];

            Console.WriteLine("\nThe adjoint of a 2*2 matrix is");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0:0}  ", adjoint[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("The inverse of a 2*2 matrix is");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    inverse[i, j] = adjoint[i, j] / determinant;
                    Console.Write("{0:0.0}  ", inverse[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        public static void average(int[] arr)
        {
            int sum = arr[0];
            int avr;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avr = sum / arr.Length;
            Console.WriteLine("Average Of The Given Array : {0}", avr);
        }
    }
}
