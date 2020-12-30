using System;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int data)
        {
            this.Data = data;
        }
        public void Insert(int value)
        {
            if (value <= Data)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }

                else
                {
                    Left.Insert(value);
                }
            }

            else
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }

                else
                {
                    Right.Insert(value);
                }
            }
        }
        public bool Contains(int value)
        {
            if (value == Data)
            {
                return true;
            }

            else if (value < Data)
            {
                if (Left == null)
                { 
                    return false;
                }

                else
                {
                    return Left.Contains(value);
                }
            }

            else
            {
                if (Right == null)
                {
                    return false;
                }

                else
                {
                    return Right.Contains(value);
                }
            }
        } 
        public void PrintInOrder()
        {
            if (Left != null)
            {
                Left.PrintInOrder();
            }

            Console.WriteLine(Data);

            if (Right != null)
            {
                Right.PrintInOrder();
            }
        }
    }
}
