
/*
string username = "aems";
string password = "ruhi123";


if (username != "aems")
{
    Console.WriteLine("Username yanlış.");
} else if (password != "ruhi123")

{
    Console.WriteLine("Password yanlış.");
    }
else
{
    Console.WriteLine("Merhaba BTK Akademi");
}

int x = 20;
int y = 20;

if (x > y)
{
    Console.WriteLine("x, y'den büyüktür.");
} 

else if (x == y)    
{
    Console.WriteLine("x, y'ye eşittir.");
}
else
{
    Console.WriteLine("x, y'den küçüktür.");
}

 */


/*

Console.WriteLine("Birinci sayıyı seçiniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı seçiniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlem seçiniz\\n1-Toplama\\n2-Çıkarma\\n3-Çarpma\\n4-Bölme");

var islem = Convert.ToInt32(Console.ReadLine());

if (islem == 1) 
{
    islem = (sayi1 + sayi2);
}
else if (islem == 2) 
{
  islem =  (sayi1 - sayi2);
}
else if (islem == 3) 
{
    islem = (sayi1 * sayi2);
}
else if (islem == 4) 
{
    islem = (sayi1 / sayi2);
}

Console.WriteLine($"İşlem sonucu: {islem}");

*/

Console.WriteLine("İlk yazılı sonucunuzu giriniz.");
var yazili1 = Convert.ToInt32(Console.ReadLine());
if (yazili1 > 100 || yazili1 < 0) 
{ Console.WriteLine("Geçersiz not girdiniz."); return; }


Console.WriteLine("İkinci yazılı sonucunuzu giriniz.");
var yazili2 = Convert.ToInt32(Console.ReadLine());
if (yazili2 > 100 || yazili2 < 0) 
{ Console.WriteLine("Geçersiz not girdiniz."); return; }

Console.WriteLine("Sözlü notunuzu giriniz.");
var sozlu = Convert.ToInt32(Console.ReadLine());
if (sozlu > 100 || sozlu < 0) 
{ Console.WriteLine("Geçersiz not girdiniz."); return; }

var ortalama = (yazili1 + yazili2 + sozlu) / 3;
Console.WriteLine($" Ortalamanız: {ortalama}");

if (ortalama >= 0 && ortalama <= 25) 
{
    Console.WriteLine("Notunuz: 1\n Derste kaldınız");
}
else if (ortalama >= 25 && ortalama <= 50)
{ Console.WriteLine("Notunuz: 2\n Derste kaldınız"); 
}
else if (ortalama >= 50 && ortalama <= 75)
{
    Console.WriteLine("Notunuz: 3\n Dersi geçtiniz.");
}
else if (ortalama >70 && ortalama <=85) { Console.WriteLine("Notunuz: 4\n Dersi geçtiniz."); }
else if (ortalama > 85 && ortalama <= 100) { Console.WriteLine("Notunuz: 5\n Dersi geçtiniz."); }

