using DataStructures.LinkedList.SinglyLinkedList;

namespace DataStructures.Stack;

public class LinkedListStack<T> : IStack<T>
{
    private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
    public int Count { get; private set;}

    public T Peek()
    {
        if (Count == 0) throw new Exception();
        return list.Head.Value;
    }

    public T Pop()
    {
        if (Count == 0) throw new Exception();
        var temp = list.RemoveFirst();
        Count--;
        return temp;
    }

    public void Push(T value)
    {
        if(value == null) throw new ArgumentNullException("value");

        list.AddFirst(value);
        Count++;
    }
}