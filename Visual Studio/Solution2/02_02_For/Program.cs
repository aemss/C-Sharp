
/*

// var i = 1;

// kontrol değişkeni
// kontrol
// güncellenmesi

for(var i = 1; i <= 10; i++) 
{ 
Console.WriteLine(i);
  //  i++;
}

*/

// var i = 1;
// var toplam = 0;

// for (i = 1; i <= 100; i++)
// {
//    if (i % 2 == 0)
//    {
//        toplam += i;
//    }

// }
// Console.WriteLine("Toplam: " + toplam);

// Console.Write("başlangıç:");
// var baslangic = Convert.ToInt32(Console.ReadLine());

// Console.Write("bitiş:");
// var bitis = Convert.ToInt32(Console.ReadLine());

// Console.Write("artış:");
// var artis = Convert.ToInt32(Console.ReadLine());

// var toplam = 0;
// for(var i = baslangic; i <= bitis; i += artis)
//    {
//   toplam += i;
// }
// Console.WriteLine("Toplam: " + toplam);

// string[] isimler = {
//    "Ali",
//    "Veli",
//    "Ayşe",
//    "Fatma",
//    "Mehmet"
// };

// for (var i = 0; i < isimler.Length; i++)  
// {
//    Console.WriteLine(isimler[i]);
// }

int[] sayilar = { 1, 3, 4, 36, 41, 56, 87 };

for(var i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 3 == 0)
    {
        Console.WriteLine(sayilar[i]);
    }
}


