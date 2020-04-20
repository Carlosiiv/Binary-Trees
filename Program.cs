using System;
using BinarySearchTree.Models;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new BST();
            var newNode = new Node(5);
            list.InsertAt(newNode);
                        
        }
    }
}
