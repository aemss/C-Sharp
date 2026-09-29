
// Örnek
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

string product = "USB-C Cable";
int quantity = 3;
decimal unitPrice = 149.90m;
var now = DateTime.Now;

// Fiş | Farklı Kültürlere Duyarlı
PrintReceipt(product, 
    quantity, 
    unitPrice,
    now,
    new CultureInfo("tr-TR"),
    "TR (tr-TR)");

PrintReceipt(product,
    quantity,
    unitPrice,
    now,
    new CultureInfo("en-US"),
    "\nEN (en-US)");

void PrintReceipt(string product,
    int quantity,
    decimal unitPrice,
    DateTime when,
    CultureInfo ci,
    string title)
{
    // Total
    decimal total = unitPrice * quantity;
    // Başlık
    Console.WriteLine(title);
    Console.WriteLine(new String('=', title.Length));
    // Tarih ve saat
    Console.WriteLine($"Date: {when.ToString("d",ci)}"+
        $" Time:{when.ToString("t",ci)}");

    // Tablo başlığı
    Console.WriteLine($"\n {"Product",-20}" +
        $"{"Quantity", 5}" + 
        $"{"Unit",12}" +
        $"{"Total",12}"
        );
    Console.WriteLine(new string('-',20+5+24+5));

    Console.WriteLine($"\n {product,-20}" +
        $"{quantity,5:N0}" +
        $"{unitPrice.ToString("C2",ci),12}" +
        $"{total.ToString("C2", ci),12}"
        );

}


Console.ReadKey();

