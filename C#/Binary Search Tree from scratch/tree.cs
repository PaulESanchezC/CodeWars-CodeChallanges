using System;

namespace Binary_Search_Tree_from_scratch
{
    public class Tree
    {
        //Variables
        private Node node;
        private Node root;
        private Node current;
        private int Count { get; set; }

        //Node Class
        private class Node
        {
            //Variables
            public int Value { get; private set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            //Constructors
            public Node(int value)
            {
                this.Value = value;
            }
        }

        //Constructor
        public Tree()
        {
            Count = 0;
        }


        //Implementation Methods
        public void Insert(int value)
        {
            if (RootEmpty())
            {
                node = new Node(value);
                root = node;
                Dump();
                return;
            }

            current = root;
            while (true)
            {
                //Right Side
                if (value > current.Value)
                    if (RightEmpty(current))
                    {
                        node = new Node(value);
                        current.Right = node;
                        Dump();
                        break;
                    }
                    else current = current.Right;

                //Left Side
                else
                {
                    if (LeftEmpty(current))
                    {
                        node = new Node(value);
                        current.Left = node;
                        Dump();
                        break;
                    }

                    current = current.Left;
                }
            }
        }
        public bool Find(int value)
        {
            if (RootEmpty())
                return false;

            current = root;
            while (value != current.Value)
            {
                //Right Side
                if (value > current.Value)
                    if (RightEmpty(current))
                    {
                        Dump();
                        break;
                    }
                    else current = current.Right;

                //Left Side
                else
                {
                    if (LeftEmpty(current))
                    {
                        Dump();
                        break;
                    }

                    current = current.Left;
                }
            }

            return current != null && current.Value == value;
        }
        public int Height()
        {
            return Height(root);
        }

        //Methods: Traverses
        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }
        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }
        public int MinValue()
        {
            return MinValue(root);
        }
        public bool EqualsTo(Tree tree)
        {
            if (IsEmpty(tree.root))
                return false;
            return EqualsTo(root, tree.root);
        }

        public bool ValidateBST()
        {
            if (IsEmpty(root))
                return true;
            return ValidateBST(root, Int32.MinValue, Int32.MaxValue);
        }

        //Private Methods
        private bool RootEmpty()
        {
            return root == null;
        }
        private bool RightEmpty(Node node)
        {
            return node.Right == null;
        }
        private bool LeftEmpty(Node node)
        {
            return node.Left == null;
        }
        private void Dump()
        {
            this.node = null;
            this.current = null;
        }
        private bool IsEmpty(Node node)
        {
            return node == null;
        }
        private int Height(Node node)
        {
            if (IsEmpty(node))
                return 0;
            if (LeftEmpty(node) && RightEmpty(node))
                return 0;
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }
        private int MinValue(Node node)
        {
            if (LeftEmpty(node) && RightEmpty(node))
                return node.Value;

            int minLeft = MinValue(node.Left);
            int minRight = MinValue(node.Right);
            return Math.Min(Math.Min(minLeft, minRight), node.Value);
        }
        private bool EqualsTo(Node node, Node treeNode)
        {
            if (IsEmpty(node) && IsEmpty(treeNode))
                return true;

            if (!IsEmpty(node) && !IsEmpty(treeNode))
                return node.Value == treeNode.Value &&
                       EqualsTo(node.Left, treeNode.Left) &&
                       EqualsTo(node.Right, treeNode.Right);
            return false;
        }
        private bool ValidateBST(Node node, int min, int max)
        {
            if (IsEmpty(node))
                return true;
            if (node.Value < min || node.Value > max)
                return false;
            return ValidateBST(node.Left, min, node.Value - 1) && ValidateBST(node.Right, node.Value + 1, max);
        }
        //Private: Traverses
        private void TraversePreOrder(Node node)
        {
            if (IsEmpty(node))
                return;
            Console.WriteLine(node.Value);
            TraversePreOrder(node.Left);
            TraversePreOrder(node.Right);
        }
        private void TraverseInOrder(Node node)
        {
            if (IsEmpty(node))
                return;
            TraverseInOrder(node.Left);
            Console.WriteLine(node.Value);
            TraverseInOrder(node.Right);
        }
        private void TraversePostOrder(Node node)
        {
            if (IsEmpty(node))
                return;
            TraversePostOrder(node.Left);
            TraversePostOrder(node.Right);
            Console.WriteLine(node.Value);
        }

    }
}