using System;

int svaydaCani = 100;
int Attila = 100;
Random vurusGucu = new Random();
int raunt = 1;

Console.WriteLine("Svadya Şövalyesi ile karşılaştın!\n");

while (svaydaCani > 0 && Attila > 0)
{
    Console.WriteLine($"{raunt}. Raunt!");
    
    // Senin saldırın
    int oyuncuHasari = vurusGucu.Next(15, 36);
    svaydaCani -= oyuncuHasari;
    
    if (svaydaCani < 0) 
    {
        svaydaCani = 0;
    }
    
    Console.WriteLine($"Kılıcını savurdun! Vurulan Hasar: {oyuncuHasari} | Şövalyenin Kalan Canı: {svaydaCani}");

    // Şövalye ölmediyse karşı saldırı yapar
    if (svaydaCani > 0)
    {
        int sovalyeHasari = vurusGucu.Next(15, 30);
        Attila -= sovalyeHasari;
        
        if (Attila < 0) 
        {
            Attila = 0;
        }

        Console.WriteLine($"Şövalye karşılık verdi! Alınan Hasar: {sovalyeHasari} | Kalan Canın: {Attila}");
    }
    
    Console.WriteLine("--------------------------------------------------\n");
    raunt++;
}

// Kazananı belirleme
if (Attila <= 0)
{
    Console.WriteLine("Svadya Şövalyesi seni hakladı! Yenildin.");
}
else if (svaydaCani <= 0)
{
    Console.WriteLine("Svadya Şövalyesi devrildi! Zafer senin.");
}