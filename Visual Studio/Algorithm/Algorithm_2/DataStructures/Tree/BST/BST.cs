using DataStructures.Tree.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BST;

public class BST<T> : IEnumerable<T>
    where T : IComparable<T>
{
    public Node<T> Root { get; set; }
    public BST()
    {
        
    }
    public BST(IEnumerable<T> collection)
    {
        foreach (var item in collection)
            Add(item);
        
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T value)
    {
        if (value == null) throw new ArgumentNullException();
        var newNode = new Node<T>(value);
        if(Root == null) 
            Root = newNode;
        else
        {
            var current = Root;
            Node<T> parent;
            while(true)
            {
                parent = current;
                // Sol-alt ağaç
                if(value.CompareTo(current.Value)<0)
                {
                    current = current.Left;
                    if(current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                // Sağ-alt ağac
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        }
    }
    public Node<T> FindMin(Node<T> root)
    {
        var current = root;
        while(!(current.Left==null))
            current = current.Left;
        
        return current;
    }
    public Node<T> FindMax(Node<T> root)
    {
        var current = root;
        while(!(current.Right==null))
            current = current.Right;

        return current;
    }

    public Node<T> Find(Node<T> root, T key)
    {
        var current = root;
        while(key.CompareTo(current.Value)!= 0)
        {
            if (key.CompareTo(current.Value) < 0)
                current = current.Left;
            else
                current = current.Right;

            if (current == null)
                //throw new Exception("Could not found!");
                return default(Node<T>);
        }
        return current;
            
    }

}

