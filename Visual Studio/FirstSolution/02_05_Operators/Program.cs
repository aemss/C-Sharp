using System.Threading.Channels;

namespace _03_02_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama
            int sum = 5 + 3;
            Console.WriteLine($"Toplam: {sum}");

            // Fark
            int a = 5;
            int b = 3;
            Console.WriteLine($"{a} - {b} = {a-b}");
            

            // Çarpma
            int c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");

            // Bölme

            int d = a / b;
            double e = (double) a / b;

            Console.WriteLine($"d değişkeinin tipi {d.GetType()}");
            Console.WriteLine($"e değişkeinin tipi {e.GetType()}");

            Console.WriteLine($"{a} / {b} = {e}");
            Console.WriteLine($"{a} / {b} = {d}");

            int increase = 6;
            increase++;

            int decrease = 5;
            decrease--;

            Console.WriteLine($"Artırma {increase}");
            Console.WriteLine($"Azaltma {decrease}");

            // Mod
            int f = a % b; // 2
            Console.WriteLine(f);
            




        }
    }
}
