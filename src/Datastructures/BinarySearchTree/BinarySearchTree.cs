using System;

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

            if (newNode.data.CompareTo(root.data) < 0)
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

            if (root.left == null)
            {
                root = null;
                return;
            }

            removeMin(root, root);
        }

        public void removeMin(BinaryNode<T> rootLeft, BinaryNode<T> parentNode)
        {
            if (rootLeft.left == null)
            {
                if (rootLeft.right != null)
                {
                    parentNode.left = rootLeft.right;
                }
                else
                {
                    parentNode.left = null;
                }

                return;
            }

            removeMin(rootLeft.left, rootLeft);
        }


        public void Remove(T x)
        {
            if (root == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }

            root = remove(root, x);
        }

        public BinaryNode<T> remove(BinaryNode<T> root, T removeValue)
        {
            if (root == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }
            
            if (removeValue.CompareTo(root.data) < 0)
            {
                root.left = remove(root.left, removeValue);
            }
            else if (removeValue.CompareTo(root.data) > 0)
            {
                root.right = remove(root.right, removeValue);
            }
            else if (removeValue.CompareTo(root.data) == 0)
            {
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                root.data = findmin(root.right);
                
                root.right = remove(root.right, root.data);
            }

            return root;
        }


        public string InOrder()
        {
            return inorder(root).Trim();
        }

        public string inorder(BinaryNode<T> root)
        {
            if (root == null)
            {
                return "";
            }

            string toReturn = "";
            toReturn += inorder(root.GetLeft()) + root.GetData() + " " + inorder(root.GetRight());
            return toReturn;
        }

        public override string ToString()
        {
            return InOrder();
        }
    }
}