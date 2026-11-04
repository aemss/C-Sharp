
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var sayi1 = 10;
            var sayi2 = 20;

            var sonuc = Toplam(sayi1, sayi2);
            Console.WriteLine(sonuc);

        }
        static int Toplam(int a, int b ) 
        {
            var toplam = a + b;
            return toplam;
        }


    }
}


