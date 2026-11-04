
//var i = 0;

//while(i < 10) 
//{
//    Console.WriteLine(i);
//    i++;
//}

//string[] isimler = { "Ali", "Veli", "Mehmet", "Ahmet" };

//var i = 0;
//while(i < isimler.Length)
//{
//    Console.WriteLine(isimler[i]);
//    i++;
//}

 var secim = "e";
 var sayac = 1;
 var toplam = 0;
while(secim == "e") 
 {
    Console.WriteLine($"{sayac}. sayı:");
    toplam += Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Devam etmek istiyor musunuz (e/h)?");
    secim = Console.ReadLine();
    sayac++;
 } 

 Console.WriteLine($"{sayac-1} adet sayının toplamı: {toplam}");

