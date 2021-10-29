using System;

namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            if (root == null)
            {
                return 0;
            }

            return getSize(root);
        }

        public int getSize(BinaryNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return getSize(node.left) + 1 + getSize(node.right);
        }

        public int Height()
        {
            if (root == null)
            {
                return -1;
            }

            return getHeight(root) - 1;
        }

        public int getHeight(BinaryNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(getHeight(node.left), +getHeight(node.right)) + 1;
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.data = rootItem;
            root = newNode;
            root.left = t1.GetRoot();
            root.right = t2.GetRoot();
        }

        public string ToPrefixString()
        {
            if (root == null)
            {
                return "NIL";
            }

            return toPrefix(root).Trim();
        }

        public string toPrefix(BinaryNode<T> root)
        {
            if (root != null)
            {
                string toReturn = "";
                toReturn += "[ " + root.data + " " + toPrefix(root.left) + toPrefix(root.right);
                toReturn += "] ";
                return toReturn;
            }

            return "NIL ";
        }

        public string ToInfixString()
        {
            if (root == null)
            {
                return "NIL";
            }

            return toInfix(root).Trim();
        }

        public string toInfix(BinaryNode<T> root)
        {
            if (root == null)
            {
                return "NIL ";
            }

            string toReturn = "";
            toReturn += "[ " + toInfix(root.left) + root.data + " " + toInfix(root.right);
            toReturn += "] ";
            return toReturn;
        }

        public string ToPostfixString()
        {
            if (root == null)
            {
                return "NIL";
            }

            return toPostfix(root).Trim();
        }

        public string toPostfix(BinaryNode<T> root)
        {
            if (root != null)
            {
                string toReturn = "";
                toReturn += "[ " + toPostfix(root.left) + toPostfix(root.right) + root.data + " ";
                toReturn += "] ";
                return toReturn;
            }

            return "NIL ";
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithOneChild()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithTwoChildren()
        {
            throw new System.NotImplementedException();
        }
    }
}