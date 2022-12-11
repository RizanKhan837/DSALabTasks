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
            Queue queue = new Queue();

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
            queue.PrintArray();

            Console.ReadLine();
        }
    }
}
