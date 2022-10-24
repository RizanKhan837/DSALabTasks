using System;

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
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.data + " ");
                    node = node.next;
                }
            }

            internal void printStack()
            {
                if (counter <= 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Node node = head;
                    Console.Write("Items In The Stack Are : ");
                    for (int i = counter; i >= 0; i--)
                    {
                        Console.WriteLine(node.data + " ");
                        node = node.next;
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
