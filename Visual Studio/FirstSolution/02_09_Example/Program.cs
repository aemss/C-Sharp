
/*
// vize
Console.WriteLine("Vize notu giriniz: ");
int midterm = Convert.ToInt32(Console.ReadLine());

// final
Console.WriteLine("Final notu giriniz: ");
int FinalExam = Convert.ToInt32(Console.ReadLine());

// nihai not
var FinalGrade = (midterm * 0.4) + (FinalExam * 0.6);
Console.WriteLine($"Nihai notunuz:{FinalGrade}");

if (FinalGrade >= 50)
    Console.WriteLine("Geçtiniz.");
else
    Console.WriteLine("Kaldınız.");

Console.ReadKey();
*/

// Kur Bilgileri

using System.Globalization;

var dolarRate = 46.87m;
decimal euroRate = 53.72m;

DateTime dateRate = DateTime.Now;

Console.WriteLine("TL Miktarını Giriniz:");

decimal amountIntTL = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nDönüştürme Seçenekleri");
Console.WriteLine("1- Dolar");
Console.WriteLine("2- Euro");

Console.WriteLine("\nSeçminizi Yapınız. (1-2)");
int choice = Convert.ToInt32(Console.ReadLine());

decimal result = 0m;
string currencyName = "";





switch (choice)
{

    case 1:
        result = amountIntTL / dolarRate;
        currencyName = "USD";

        break;

    case 2:
        result = amountIntTL / euroRate;
        currencyName = "Euro";
        break;


    default:
        Console.WriteLine("Geçersiz Giriş.");
        return;      
}

Console.WriteLine($"Tarih: {dateRate}");
Console.WriteLine($"Girilen TL miktarı: {amountIntTL}");
Console.WriteLine($"Dönüştürülen miktar:{result:F2} {currencyName}");
Console.WriteLine("---Kurlar---");
Console.WriteLine($"Dolar : {dolarRate}");
Console.WriteLine($"Euro : {euroRate}");



Console.ReadKey();

