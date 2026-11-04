
/*

using System.Reflection.Metadata;
using System.IO;


namespace ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Asker> ordu = new List<Asker>();

            Asker birinciasker = new Asker();
            birinciasker.İsim = "Rodok Keskin Nişancısı";
            birinciasker.Level = 28;
            ordu.Add(birinciasker);
            

            Asker ikinciasker = new Asker();

            ikinciasker.İsim = "Nord Kahramnı";
            ikinciasker.Level = 30;
            ordu.Add(ikinciasker);


            int ToplamLevel = 0;

            foreach (Asker asker in ordu)
            {
                Console.WriteLine(asker.İsim);
                Console.WriteLine(asker.Level);
                ToplamLevel += asker.Level;
            }
            Console.WriteLine($"Ordunun Toplam Leveli : {ToplamLevel}");

            File.WriteAllText("birlik_kayit.txt", $"Ordunun Toplam Leveli : {ToplamLevel}");

        }
    }
    class Asker 
    {
        public string İsim { get; set; }
        public int Level { get; set; }
    }

}
    */

int can = 100;
Random rnd = new Random();



for (int i = 1; i <= 5; i++)
{
    int Hasar = rnd.Next(10, 30);
    Console.WriteLine($"Verilen Hasar: {Hasar}");
    Console.WriteLine($"Yeni Can: {can -= Hasar}");
    Console.WriteLine(can);


    if (can <= 0)
    {
        Console.WriteLine("Karakter Öldü.");

    }
    else
    {
        Console.WriteLine("Karakter Yaşıyor.");

    }

}



     


    



