
string ad = "Ahmet";

foreach(var harf in ad) 
{
    Console.WriteLine(harf);
}

int[] sayilar = {10,20, 30, 40};

foreach( var sayi in sayilar) 
{
    if (sayi == 20)
        continue;
    Console.WriteLine(sayi); 
}

