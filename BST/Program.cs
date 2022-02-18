using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(56);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Display();
            Console.ReadLine();
        }
    }
}
