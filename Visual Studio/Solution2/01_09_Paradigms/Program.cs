
int[] oddNumbers = {11,3 , 5, 7, 11, 9  };
int[] evenNumbers = { 20, 40, 16, 8, 56, 60};



Console.WriteLine($"Tek sayı dizisindeki min: {FindMin(oddNumbers)}");

Console.WriteLine($"Çift sayı dizisindeki min: {FindMin(evenNumbers)}");

Console.WriteLine($"Tek sayı dizisindeki max: {FindMax(oddNumbers)}");

Console.WriteLine($"Tek sayı dizisindeki aranan elamanın indis değeri: {Find(oddNumbers,7)}");

Console.WriteLine($"Çift sayı dizisindeki aranan elamanın indis değeri: {Find(evenNumbers, 50)}");

Console.WriteLine($"Çift sayı dizisindeki max: {FindMax(evenNumbers)}");

Console.ReadKey();

int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

int Find(int[] arr, int key)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == key)
            return i;


    }
    return -1; // eleman bulunamadı.

}




