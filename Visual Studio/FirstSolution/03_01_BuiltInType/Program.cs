// Kur bilgileri ve tarih

var dollarRate = 46.87m;
decimal euroRate = 53.72m;
var goldRate = 7500m;
DateTime rateDate = DateTime.Now;

Console.WriteLine("TL miktarını giriniz");
decimal amountInTL = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine(dollarRate.GetType());

Console.WriteLine("\nDönüştürme Seçenekleri");
Console.WriteLine("1- Dolar");
Console.WriteLine("2- Euro");
Console.WriteLine("3- Altın");

Console.WriteLine("\nSeçiminizi yapınız. (1-3)");
int choice = Convert.ToInt32(Console.ReadLine());

decimal result = 0m;
string currenyName = "";

switch (choice)
{
	case 1:
		result = amountInTL / dollarRate;
		currenyName = "USD";
		break;
	case 2:
		result = amountInTL / euroRate;
		currenyName = "Euro";
		break;
	case 3:
		result = amountInTL / goldRate;
		currenyName = "Gold";
		break;
	default:
        Console.WriteLine("Geçersiz Giriş!");
        return;
}

Console.WriteLine($"\nTarih:{rateDate} ");
Console.WriteLine($"Girilen TL miktarı: {amountInTL} TL");
Console.WriteLine($"Dönüşüm sonucu: {result:F2} {currenyName}");
Console.WriteLine("---Kurlar---");
Console.WriteLine($"Dolar : {dollarRate} TL");
Console.WriteLine($"Euro : {euroRate} TL");
Console.WriteLine($"Altın : {goldRate} TL");

Console.ReadKey();
 