using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;
using System.Globalization;

namespace Apps;

class Program
{
    static void Main(string[] args)
    {
        var BST = new BST<int>(new int[] { 23,16,45,3,22,37,99});

        var bt = new BinaryTree<int>();

        bt.PostOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        Console.WriteLine();

        bt.PostOrderNonRecursiveTraversal(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        Console.WriteLine();
        Console.WriteLine("\n=== Level Order Traversal===\n");

        bt.LevelOrderNonRecursiveTraversal(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        Console.WriteLine();

        Console.WriteLine($"Min: {BST.FindMin(BST.Root)}");
        Console.WriteLine($"Max: {BST.FindMax(BST.Root)}");

        var keyNode = BST.Find(BST.Root, 98);
        if(keyNode != null)
        {
            Console.WriteLine($"{keyNode.Value} - Left: " +
                $"{keyNode.Left.Value} -" +
                $" Right: {keyNode.Right}");
        }

    }
}





