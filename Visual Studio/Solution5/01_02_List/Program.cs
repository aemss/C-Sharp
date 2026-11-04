/*
var numbers = new List<int>()
{ 
    10,20,30,40,50,60
};

numbers.Add(-5);
numbers.AddRange(new int[] { -5, -3, 5, 10, 213 });

int sum = 0;

foreach(var number in numbers)
{
    sum += number;
    Console.WriteLine(number);

}

Console.WriteLine($"Toplam : {sum}");

*/

using List;

var manager = new CityManager();

manager.AddCity(34,"İstanbul");
manager.AddCity(6,"Ankara");
manager.AddCity(77,"Yalova");
manager.AddCity(55, "Samsun");

manager.PrintAllCities();


