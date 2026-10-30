namespace _01_15_SortedDictionary;

using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        static void YazılımKitaplari()
        {


            var kitapIndeks = new SortedDictionary<String, List<int>>() 
            {
            {"HTML", new List<int>() {8,10,12 }  },
            {"CSS", new List<int> {70,80,90 }  },
            {"jQuery", new List<int> {3,5,15 }  },
            {"SQL", new List<int> {70,80 }  }
            };

            kitapIndeks.Add("FTP", new List<int> { 3,5,7 });
            kitapIndeks.Add("ASP.Net", new List<int> { 50,60 });

            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key,kavram.Value);
                foreach (var sayfa in kavram.Value)
                {
                Console.WriteLine($"\t > {sayfa}");
                }
            }

        }

        static void RomanKitaplari()
        {


            var kitapIndeks2 = new SortedDictionary<String, List<int>>()
            {   
                {"Martin Eden",new List<int>{5 } },
                { "Sefiller",new List<int>{10} },
                { "Suç ve Ceza",new List<int>{15} },
                { "Savaş ve Barış",new List<int>{20} },
                { "Küçük Prens",new List<int>{25} }

            };

            kitapIndeks2.Add("Anna Karenina", new List<int>{30});

            foreach(var i in kitapIndeks2)
            {
                Console.WriteLine(i.Key);

                foreach(var sayfa in i.Value)
                {
                    Console.WriteLine($"\t > {sayfa}");
                }
            }
        }

        YazılımKitaplari();

        Console.WriteLine("\n=====\n");

        RomanKitaplari();



    }


}



