using System;

namespace DSALab_4
{
    public class Node
    {
        public int data;
        public Node prev;
        public Node next;
        public Node(int d) { data = d; }
    }
    public class DLL
    {
        public Node head;
        public void push(int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = head;
            new_Node.prev = null;
            if (head != null)
                head.prev = new_Node;
            head = new_Node;
        }
        public void InsertAfter(Node prev_Node, int new_data)
        {
            if (prev_Node == null) {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_Node.next;
            prev_Node.next = new_node;
            new_node.prev = prev_Node;
            if (new_node.next != null)
                new_node.next.prev = new_node;
        }
        public void append(int new_data)
        {
            Node new_node = new Node(new_data);
            Node last = head;
            new_node.next = null;
            if (head == null) {
                new_node.prev = null;
                head = new_node;
                return;
            }
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            new_node.prev = last;
        }
        public void Insertbefore(Node next_Node, int new_data)
        {
            if (next_Node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.prev = next_Node.prev;
            next_Node.prev = new_node;
            new_node.next = next_Node;
            if (new_node.prev != null)
                new_node.prev.next = new_node;
            else { head = new_node; }
        }
        public void DelFromStart()
        {
            if (head.next.next == null)
            { head.next = null; }
            else
            {
                Console.WriteLine("THE DATA {0} IS DELETED FROM LINKEDLIST", head.next.data);
                head.next = head.next.next;
                head.next.prev = null;
            }
        }
        public void DelFromEnd()
        {
            if (head.next.next == null)
            {
                Console.WriteLine("THE DATA {0} IS DELETED FROM LINKEDLIST", head.next.data);
                head.next = null;
            }
            else
            {
                Node temp = head.next;
                while (temp.next.next != null)
                { temp = temp.next; }
                Console.WriteLine("THE DATA {0} IS DELETED FROM LINKEDLIST", temp.next.data);
                temp.next = null;
            }
        }
        public void DelAfter(int data)
        {
            Node temp = head.next;
            while (temp.data != data)
            {
                if (temp.next == null) { return; }
                else if (temp.next.next == null)
                { temp.next = null; }
                else { temp = temp.next; }
            }
            Console.WriteLine("THE DATA {0} IS DELETED FROM LINKEDLIST", temp.next.data);
            temp.next = temp.next.next;
            temp.next.next.prev = temp;
        }
        public void menu(DLL list)
        {
            /*Console.WriteLine("Enter the value 1: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value 2: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value 3: ");
            int v3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value 4: ");
            int v4 = Convert.ToInt32(Console.ReadLine());
            list.head = new Node(v1);
            Node second = new Node(v2);
            Node third = new Node(v3);
            Node f4 = new Node(v4);
            list.head.next = second;
            second.next = third;
            second.prev = list.head;
            third.prev = second;
            third.next = f4;
            f4.prev = third;*/

            Console.WriteLine("-------Traversing-----------");
            list.printlist(list.head);
            Console.WriteLine();
            Console.WriteLine("\n1) Insertion  \n2)Deletion");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine(" \n1) At the front of the DLL \n2) After a given node. \n3) At the end of the DLL \n4) Before a given node");
                    int opt = int.Parse(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter your data: ");
                                int data = int.Parse(Console.ReadLine());
                                list.push(data);
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter your data: ");
                                int data = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the value you want to add");
                                int a = int.Parse(Console.ReadLine());
                                list.InsertAfter(second, a);
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter the value you want to add");
                                int a = int.Parse(Console.ReadLine());
                                list.append(a);
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter the value you want to add");
                                int a = int.Parse(Console.ReadLine());
                                list.Insertbefore(second, a);
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option");
                                break;
                            }
                    }
                    break;
                case 2:
                    Console.WriteLine(" \n1)DelFromStart \n2) DelFromEnd \n3)  DelAfter ");
                    int opt1 = int.Parse(Console.ReadLine());
                    switch (opt1)
                    {
                        case 1:
                            {
                                list.DelFromStart();
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        case 2:
                            {
                                list.DelFromEnd();
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                        case 3:
                            {
                                list.DelAfter(v4);
                                Console.WriteLine("-------Traversing-----------");
                                list.printlist(list.head);
                                break;
                            }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
            }
            Console.WriteLine();
        }
        public void printlist(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DLL dll = new DLL();
            dll.menu(dll);
            Console.ReadLine();
        }
    }
}
