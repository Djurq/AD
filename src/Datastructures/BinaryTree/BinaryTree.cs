using System;

namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Cunstructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem , null, null);
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

            return getHeight(root) -1;
        }

        public int getHeight(BinaryNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(getHeight(node.left), + getHeight(node.right))+1;
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
            throw new System.NotImplementedException();
        }

        public string ToInfixString()
        {
            throw new System.NotImplementedException();
        }

        public string ToPostfixString()
        {
            throw new System.NotImplementedException();
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