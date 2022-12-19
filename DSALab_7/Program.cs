using System;
using System.Collections;
using System.Collections.Generic;

namespace DSALab_7
{
    class Program
    {
        internal class Queue
        {
            string[] Messages = new string[5];
            public ArrayList MessageBuffer = new ArrayList();
            public int front = -1;
            public int rear = -1;
            int i = 0;
            int msgIndex = 0;

            public bool IsEmpty(int front, int rear)
            {
                if (front == -1 && rear == -1)
                    return true;
                else
                    return false;
            }
            public bool IsFull(string[] Messages, int rear)
            {
                if (rear == Messages.Length - 1)
                {
                    //Console.WriteLine("Messages is Full...Delete Some Messages!! \n");
                    return true;
                }
                else {
                    return false;
                }
            }

            public void Enqueue(string message)
            {
                if (IsFull(Messages, rear))
                {
                    MessageBuffer.Add(message);
                    return;
                }
                else if (IsEmpty(front, rear))
                {
                    front = 0;
                    rear = 0;
                    Messages[rear] = message;
                }
                else
                {
                    rear = rear + 1;
                    Messages[rear] = message;
                }
            }
            public void Dequeue()
            {
                int index = 0;
                if (IsEmpty(rear, front)) {
                    return;
                }
                else if (front == rear)
                {
                    Messages[rear] = MessageBuffer[index].ToString();
                    MessageBuffer.RemoveAt(index);
                    front = rear = 0;
                }
                else
                {
                    //front = front + 1;
                    for (int i = 0; i < Messages.Length - 1; i++)
                    {
                        //string temp = Messages[i];
                        Messages[i] = Messages[i + 1];
                        //Messages[i + 1] = temp;
                    }

                    Messages[rear] = MessageBuffer[index].ToString();
                    
                    MessageBuffer.RemoveAt(index);
                    rear++;
                }

            }
            public void PrintArray()
            {
                int count = 1;
                foreach (var item in Messages)
                {
                    Console.WriteLine("Message {0} : {1}", count, item);
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            /*Queue queue = new Queue();

            queue.Enqueue("Hello World");
            queue.Enqueue("Hi");
            queue.Enqueue("How");
            queue.Enqueue("are");
            queue.Enqueue("You");

            queue.Enqueue("Rizan");
            queue.Enqueue("Khan");

            Console.WriteLine("\nMessages:");
            queue.PrintArray();
            Console.WriteLine();

            Console.WriteLine("\nBuffer Messages:");
            foreach (var item in queue.MessageBuffer) {
                Console.WriteLine(item);
            }

            queue.Dequeue();

            Console.WriteLine("\nBuffer Messages:");
            foreach (var item in queue.MessageBuffer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNew Messages:");
            queue.PrintArray();*/

            /*  Merge Sort   */

            char[] array = { 'd', 'b', 'a', 'e', 'c', 'f', 'h', 'g', 'i', 'j' };

            Console.WriteLine("Original array: " + string.Join(", ", array));

            MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            Console.ReadLine();
        }

        static void MergeSort(char[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);
                Merge(array, start, middle, end);
            }
        }

        static void Merge(char[] array, int start, int middle, int end)
        {
            int n1 = middle - start + 1;
            int n2 = end - middle;

            char[] left = new char[n1];
            char[] right = new char[n2];

            for (int x = 0; x < n1; x++)
            {
                left[x] = array[start + x];
            }
            for (int y = 0; y < n2; y++)
            {
                right[y] = array[middle + 1 + y];
            }

            int i = 0;
            int j = 0;
            int k = start;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
