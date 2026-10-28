
using DataStructures;
using DataStructures.LinkedList.SinglyLinkedList;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Apps;


class Program
{
    private static void SinglyLinkedListApp01()
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddFirst(2);
        linkedList.AddFirst(3);

        Console.WriteLine();

        linkedList.AddLast(4);
        linkedList.AddLast(5);
        //  3,2,1,4,5 O(n)

        linkedList.AddAfter(linkedList.Head.Next, 32);
        linkedList.AddAfter(linkedList.Head.Next.Next, 33);
        //  3,2,32,1,4,5 O(n)

        foreach (var item in linkedList)
            Console.WriteLine(item);

        Console.ReadKey();
    }
    private static void SinglyLinkedListApp02()
    {
        var arr = new char[] { 'a', 'b', 'c', };
        var list = new List<char>(arr);
        var clinkedList = new LinkedList<char>(arr);
        list.AddRange(new char[] { 'd', 'e', 'f' });

        var linkedList = new SinglyLinkedList<char>(list);

        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }

        var charset = new List<char>(linkedList);
        Console.WriteLine();

        foreach (var item in charset)
        {
            Console.Write(item + " ");
        }
    }
    private static void SinglyLinkedListApp03()
    {
        var rnd = new Random();
        var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
        var linkedList = new SinglyLinkedList<int>(initial);

        var q = from item in linkedList
                where item % 2 == 1
                select item;

        Console.WriteLine();

        linkedList.Where(x => x > 5)
            .ToList()
            .ForEach(x => Console.Write(x + " "));
    }
    
    static void Main(string[] args)
    {
        var rnd = new Random();
        var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
        var list = new LinkedList<int>(initial);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.RemoveFirst();

        list.RemoveLast();
        

        Console.WriteLine();
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

}




public class Arrays()
{
    public static void Entering()
    {
        char[] arrChar = new char[] { 'b', 't', 'k' };

        // Array

        var arrInt = Array.CreateInstance(typeof(int), 3);
        arrInt.SetValue(10, 0); // arrInt[0] = 10
        arrInt.GetValue(0); // 10

        Console.WriteLine(arrChar.Length);
        //Array Object

        var arrObj = new ArrayList();
        arrObj.Add(10);
        arrObj.Add('b');

        var arrint = new List<int>();
        arrint.Add(10);
        arrint.Add((int)'b');
        arrint.AddRange(new int[] { 20, 30 });
        arrint.RemoveAt(1);

        Console.WriteLine(arrint.Count);

        Console.WriteLine();
        foreach (var item in arrint)
        {
            Console.WriteLine(item);
        }
    }
    public static void ArrayStructure()
    {
        var arr = new DataStructures.Array.Array<int>();

        arr.Add(23);
        arr.Add(24);
        arr.Add(25);
        arr.Add(26);
        arr.Add(37);

        arr.Remove();

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----");

        arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));


        Console.WriteLine($"{arr.Count} / {arr.Capacity}");
    }

    public static void Example()
    {
        var p1 = new DataStructures.Array.Array<int>(1, 2, 3, 4);
        var p2 = new int[] { 5, 6, 7, 8 };
        var p3 = new List<int>() { 15, 12, 82, 12, 21 };
        var p4 = new ArrayList() { 46, 32, 75, 34 };

        var arr = new DataStructures.Array.Array<int>(p1); // bir tek p4 kullanılamaz
                                                           // tip güvenliğini korumadığı için.

        foreach (var item in arr)
            Console.WriteLine(item);

    }
    public static void SimulateArrayResizing()
    {
        var arr = new DataStructures.Array.Array<int>();

        for (int i = 0; i < 128; i++)
        {
            arr.Add(i + 1);
            Console.WriteLine($"{i} has been added to array.");
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }
        Console.WriteLine();

        for (int i = arr.Count; i >= 1; i--)
        {
            Console.WriteLine($"{arr.Remove()} has been removed from the array.");
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }

        Console.WriteLine();
        foreach (var item in arr)
            Console.WriteLine(item);
    }

    public static void Clone()
    {
        var arr = new DataStructures.Array.Array<int>(1, 3, 5, 7);
        //var crr = (DataStructures.Array.Array<int>)arr.Clone();
        var crr = arr.Clone() as DataStructures.Array.Array<int>;

        crr.Add(1);

        arr.Add(99);

        foreach (var item in arr)
        {
            Console.Write($"{item,-3}");
        }
        Console.WriteLine($"{arr.Count} / {arr.Capacity}");

        Console.WriteLine();
        foreach (var item in crr)
        {
            Console.Write($"{item,-3}");
        }
        Console.WriteLine($"{crr.Count} / {crr.Capacity}");


    }
    public static void HomeWork()
    {
        var arr = new DataStructures.Array.Array<int>(1, 3, 5, 7);
        var list = new List<int>() { 13, 15, 17, 19 };

        arr.RemoveAt(2);
        list.RemoveAt(3);

        foreach (var item in arr)
            Console.WriteLine(item);
        Console.WriteLine();
        foreach (var item in list)
            Console.WriteLine(item);
    }

}






