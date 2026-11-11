using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;

namespace Apps;

class Program
{
    static void Main(string[] args)
    {
        var BST = new BST<int>(new int[] { 23,16,45,3,22,37,99});

        var bt = new BinaryTree<int>();

        bt.InOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        Console.WriteLine();
        // foreach (var item in list)
        // {
        //    Console.WriteLine(item);
        // }
        bt.ClearList();     

        bt.PreOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

        Console.WriteLine();
        bt.ClearList();

        bt.PostOrder(BST.Root)
            .ForEach(node => Console.Write($"{node,-3} "));

    }
}




