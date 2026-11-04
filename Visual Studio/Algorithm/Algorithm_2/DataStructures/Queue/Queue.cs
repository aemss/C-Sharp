using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue;

public class Queue<T>
{
    private readonly IQueue<T> queue;
    public int Count => queue.Count;
    public Queue(QueueType type = QueueType.Array)
    {
        if(type == QueueType.Array)
        {
            queue = new ArrayQueue<T>();
        }
        else
        {
            queue = new LinkedListQueue<T>();
        }

    }
    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }
    public T Dequeue()
    {
        return queue.Dequeue();
    }
    public T Peek()
    {
        return queue.Dequeue();
    }

}

public interface IQueue<T>
{
    int Count { get; }
    void Enqueue(T item);
    T Dequeue();
    T Peek();
}

public enum QueueType
{
    Array = 0, // List<T>
    LinkedList = 1 // DoublyLinkedList<T>
}
