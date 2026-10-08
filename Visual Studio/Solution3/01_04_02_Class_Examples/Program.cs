
using System.Reflection.PortableExecutable;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru(1, "Hangisi Programlama dili Değildir?", new string[4] { "Python", "Java", "C#", "Html" }, "Html");

            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidr?",
                new string[4] { "Python", "Java", "C#", "Html" },
                "C#"
                );

            var soru3 = new Soru(3, "Hangisi en popüler web  programlama platformu değildir?",
                new string[4] { "Django", "Asp.net", "Spring", "Python" },
                "Python"
                );

            //var soru3 = new Soru()
            //{
            //    SoruMetni = "Hangisi en popüler web  programlama platformu değildir?",
            //    Secenekler = new string[4] { "Django", "Asp.net", "Spring", "Python" },
            //    Cevap = "Python"
            //    };

            // var soru4 = new Soru(10); 

            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("html"));

            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru2.cevapKontrol("c#"));

            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru3.cevapKontrol("python"));


            // var sorular = new Soru[3] {soru1,soru2,soru3};

            // foreach(var soru in sorular)
            // {
            //    Console.WriteLine(soru.SoruMetni);
            //    foreach(var secenek in soru.Secenekler) {
            //        Console.WriteLine(secenek);
            //    }
            //    // kullanıcıdan cevap alalım
            //    Console.WriteLine("Cevabınız:");
            //    var cevap = Console.ReadLine();

            //    if(soru.cevapKontrol(cevap))
            //    {
            //        Console.WriteLine("Doğru Cevap.");

            //    } else { Console.WriteLine("Yanlış Cevap."); }
            //}
            }



    }

    class Soru
    {
        public Soru()
        {
            Console.WriteLine("constructor 1");
            this.SoruId = (new Random()).Next(11111, 99999);
        }

        public Soru(int soruId)
        {
            Console.WriteLine("constructor 2");
            this.SoruId = soruId;
        }

        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = soruId;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;

        }


        // properties
        private int SoruId { get; set; }
        private string SoruMetni { get; set; }
        private string[] Secenekler { get; set; }
        private string Cevap { get; set; }
        public string SoruYazdir()
        {
            string soru = "";
            soru += this.SoruMetni + "\n";

            foreach (var secenek in this.Secenekler)
            {
                soru += secenek + "\n";

            }
                return soru;
        }



        // methods

        public  bool cevapKontrol(string cevap) 
        {
           return this.Cevap.ToLower() == cevap.ToLower();
        }

    }

}

