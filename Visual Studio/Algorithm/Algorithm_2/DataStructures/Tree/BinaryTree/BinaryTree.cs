using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinaryTree;

public class BinaryTree<T> where T : IComparable
{
    public List<Node<T>> list { get; private set;}
    public BinaryTree()
    {
        list = new List<Node<T>>();
    }

    public List<Node<T>> InOrder(Node<T> root)
    {
        if (!(root == null))
        {
            InOrder(root.Left);
            list.Add(root);
            InOrder(root.Right);
        }
        return list;
    } 
    public List<Node<T>> PreOrder(Node<T> root)
    {
        if(!(root==null))
        {
            list.Add(root);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
        return list;

    }
    public List<Node<T>> PostOrder(Node<T> root)
    {
        if(!(root == null ))
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            list.Add(root);
        }
        return list;
    }
    public void ClearList() => list.Clear();
}

