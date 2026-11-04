
int[] numbers = { 10, 20, 30, 40, 50 };

int sum = 0;

foreach (var number in numbers)
{
    // her adımda ekleme yapma
    sum += number;
    
}


// ortalama hesabı

double average = (double)sum / numbers.Length;

// Sonuç yazdır

Console.WriteLine($"Ortalama: {average:F2}");

Console.ReadKey();

