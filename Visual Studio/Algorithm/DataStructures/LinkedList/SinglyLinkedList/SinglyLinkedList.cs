using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList;


public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedListNode<T> Head { get; set; }
    private bool isHeadnull => Head == null;

    public void AddFirst(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        newNode.Next = Head;
        Head = newNode;
    }
    public void AddLast(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);

        if(isHeadnull)
        {
            Head = newNode;
            return;
        }

        var current = Head;
        while(current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode; 
    }
    public void AddAfter(SinglyLinkedListNode<T> node, T value)
    {
        if(node == null)
        {
            throw new ArgumentNullException("Node cannot be null");
        }

        if(isHeadnull)
        {
            AddFirst(value);
            return;
        }
        
        var newNode = new SinglyLinkedListNode<T>(value);
        var current = Head;


        while(current!= null)
        {
            if (current.Equals(node))
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                return;
            }
            current = current.Next;
        }
        throw new ArgumentException("Node not found in the list");
    }

    public void AddAfter(SinglyLinkedListNode<T> refNode, 
        SinglyLinkedListNode<T> newNode) 
    {
        if (refNode == null) throw new ArgumentNullException(nameof(refNode),"Referans düğüm boş olamaz.");
        if(newNode == null) throw new ArgumentNullException(nameof(newNode),"Eklenecek düğüm boş olamaz.");

        

        newNode.Next = refNode.Next;
        refNode.Next = newNode;
    } 

    public void AddBefore(SinglyLinkedListNode<T> node,T value)
    {
        if (node == null) throw new ArgumentNullException();
        if (isHeadnull) throw new InvalidOperationException();
    
        if(Head.Equals(node))
        {
            AddFirst(value);
            return;
        }

        var newNode = new SinglyLinkedListNode<T>(value);
        var current = Head;

        while(current.Next != null)
        {
            if(current.Next.Equals(node))
            {
                newNode.Next = current.Next;

                current.Next = newNode;
                return;
            }
        current = current.Next;

        }
    
        throw new ArgumentException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

