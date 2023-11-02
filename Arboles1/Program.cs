using System;

namespace Arboles1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(23);
            nums.Insert(45);
            nums.Insert(16);
            nums.Insert(37);
            nums.Insert(3);
            nums.Insert(99);
            nums.Insert(22);
            Console.WriteLine("InOrder traversal: ");
            nums.InOrder(nums.root);
            Console.WriteLine("\nPreOrder traversal: ");
            nums.PreOrder(nums.root);
            Console.WriteLine("\nPostOrder traversal: ");
            nums.PostOrder(nums.root);
        }
    }
}