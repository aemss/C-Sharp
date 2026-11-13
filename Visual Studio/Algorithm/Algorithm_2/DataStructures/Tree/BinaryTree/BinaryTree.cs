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
    public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
    {
        var list = new List<Node<T>>();
        var S = new DataStructures.Stack.Stack<Node<T>>();
        Node<T> currentNode = root;
        bool done = false;
        while(!done)
        {
            if(currentNode!= null)
            {
                S.Push(currentNode);
                currentNode = currentNode.Left;
            }
            else
            {
                if(S.Count== 0)
                {
                    done = true;
                }
                else
                {
                    currentNode = S.Pop();
                    list.Add(currentNode);
                    currentNode = currentNode.Right;
                }
            }
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

