using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack;

public class Stack<T>
{
    private readonly IStack<T> stack;
    public int Count => stack.Count;
}

public interface IStack<T>
{
    int Count { get; }
    void Push(T item);
    T Peek();
    T Pop();
}

public enum StackType
{
    Array = 0, //  List<T>
    LinkedList = 1 // SinglyLinkedList<T>

}

  