
int[] numbers = {5,10,15,-3,20,25 };


int i = 0;

while (i < numbers.Length && numbers[i] >= 0)
{

    // if (numbers[i] < 0)
    // {
    //    i++;      // sayacı artır
    //    continue;

    // d}
        Console.WriteLine($"Pozitif sayı: {numbers[i]}");
        i++;
    

}

Console.ReadKey();



