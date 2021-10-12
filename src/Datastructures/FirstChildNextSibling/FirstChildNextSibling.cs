using System;
using System.Text;

namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FirstChildNextSiblingNode<T> root;

        public IFirstChildNextSiblingNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            return size(root);
        }

        public int size(FirstChildNextSiblingNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + size(node.GetFirstChild()) + size(node.GetNextSibling());
        }

        public void PrintPreOrder()
        {
            print(root, 0);
        }

        public void print(FirstChildNextSiblingNode<T> node, int depth)
        {
            if (node == null)
            {
                return;
            } 
            
            Console.WriteLine(new string(' ', depth) + node.data);
            
            if (node.firstChild != null)
            {
                print(node.firstChild, depth + 1);
            }

            if (node.nextSibling != null)
            {
                print(node.nextSibling, depth);
            }
        }

        public override string ToString()
        {
            if (root == null)
            {
                return "NIL";
            }

            return root.ToString();
        }
    }
}