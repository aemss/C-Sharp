



using System.Data;

Console.WriteLine("Adınızı giriniz:");
string FirstName = Console.ReadLine();

Console.WriteLine("Soyadınızı giriniz:");
string LastName = Console.ReadLine();

// + operatörü
string welcome1 = "Merhaba " + FirstName + " " + LastName + ", " + "Sisteme hoşgeldiniz.";

// Concat
string welcome2 = string.Concat("Sayın ",
    FirstName,"" +
    " ", LastName, 
    ",girişinizi başarı ile gerçekleştirdiniz.");

// Interpolasyon
string welcome3 = $"Hoş Geldiniz: {FirstName} {LastName?.ToUpper()} {DateTime.Now:dd.MM.yyyy}";

Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.WriteLine(welcome3);
