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

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
