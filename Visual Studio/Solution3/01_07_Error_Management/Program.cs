
namespace ConsoleApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Exception
            // System.FormatException
            // System.DivideByZeroException
            // System.NullReferenceException

            try
            {
                Console.WriteLine("1. Sayı: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. Sayı: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                var sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölme hatası oluştu");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            { Console.WriteLine("Bir hata oluştu");
              Console.WriteLine(ex.Message);
            }



            // Exception Handling
        }
    }



}   










