using System;
using System.Collections.Generic;

namespace DefthFirst
{
    class Program
    {
        public class Google
        {
            public Google(string references)
            {
                this.references = references;
            }

            public string references { get; set; }

            public List<Google> Products
            {
                get
                {
                    return ProductList;
                }
            }

            public void isProductOf(Google e)
            {
                ProductList.Add(e);
            }

            List<Google> ProductList = new List<Google>();

            public override string ToString()
            {
                return references;
            }
        }

        public class DepthFirstAlgorithm
        {
            public Google BuildRefGraph()
            {
                Google google = new Google("Google");
                Google Gmail = new Google("Gmail");
                Google Photos = new Google("Photos");
                Google Drive = new Google("Drive");
                google.isProductOf(Gmail);
                google.isProductOf(Photos);

                Google Microsoft = new Google("Lisa");
                Google Outlook = new Google("Tina");
                Gmail.isProductOf(google);
                Photos.isProductOf(google);
                Drive.isProductOf(google);
                Microsoft.isProductOf(google);
                Outlook.isProductOf(Microsoft);

                return google;
            }

            public Google Search(Google root, string nameToSearchFor)
            {
                if (nameToSearchFor == root.references)
                    return root;

                Google referenceFound = null;
                for (int i = 0; i < root.Products.Count; i++)
                {
                    referenceFound = Search(root.Products[i], nameToSearchFor);
                    if (referenceFound != null)
                        break;
                }
                return referenceFound;
            }

            public void Traverse(Google root)
            {
                Console.WriteLine(root.references);
                for (int i = 0; i < root.Products.Count; i++)
                {
                    Traverse(root.Products[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            DepthFirstAlgorithm b = new DepthFirstAlgorithm();
            Google root = b.BuildRefGraph();
            Console.WriteLine("Traverse Graph\n------");
            b.Traverse(root);

            Console.WriteLine("\nSearch in Graph\n------");
            Google e = b.Search(root, "Eva");
            Console.WriteLine(e == null ? "Employee not found" : e.references);
            e = b.Search(root, "Brian");
            Console.WriteLine(e == null ? "Employee not found" : e.references);
            e = b.Search(root, "Soni");
            Console.WriteLine(e == null ? "Employee not found" : e.references);
        }
    }
}