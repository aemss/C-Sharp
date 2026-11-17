using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;
using System.Globalization;

namespace Apps;

class Program
{
    static void Main(string[] args)
    {
        var BST = new BST<int>(new int[] { 60,40,70,20,45,65,85});

        var bt = new BinaryTree<int>();

        bt.InOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        BST.Remove(BST.Root, 20);
        BST.Remove(BST.Root, 40);
        BST.Remove(BST.Root, 60);
        Console.WriteLine();
        bt.ClearList();

        bt.InOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        /*
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
        */

    }
}






