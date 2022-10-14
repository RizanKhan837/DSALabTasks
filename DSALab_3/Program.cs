using System;

namespace DSALab_3
{
    class LinkedListNode
    {
        public string data;
        public LinkedListNode next;

        public LinkedListNode() {
            Console.Write("Enter Data: ");
            data = Console.ReadLine();
            next = null;
        }
    }
    class LinkedList
    {
        public LinkedListNode head;
        int count = 1;

        public void addNodeToFront(int num) {
            for (int i = 0; i < num; i++) {
                LinkedListNode node = new LinkedListNode();
                node.next = head;
                head = node;
            }
        }
        public void addNodeAtEnd(int num)
        {
            for (int i = 0; i < num; i++) {

                LinkedListNode node = new LinkedListNode();
                if (head == null)
                {
                    Console.WriteLine("Head Can't Be Null");
                }

                node.next = null;
                LinkedListNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    temp.next = node;
                }
            }
        }
        public void addNodeAfter(LinkedListNode prev, int num)
        {
            for (int i = 0; i < num; i++) {
                if (prev == null) {
                    head = new LinkedListNode();
                }
                LinkedListNode node = new LinkedListNode();
                node.next = prev.next;
                prev.next = node;
            }
        }

        public void menu(LinkedList list) {
            int inp;
            Console.Write("\tChoose One Option...\n" +
                              "1. Insertion\n" +
                              "2. Deletion\n" +
                              "3. Display Data\n" +
                              "Enter Option : ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.Write("\n\tChoose One Option...\n" +
                                      "1. Push\n" +
                                      "2. Append\n" +
                                      "3. Insert After Given Address\n" +
                                      "Enter Option : ");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    switch (ans)
                    {
                        case 1: inp = input(); addNodeToFront(inp); break;
                        case 2: inp = input(); addNodeAtEnd(inp); break;
                        case 3: inp = input(); addNodeAfter(list.head.next, inp); break;
                        default: Console.WriteLine("Invalid Input..."); break;
                    }
                    break;
                case 2:
                    Console.Write("\nInput Item To Be Deleted : ");
                    string item = Console.ReadLine();
                    list.deleteNode(item); break;
                case 3: 
                    list.printData(); break;
                default:
                    Console.WriteLine("Invalid Input..."); break;
            }
            menu(list);
        }
        public int input() {
            LinkedList list = new LinkedList();
            Console.Write("Total No. Of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public void printData() {
            LinkedListNode node = head;
            if (node == null)
                Console.WriteLine("\n\tList Is Empty :(");
            else {
                Console.WriteLine("\n\tData");
                while (node != null) {
                    Console.WriteLine("{0}. {1}", count, node.data);
                    node = node.next;
                    count++;
                }
                Console.WriteLine("\n/*------------------*/");
            }
        }
        public void deleteNode(string key)
        {
            LinkedListNode temp = head, prev = null;

            if (temp != null && temp.data == key) {
                head = temp.next;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.menu(list);
            Console.ReadLine();
        }
    }
}
