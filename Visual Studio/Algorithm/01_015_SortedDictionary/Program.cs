namespace _01_15_SortedDictionary;

internal class Program
{
    static void Main(string[] args)
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
}
