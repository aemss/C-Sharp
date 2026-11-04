using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.LinkedList.DoublyLinkedList;

public class DoublyLinkedList<T> : IEnumerable<T> 
{
    public DoublyLinkedListNode<T> Head { get; set; }
    public DoublyLinkedListNode<T> Tail { get; set; }
    private bool isHeadNull => Head == null;
    private bool isTailNull => Tail == null;

    public DoublyLinkedList()
    {
        
    }
    public DoublyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
            AddLast(item);
        
        
    }

    public void AddFirst(T value)
    {
        var newNode = new DoublyLinkedListNode<T>(value);
        if(Head != null)
        {
            Head.Prev = newNode;
        }
        newNode.Next = Head;
        newNode.Prev = null;
        Head = newNode;

        if (Tail == null)
            Tail = Head;

    }
    public void AddLast(T value)
    {
        if(Tail == null)
        {
            AddFirst(value);
            return;
        }
        var newNode = new DoublyLinkedListNode<T>(value);
        Tail.Next = newNode;
        newNode.Next = null;
        newNode.Prev = Tail;
        Tail = newNode;
        return;

    
    }
    public void AddAfter(DoublyLinkedListNode<T> refNode,
        DoublyLinkedListNode<T> newNode)
    {
        if (refNode == null)
            throw new ArgumentNullException();
        
        if(refNode == Head && refNode== Tail)
        {
            refNode.Next = newNode;
            refNode.Prev = null;

            newNode.Prev = refNode;
            newNode.Next = null;

            Head = refNode;
            Tail = newNode;
            return;
        }
        if(refNode != Tail)
        {
            newNode.Prev = refNode;
            newNode.Next = refNode.Next;

            refNode.Next.Prev = newNode;
            refNode.Next = newNode;
        } 
        else
        {
            newNode.Prev = refNode;
            newNode.Next = null;

            refNode.Next = newNode;
            Tail = newNode;
        }
    
    }
    public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
    {
        if (refNode == Head)
        {
            newNode.Next = Head;
            newNode.Prev = null;
            Head.Prev = newNode;
            Head = newNode;
            return;
        }
        newNode.Next = refNode;
        newNode.Prev = refNode.Prev;
        refNode.Prev = newNode;
        newNode.Prev.Next = newNode;

    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Head;
        while(current != null)
        {
            yield return current.Value;
            current = current.Next;
        }

        //return GetAllNodes().GetEnumerator();

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private List<DoublyLinkedListNode<T>> GetAllNodes()
    {
        var list =new List<DoublyLinkedListNode<T>>();
        var current = Head;
        while(current != null)
        {
            list.Add(current);
            current = current.Next;
        }
        return list;
    }

    public T RemoveFirst()
    {
        if (isHeadNull)
            throw new Exception();

        var temp = Head.Value;
        if(Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Prev = null;

        }
         
        return temp;

        
    }
    public T RemoveLast()
    {
        if (isTailNull)
            throw new Exception();

        var temp = Tail.Value;
        if(Tail== Head)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Tail.Prev.Next = null;
            Tail = Tail.Prev;
        }
        return temp;
    }
    public void Remove(T value)
    {
        if (isHeadNull)
            throw new Exception();

        if(Head== Tail)
        {
            if (Head.Value.Equals(value))
                RemoveFirst();
        }

        var current = Head;

        while (current!= null)
        {
            if (current.Value.Equals(value))
            {
                // current -> İlk eleman
                if(current.Prev == null)
                {
                    current.Next.Prev = null;
                    Head = current.Next;
                }
                // current -> son eleman
                else if(current.Next == null)
                {
                    current.Prev.Next = null;
                    Tail = current.Prev;
                }
                //current -> arada bir pozisyonda
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
                break;
            }
            current = current.Next;

        }
    }
    

}
