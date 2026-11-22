using DataStructures.Tree.BinaryTree;
using System.Collections;

namespace DataStructures.Tree.BST;

internal class BSTEnumerator<T> : IEnumerator<T> where T : IComparable<T>
{
    private List<Node<T>> list;
    private int indexer = -1;

    public BSTEnumerator(Node<T> root)
    {
        list = new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root);
    }
    public T Current => throw new NotImplementedException();

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}