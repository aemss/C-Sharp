
using _01_05_RefVal;
using RefVal;

Console.WriteLine("===Değer ve Referans Tip Farkı===");
var v1 = new ValPoint(10, 20);
var v2 = v1;   // değer tipli direk kopyalama!  

v2.X = 50;
Console.WriteLine(v1);
Console.WriteLine(v2);

var r1 = new RefPoint(10, 20);
var r2 = r1;
r2.X = 50;

Console.WriteLine(r1);
Console.WriteLine(r2);
