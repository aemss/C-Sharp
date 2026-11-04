using System;
using System.Collections.Generic;
using System.Text;

namespace Generic;

public class GenericReposity<T>
{
    private readonly List<T> items;
    public GenericReposity()
    {
        items = new List<T>();

    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    public void PrintWithMessage<U>(U message)
    {
        Console.WriteLine("Mesaj : " + message);
        PrintAll();
    }



}
