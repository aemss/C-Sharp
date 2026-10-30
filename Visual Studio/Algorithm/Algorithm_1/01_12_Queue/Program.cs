namespace _01_12_Queue;


internal class Program
{
    static void Main(string[] args)
    {
        var sesliharfler = new List<char>()
        {
            'a','e','ı','i','u','ü','o','ö' 
        };

        ConsoleKeyInfo secim;

        var kuyruk = new Queue<char>();

        foreach (char k in sesliharfler)
        {
            Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
            secim = Console.ReadKey();
            if(secim.Key == ConsoleKey.E)
            {
                kuyruk.Enqueue(k);
                Console.WriteLine($"\n {k,-5} kuyruğa eklendi. ");
                Console.WriteLine($"Kuyruktaki eleman sayısı {kuyruk.Count()}");
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Kuyruktan eleman kaldırılması için ESC  tuşuna basın.");
        
        secim = Console.ReadKey();
        if(secim.Key == ConsoleKey.Escape) 
        {
            while (kuyruk.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                Console.WriteLine($" kuyruktaki eleman sayısı: {kuyruk.Count(),5}");
                Console.WriteLine("\n işlem tamamlandı\n");
            }
        }

        Console.WriteLine("Progrram bitti.");
    }






    private static void QueueExample()
    {
        var karakterKuyrugu = new Queue<char>();

        karakterKuyrugu.Enqueue('a');
        karakterKuyrugu.Enqueue('e');
        Console.WriteLine($"Eleman sayısı : {karakterKuyrugu.Count}");

        // İlk giren ilk çıkar.
        Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        Console.WriteLine($"Kuyruktan çıkartılan eleman: {karakterKuyrugu.Dequeue()}");
        Console.WriteLine($"Eleman sayısı : {karakterKuyrugu.Count}");
    }
}
