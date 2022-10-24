﻿using System;

namespace DSALab_5
{
    class Program
    {
        internal class Node
        {
            public string data;
            public Node next;
            public Node()
            {
                Console.Write("Enter Data : ");
                this.data = Console.ReadLine();
                next = null;
            }
        }
        public class Llist
        {
            public static Node head;
            public static void printList()
            {
                Node n = head;
                while (n != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
            }
            public void push()
            {
                Node new_node = new Node();
                new_node.next = head;
                head = new_node;
            }


        }
        internal class Stack
        {
            static int counter;
            int top;
            public static Node head;

            internal void push()
            {
                if (head == null)
                {
                    head = new Node();
                    counter++;
                    return;
                }

                Node new_node = new Node();
                new_node.next = null;

                Node last = head;
                while (last.next != null)
                    last = last.next;

                last.next = new_node;
                counter++;
                return;
            }

            internal string pop()
            {
                Node last = head, prev = null;
                if (head == null)
                {
                    Console.WriteLine("List Is Empty...!!");
                    return null;
                }
                while (last.next != null)
                {
                    prev = last;
                    last = last.next;
                }
                if (last == null)
                    return null;

                prev.next = last.next;
                counter--;
                return last.data;
            }

            internal void peek()
            {
                Node last = head;
                while (last.next != null)
                    last = last.next;
                Console.WriteLine("The Topmost element Of Stack is : {0}", last.data);
            }
            internal void printList()
            {
                Node n = head;
                while (n != null)
                {
                    Console.WriteLine(n.data + " ");
                    n = n.next;
                }
            }

            internal void printStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.Write("Items In The Stack Are : ");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.Write("{0}, ", counter);
                    }
                    Console.WriteLine();
                }
            }
            public int getCount() {
                return counter;
            }
            public bool isEmpty() {
                return head == null;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Stack stack = new Stack();
            stack.push();
            stack.push();
            stack.printList();
            string last = stack.pop();
            Console.WriteLine("The Popped Item Is {0}", last);
            Console.WriteLine("The Total Item In The List Are: {0}", stack.getCount());
            stack.printList();
            Console.ReadLine();
        }
    }
}
