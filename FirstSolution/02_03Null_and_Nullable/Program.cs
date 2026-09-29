int? age = 22;         // integer tye 
var name = "Ali";     // string type

Console.WriteLine("age değişkeninin tipi " + age?GetType());
Console.WriteLine("name değişkeninin tipi " + name.GetType());

string? nullable = null;    // nullable string
Console.WriteLine("Büyük harf:" + nullable?.ToUpper());
Console.WriteLine("Kullanıcı adı:" + (nullable ?? "Bilinmiyor"));
Console.WriteLine("Yaş: " + (age ?? 0));



Console.ReadKey();

