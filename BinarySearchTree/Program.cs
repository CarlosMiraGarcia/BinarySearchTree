using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(50);
            Random rdn = new Random();

            for (int i = 0; i < 20; i++)
            {
                root.Insert(rdn.Next(0, 100));
            }

            root.PrintInOrder();
            Console.Write("Does the tree contains 5000? ");
            Console.WriteLine(root.Contains(5000));
            Console.Write("Does the tree contains 2101? ");
            Console.WriteLine(root.Contains(2101));
            Console.ReadLine();

            //Checking if it is a binary tree
            Console.WriteLine("Is a proper Binary Tree? " + CheckBST(root));
            //Adding a bigger number than root on the left
            Node left = new Node(5001);
            root.Left = left;
            Console.WriteLine("Is a proper Binary Tree? " + CheckBST(root));
            
        }

        // CheckBST will basically check if the tree is a valid binary tree
        // That means that the nodes on the left of the root as smaller than the root
        // and the nodes on the right side of the root are bigger than the root
        static bool CheckBST(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.Data < min || root.Data > max)
            {
                return false;
            }

            return CheckBST(root.Left, min, root.Data - 1) && CheckBST(root.Right, root.Data + 1, max);
        }
        static bool CheckBST(Node root)
        {
            return CheckBST(root, int.MinValue, int.MaxValue);
        }
    }

    public class BST
    { }

}
