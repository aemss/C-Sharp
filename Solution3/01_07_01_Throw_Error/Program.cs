
using System.Linq;
using System.Threading.Channels;

namespace ConsoleApp 
{ 
    class Program
    {
        static void parola_kontrol(string password)
        {
            if(password.Length < 6 || password.Length >10 )
            {
                throw new Exception("Parola 6 ile 10 karakter arasında olmalıdır.");
            }
            if (!password.Any(char.IsDigit)) // Sayısal karakter değil mi ?
            {
                throw new Exception("Parola en az bir sayısal karakter içermelidir.");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("parola en az bir harf içermelidir");
            }




        }
        static void Main(string[] args)
        {
            Console.WriteLine("parola:");
            string parola = Console.ReadLine();

            try
            {
                parola_kontrol(parola);
                Console.WriteLine("Parola geçerli");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

         

        }
        
    }

}

