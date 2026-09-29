
using System.Collections;

var arrayList = new ArrayList()
{
    1,2,3,4, "Enes",true, new DateTime()

};

int sum = 0;
foreach(var item in arrayList)
{
    if(item is int number)
    sum += number;

}



foreach(var item in arrayList)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Toplam: {sum}");


