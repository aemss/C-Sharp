/*

string message = "Merhaba ";
Console.WriteLine("İlk mesaj: " + message);

// immutable
string NewMessage = message + "Dünya";
Console.WriteLine("Yeni mesaj: " + NewMessage);
Console.WriteLine("Eski mesaj: " + message);


// Dizi benzer işler
Console.WriteLine("İlk karakter: " + message[0]);
Console.WriteLine("Son karakter: " + message[message.Length-2]);

// Döngüler char = tek karakter

Console.WriteLine("\nTüm karkaterler");
foreach (char c in message)
{
    Console.WriteLine(c);
}

// String metotları
Console.WriteLine("Karakter sayısı: " + message.Length);
Console.WriteLine("Büyük harf: " + message.ToUpper());
Console.WriteLine("Dünya içeriyor mu ? " + message.Contains("Dünya"));





string mesaj = "Ahmet Turan isimli kişi 20 yaşındadır.";

var adet = mesaj.Length;

var sonuc = mesaj.Substring(10);
var sonuc1 =  mesaj.ToLower();
var sonuc2 = mesaj.ToUpper();
var sonuc3 = mesaj.Trim();  // baştaki ve sondaki boşlukları siler
var sonuc4 = mesaj.Split(" ")[3];   //3. kelimeyi yazdırır
var sonuc5 = mesaj[3]; // 3. indexi yaz
var sonuc6 = mesaj.StartsWith("A");
var sonuc7 = mesaj.EndsWith(".");
var sonuc8 = mesaj.Contains("kişi");
var sonuc9 = mesaj.IndexOf("20");

Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);
Console.WriteLine(adet);
Console.WriteLine(sonuc4);
Console.WriteLine(sonuc5);
Console.WriteLine(sonuc6);
Console.WriteLine(sonuc7);
Console.WriteLine(sonuc9);




string kursAdi = ".NET 10  ile C# Programlama Dili";

var adet = kursAdi.Length;
var sonuc = kursAdi.ToLower();
var sonuc1 = kursAdi.StartsWith(".");
var sonuc2 = kursAdi.Contains("C#");
var sonuc3 = kursAdi.Replace("Dili", "Dersleri");
var konum = kursAdi.IndexOf("C#");


Console.WriteLine(sonuc1);
Console.WriteLine(sonuc);
Console.WriteLine(adet);
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);
Console.WriteLine(konum);
*/

var simdi = DateTime.Now;

Console.WriteLine(simdi);

DateTime dt = new DateTime(2018,6,10,14,30,45);
DateTime dt2 = dt.AddYears(1);



Console.WriteLine(dt2.Year);

var fark = simdi - dt2;

Console.WriteLine(fark.TotalDays);
Console.WriteLine(fark.TotalHours);

