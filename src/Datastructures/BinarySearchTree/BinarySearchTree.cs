using System;
using System.Reflection.Metadata.Ecma335;

namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {
        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            BinaryNode<T> newNode = new BinaryNode<T>(x, null, null);
            root = insert(root, newNode);
        }

        public BinaryNode<T> insert(BinaryNode<T> root, BinaryNode<T> newNode)
        {
            if (root == null)
            {
                return newNode;
            }

            if (Convert.ToInt32(newNode.data) < Convert.ToInt32(root.data))
            {
                root.left = insert(root.left, newNode);
                return root;
            }

            root.right = insert(root.right, newNode);
            return root;
        }

        public T FindMin()

        {
            if (root == null)
            {
                throw new BinarySearchTreeEmptyException();
            }
            return findmin(root);
        }

        public T findmin(BinaryNode<T> root)
        {
            if (root.left != null)
            {
                return findmin(root.left);
            }

            return root.data;
        }

        public void RemoveMin()
        {
            if (root == null)
            {
                throw new BinarySearchTreeEmptyException();
            }
            BinaryNode<T> newTreeRemovedMin = removeMin(root);
            root = newTreeRemovedMin;
        }

        public BinaryNode<T> removeMin(BinaryNode<T> root)
        {
            if (root.left != null)
            {
                return removeMin(root.left);
            }

            BinaryNode<T> newTree = root;
            newTree.data = default(T);
            return newTree;
        }

        public void Remove(T x)
        {
            throw new System.NotImplementedException();
        }

        public string InOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}