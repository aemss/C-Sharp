
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary 

            //Key- Value => plaka - şehir

            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41, "Kocaeli");
            plakalar.Add(77, "Yalova");
            plakalar.Add(53, "Rize");

            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {
                { 1, "Bir" },
                { 2, "İki" },
                { 3, "Üç" }

            };

            Console.WriteLine(plakalar[41]);
            if(plakalar.ContainsKey(53)) 
            {
                Console.WriteLine(plakalar[53]);
            }

            foreach(var plaka in plakalar) 
            {
                Console.WriteLine($"{plaka.Key}: {plaka.Value}");
            }

            // update
            sayilar[1] = "One";
            sayilar.Remove(1);

            //sayilar.Clear();

            Console.WriteLine(sayilar[1]);


        }
    }
}


