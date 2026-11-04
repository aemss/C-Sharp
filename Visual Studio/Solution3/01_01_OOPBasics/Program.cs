using _01_01_OOPBasics;

/*
Number number = new Number();   // Referans | Pyhsical
number.SingleNumber = 5;
number.Description = "Numaralar üzerinde işler yapmak üzere tasarlanmış sınıfımızdır.";
number.Count = 0;

var number2 = new Number()
{
    SingleNumber = 20,
    Description = "20 sayısını ele alacağım.",
    Count = 100

};

var number3 = new Number(55,"55 sayısını dikkate al.");


Console.WriteLine($"Number: {number.SingleNumber}");
Console.WriteLine($"Count: {number.Count}");


Console.WriteLine($"Number: {number2.SingleNumber}");
Console.WriteLine($"Count: {number2.Count}");

Console.WriteLine($"Number: {number3.SingleNumber}");
Console.WriteLine($"Count: {number3.Count}");


Console.ReadKey();

*/

int[] oddNumbers = { 11, 3, 5, 7, 11, 9 };
int[] evenNumbers = {20,40,16,8,56,60 };

var number = new Number(evenNumbers);
// var min = number.FindMin();
// var max = number.FindMax();
var indis = number.Find(50);

Console.WriteLine($"Minimum değer: {number.Min}");
Console.WriteLine($"Maximum değer: {number.Max}");
Console.WriteLine($"Aranan değerin indis numarası: {indis}");



