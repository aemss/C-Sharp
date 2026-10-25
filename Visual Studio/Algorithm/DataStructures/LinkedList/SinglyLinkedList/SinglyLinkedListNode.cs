using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList;

public class SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode<T> Next { get; set; }
    public T Value { get; set; }

    public SinglyLinkedListNode(T value)
    {
        Value = value; 
    }

    override public string ToString() => $"{Value}"; // => return'un yerini alan
                                                     //    lambda ifadesi
    
    
}
