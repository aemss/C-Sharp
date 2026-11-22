using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;
using System.Globalization;

namespace Apps;

/*
var BST = new BST<int>(new int[] { 60, 40, 70, 20, 45, 65, 85 });

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
*/
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



var bst = new DataStructures
    .Tree
    .BST
    .BST<byte>(new byte[] { 60,40,70 });

var list = new BinaryTree<byte>().InOrder(bst.Root);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Min: {bst.FindMin(bst.Root)}");
Console.WriteLine($"Max: {bst.FindMax(bst.Root)}");
Console.WriteLine($"Depth: {BinaryTree<byte>.MaxDepth(bst.Root)}");
  */
/*
var bt = new BinaryTree<char>();
bt.Root = new Node<char>('F');
bt.Root.Left = new Node<char>('A');
bt.Root.Right = new Node<char>('T');
bt.Root.Left.Left = new Node<char>('D');

var list = bt.LevelOrderNonRecursiveTraversal(bt.Root);
foreach (var item in list)
{
    Console.WriteLine($"{item.Value} ");
}

Console.WriteLine($"Deepest Node:{bt.DeepestNode(bt.Root).Value}");
Console.WriteLine($"Deepest Node:{bt.DeepestNode()}");
Console.WriteLine($"Max Depth:{BinaryTree<char>.MaxDepth(bt.Root)}");

*/
/*
        var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
        var bt = new BinaryTree<int>();
        bst.Remove(bst.Root,3);
        bst.Remove(bst.Root, 99);


        Console.WriteLine($"Number of leafs: " +
            $"{bt.NumberOFleafs(bst.Root)}");

        Console.WriteLine($"Number of fll nodes :" +
            $"{BinaryTree<int>.NumberOfFullNodes(bst.Root)}");


        Console.WriteLine($"Number of fll nodes :" +
            $"{BinaryTree<int>.NumberOFHalfNodes(bst.Root)}");
        */
class Program
{
    static void Main(string[] args)
    {
        var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99,100,120,130 });
        bst.Remove(bst.Root, 22);
        new BinaryTree<int>().PrintPaths(bst.Root);



    }
}
