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
    public class DoublyLinkedList
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
        public void insertAfter(Node prev_Node, int new_data)
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
        public void insertBefore(Node next_Node, int new_data)
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
        
        public void menu(DoublyLinkedList list)
        {
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
                                      "3. Insert After\n" +
                                      "4. Insert Before\n" +
                                      "Enter Option : ");
                    int ans = Convert.ToInt32(Console.ReadLine());
                    switch (ans)
                    {
                        case 1: inp = input(); push(inp); break;
                        case 2: inp = input(); append(inp); break;
                        case 3: inp = input(); insertAfter(list.head.prev, inp); break;
                        case 4: inp = input(); insertBefore(list.head.next, inp); break;
                        default: Console.WriteLine("Invalid Input..."); break;
                    }
                    break;
                case 2:
                    Console.Write("\nInput Item To Be Deleted : ");
                    int item = Convert.ToInt32(Console.ReadLine());
                    list.deleteNode(item); break;
                case 3:
                    list.printData(list.head); break;
                default:
                    Console.WriteLine("Invalid Input..."); break;
            }
            menu(list);
        }

        public void deleteNode(int key)
        {
            Node temp = head, prev = null;

            if (temp != null && temp.data == key) {
                head = temp.next;
            }

            while (temp != null && temp.data != key) {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public int input()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Console.Write("Total No. Of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public void printData(Node node) {

            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null) {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null) {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.menu(dll);
            Console.ReadLine();
        }
    }
}
