using System;

namespace DSALab_9
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree() {
            root = null;
        }

        public void Insert(int data) {
            root = Insert(root, data);
        }

        private Node Insert(Node node, int data) {
            if (node == null)
            {
                node = new Node(data);
            }
            else
            {
                if (data <= node.data)
                {
                    node.left = Insert(node.left, data);
                }
                else
                {
                    node.right = Insert(node.right, data);
                }
            }
            return node;
        }

        public bool Search(int data) {
            return Search(root, data);
        }

        private bool Search(Node node, int data) {
            if (node == null)
            {
                return false;
            }
            if (node.data == data)
            {
                return true;
            }
            else if (data < node.data)
            {
                return Search(node.left, data);
            }
            else
            {
                return Search(node.right, data);
            }
        }

        public void PreorderTraversal() {
            PreorderTraversal(root);
        }
        private void PreorderTraversal(Node node) {
            if (node != null)
            {
                Console.Write(node.data + " ");
                PreorderTraversal(node.left);
                PreorderTraversal(node.right);
            }
        }

        public void InorderTraversal() {
            InorderTraversal(root);
        }

        private void InorderTraversal(Node node) {
            if (node != null)
            {
                InorderTraversal(node.left);
                Console.Write(node.data + " ");
                InorderTraversal(node.right);
            }
        }

        public void PostorderTraversal() {
            PostorderTraversal(root);
        }

        private void PostorderTraversal(Node node) {
            if (node != null)
            {
                PostorderTraversal(node.left);
                PostorderTraversal(node.right);
                Console.Write(node.data + " ");
            }
        }
    }
    class AVL
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data)
            {
                this.data = data;
            }
        }
        Node root;
        public AVL()
        {
        }
        public void Add(int data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }
        private Node RecursiveInsert(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.data < current.data)
            {
                current.left = RecursiveInsert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.data > current.data)
            {
                current.right = RecursiveInsert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }
        private Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        public void Delete(int target)
        {//and here
            root = Delete(root, target);
        }
        private Node Delete(Node current, int target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target < current.data)
                {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target > current.data)
                {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = Delete(current.right, parent.data);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        public void Find(int key)
        {
            if (Find(key, root).data == key)
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
        private Node Find(int target, Node current)
        {

            if (target < current.data)
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }
        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }
        private void InOrderDisplayTree(Node current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.left);
                Console.Write("{0}, ", current.data);
                InOrderDisplayTree(current.right);
            }
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AVL tree = new AVL();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            tree.Delete(3);
            tree.DisplayTree();

            Console.ReadLine();
            /*BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40); 
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("Preorder traversal: ");
            bst.PreorderTraversal();
            Console.WriteLine("\n");

            Console.WriteLine("Inorder traversal: ");
            bst.InorderTraversal();
            Console.WriteLine("\n");

            Console.WriteLine("Postorder traversal: ");
            bst.PostorderTraversal();
            Console.WriteLine("\n");

            int searchKey = 90;
            if (bst.Search(searchKey)) {
                Console.WriteLine("\n" + searchKey + " is found in the tree.");
            }
            else {
                Console.WriteLine(searchKey + " is not found in the tree.");
            }*/


            /** 
             * This program defines a Node class to represent a node in the tree, with properties data, left, and right to store the data value, left child, and right child of the node, respectively. 
             

             * The BinarySearchTree class represents the tree itself, with a private root node and methods for inserting, searching, and traversing the tree. 
             
             
             * The Insert method inserts a new node into the tree, maintaining the binary search tree property. 
             
             
             * The Search method searches for a given data value in the tree, and the PreorderTraversal, InorderTraversal, and PostorderTraversal methods traverse the tree and print the data values of the nodes in preorder, inorder, and postorder, respectively. 
             
             
             * The Main method creates a new BinarySearchTree object and inserts some data values into it, then performs various operations on the tree.
             */
        }
    }
}
