using System;
using System.Collections;
using System.Collections.Generic;

namespace DSALab_8
{
    public class BinaryTree
    {
        static int root = 0;
        static String[] str = new String[10];
        /*create root*/
        public void Root(String key)
        {
            str[0] = key;
        }
        public void print_Tree()
        {
            for (int i = 0; i < 10; i++)
            {
                if (str[i] != null)
                    Console.Write(str[i]);
                else Console.Write("-");
            }
        }


        /*create right son of root*/
        public void set_Right(String key, int root)
        {
            int t = (root * 2) + 2;
            if (str[root] == null)
                Console.Write("Can't set child at {0}, no parent found\n", t);
            else
                str[t] = key;
        }

        /*create left son of root*/
        public void set_Left(String key, int root)
        {
            int t = (root * 2) + 1;
            if (str[root] == null)
            {
                Console.Write("Can't set child at {0}, no parent found\n", t);
            }
            else { str[t] = key; }
        }


        public void preOrder()
        {
            Stack<string> nodeStack = new Stack<string>();
            nodeStack.Push(str[0]);

            while (nodeStack != null)
            {
                Console.Write("{0} --> ", nodeStack.Pop());

                int right = (root * 2) + 2;
                int left = (root * 2) + 1;

                nodeStack.Push(str[right]);
                nodeStack.Push(str[left]);

                root++;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree obj = new BinaryTree();
            obj.Root("A");
            obj.set_Left("B", 0);
            obj.set_Right("C", 0);
            obj.set_Left("D", 1);
            obj.set_Right("E", 1);
            obj.set_Left("F", 2);
            obj.set_Right("G", 2);
            obj.print_Tree();
            obj.preOrder();

            Console.ReadLine();
        }
    }
}
