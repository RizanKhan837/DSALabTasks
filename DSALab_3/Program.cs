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

        public void addNodeToFront()
        {
            LinkedListNode node = new LinkedListNode();
            node.next = head;
            head = node;
        }
        public void addNodeAtEnd()
        {
            LinkedListNode node = new LinkedListNode();

            if (head == null) {
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
        public void addNodeAfter(LinkedListNode prev, string data)
        {
            if (prev == null) {
                head = new LinkedListNode();
            }

            LinkedListNode node = new LinkedListNode();

            node.next = prev.next;
            prev.next = node;
        }

        public void menu() {
            Console.Write("Choose One Option...\n" +
                              "1. Insertion\n" +
                              "2. Deletion\n" +
                              "3. Display Data\n" +
                              "Enter Option : ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Choose One Option...\n" +
                                      "1. Push\n" +
                                      "2. Append\n" +
                                      "3. Insert After Given Address");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    switch (ans)
                    {
                        case 1: addNodeToFront(); break;
                        case 2: addNodeAtEnd(); break;
                        case 3: addNodeAfter(); break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public void input() { 
        }
        public void printData()
        {
            LinkedListNode node = head;
            while (node != null) {
                Console.WriteLine(node.data);
                node = node.next;
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
            Console.Write("Input No. Of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++) {
                list.addNodeToFront();
            }
            Console.WriteLine("\nPrint Data");
            list.printData();
            Console.Write("\nInput Item To Be Deleted : ");
            string item = Console.ReadLine();
            list.deleteNode(item);
            Console.WriteLine("\nAfter Deletion");
            list.printData();
            Console.ReadLine();
        }
    }
}
