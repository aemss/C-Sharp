/*

var kursAdi = ".net 10 ile C# programlama dersleri".Split(" ");

// string[] isimler = new string[5];

// isimler[0] = "Ahmet";
// isimler[1] = "Ali";
// isimler[2] = "Mehmet";
// isimler[3] = "Fahreddin";
// isimler[4] = "Fedarettin";

string[] isimler = {"Ahmet","Ali","Mehmet","Fahreddin","Fedarettin"};



// int[] numaralar = new int[5];

// numaralar[0] = 100;
// numaralar[1] = 200;
// numaralar[2] = 300;
// numaralar[3] = 400;
// numaralar[4] = 500;

int[] numaralar = { 100, 200, 300, 400, 500 };



Console.WriteLine(kursAdi[0]);
Console.WriteLine(isimler[4]);
Console.WriteLine($"{numaralar[4]} numaralı öğrencinin adı {isimler[0]} ");



using System.Security.Principal;

string[] sehirler = { "İstanbul", "rize", "kocaeli" };
int[] plakalar = {34, 53, 41 };


// sehirler[0] = "sakarya";
sehirler.SetValue("sakarya", 0);  
 


Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler, "rize"));

Array.Sort(sehirler);
Array.Sort(plakalar);

Array.Reverse(plakalar);
// Array.Clear(sehirler);
Array.Clear(plakalar,0,1);


Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2));



foreach(var sehir in sehirler[2..3]) 
{
    Console.WriteLine(sehir);
}

string sehir1 = "Yalova";

Console.WriteLine(sehir1[..5]);


// Console.WriteLine(sonuc.Length);
// Console.WriteLine(sonuc[2]);


string[] ogrenciler = {"Ali", "Veli", "Ayşe" };

int[,] notlar = new int[3, 3];

// Ali

notlar[0, 0] = 50;
notlar[0, 1] = 60;
notlar[0, 2] = 70;

// Veli

notlar[1, 0] = 60;
notlar[1, 1] = 80;
notlar[1, 2] = 90;

// Ayşe

notlar[2, 0] = 20;
notlar[2, 1] = 70;
notlar[2, 2] = 80;

var ortalama_1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
var ortalama_2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
int ortalama_3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;

Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");



int[] x = { 10,20,};
int[] y = x;

Console.WriteLine(x[0]);
Console.WriteLine(y[0]);

x[0] = 20;


Console.WriteLine(x[0]);
Console.WriteLine(y[0]);

*/









