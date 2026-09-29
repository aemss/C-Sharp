
/*
var a = 10;
var b = 3;
var c = 2;

var sonuc = a + b;
var sonuc1 = a - b;
var sonuc2 = a * b;
var sonuc3 = (float)a / (float)b;
var sonuc4 = (a + b) * c;
var sonuc5 = a % b;
var sonuc6 = ++a;

Console.WriteLine("a + b = " + sonuc);
Console.WriteLine("a - b = " + sonuc1);
Console.WriteLine("a * b = " + sonuc2);
Console.WriteLine("a / b = " + sonuc3);
Console.WriteLine("(a + b) * c = " + sonuc4);
Console.WriteLine("a % b = " + sonuc5);
Console.WriteLine(sonuc6);




var a = 10;
var b = 5;
var c = 20;

var sonuc = (c - b) * b;
int? d = null;
int? e = 20;

var sonuc1 = (d ?? 0) + e;

a = b--;

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("(c-b) * b = " + sonuc);
Console.WriteLine("d + e = " + sonuc1);

Console.WriteLine("sayı: ");
int sayi = int.Parse(Console.ReadLine() ?? "0");
var sonuc2 = sayi % 2;

Console.WriteLine(sonuc2);

if (sonuc2 == 1)
    Console.WriteLine("Sayı Tek");
else
    Console.WriteLine("Sayı Çift");



var a = -5;
var b = 10;

double sonuc;

sonuc = Math.Pow(2, 3);  //2'nin kübü (kare alma)
var sonuc1 = Math.Sqrt(16);  //16'nın karekökü
int sonuc2 = Math.Abs(a);
double sonuc3 = Math.Round(4.6);
double sonuc4 = Math.Ceiling(4.1);
double sonuc5 = Math.Floor(4.9);

Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);
Console.WriteLine(sonuc4);



Console.Write("Yaşınızı Giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());


var sonuc1 = (yas >= 18) ? "Ehliyet alabilir" : "Ehliyet alamaz";
var sonuc = yas % 2;

Console.WriteLine(sonuc1);

var sonuc2 = (yas > 0) ? "sayı pozitif" : "sayı negatif";

Console.WriteLine(sonuc2);


var sonuc3 = yas % 2 == 0 ? "Yaşınız Çift Sayıdır." : "Yaşınız Tek Sayıdır.";

Console.WriteLine(sonuc3);

if (sonuc == 0)
Console.WriteLine("Yaşınız Çift Sayıdır.");
else
Console.WriteLine("Yaşınız Tek Sayıdır.");

 

var a = true;
var b = true;
var c = false;
var d = false;

// 1- ve -- &&
var sonuc = a && b;
var sonuc1 = a && c;

Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);

// 2 - veya -- ||

var sonuc2 = a || c;
var sonuc3 = d || c;

Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);

// 3 - değil -- !
var sonuc4 = a != c;
var sonuc5 = d != c;

sonuc5 = !c;

Console.WriteLine(sonuc4);
Console.WriteLine(sonuc5);



int yas = 17;
bool veli_izni = true;


bool yas_kontrol = (yas >= 18) ? true : false;
bool veli_kontrol = (veli_izni);

var sonuc = (yas_kontrol) || (veli_kontrol) ? "Bir işte Çalışabilir" : "Bir işte Çalışamaz";

Console.WriteLine(sonuc);





Console.WriteLine("Notunuzu Giriniz:");
int ortalama = Convert.ToInt32(Console.ReadLine());

bool kosul1 = (ortalama >= 50) ? true : false;
bool kosul2 = (ortalama <= 100) ? true : false;

var sonuc1 = (kosul1 && kosul2) ? "Geçti" : "Kaldı";

Console.WriteLine(sonuc1);



Console.WriteLine("Zayıf Not Sayısı Giriniz:");
int zayif = Convert.ToInt32(Console.ReadLine());

var sonuc = (ortalama >= 70) ?
                ((zayif == 0) ? "Teşekkür Belgesi alınabilir" : "zayıfınız olmaması gerekiyor.") :
                "notunuz en az 70 olmalıdır.";



Console.WriteLine(sonuc);
 

Console.WriteLine("Eğitim durumunuzu giriniz (lisans / önlisans) :");

string? egitim = Convert.ToString(Console.ReadLine());

Console.WriteLine("Sigara içiyor musunuz? (true/false)");
bool sigara_icme = Convert.ToBoolean(Console.ReadLine());


var sonuc = ((egitim == "lisans" || egitim == "önlisans" )  && !sigara_icme) ? "İşe girebilir": "İşe giremez";

Console.WriteLine(sonuc);

*/

string email = "crazyboy_aykut@gmail.com";
string username = "crazy";
string password = "12345";

var sonuc = ((email == "crazyboy_aykut@gmail.com" || username == "crazy" ) &&  (password == "12345")) ? "Giriş başarılı" : "Giriş başarısız";

Console.WriteLine(sonuc);







