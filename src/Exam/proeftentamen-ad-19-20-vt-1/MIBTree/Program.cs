using System;
using AD;

namespace MIBTree
{
    class Program
    {
        static void Main(string[] args)
        {
           BinarySearchTree<MIBNode> tree = new AD.MIBTree();
           Console.WriteLine(tree.ToString());
        }
    }
}
