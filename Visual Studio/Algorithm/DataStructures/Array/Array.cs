using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array;

public class Array<T> : IEnumerable<T>, ICloneable
{
    private T[] InnerList;
    public int Count{ get; private set; }
    public int Capacity => InnerList.Length;


    public Array()
    {
        InnerList = new T[2];
        Count = 0;
    }

    public void Add(T item)
    {
        InnerList[Count] = item;
        Count++;
    }

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
