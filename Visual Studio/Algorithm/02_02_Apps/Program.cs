
using DataStructures;
using System.Collections;
using System.Collections.Generic;
void Entering() 
{
    char[] arrChar = new char[] {'b','t','k' };
 
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



var arr = new DataStructures.Array.Array<int>();

arr.Add(23); 
arr.Add(24); 
arr.Add(25); 
Console.WriteLine($"{arr.Count} / {arr.Capacity}");



