
namespace ConsoleApp  // Namespace declaration for the console application
{              
    class Program {
    static void Main(string[] args) {
            Console.WriteLine("Merhaba BTK");
            // string a = "C:\\BTK";
            // Directory.CreateDirectory(a);  // Create a directory at the specified path);
            // class => object 
            Ogrenci ogr1 = new Ogrenci() { OgrenciNo = "100", AdSoyad = "Enes", Sube = "7/E" };

            // ogr1.OgrenciNo = "100";
            // ogr1.AdSoyad = "Enes";
            // ogr1.Sube = "7/E";

            Ogrenci ogr2 = new Ogrenci() { OgrenciNo = "678", AdSoyad = "Kerem", Sube = "7/E" };
            Ogrenci ogr3 = new Ogrenci() { OgrenciNo = "343", AdSoyad = "Mehmet", Sube = "7/D" };
            Ogrenci ogr4 = new Ogrenci() { OgrenciNo = "173", AdSoyad = "Ali", Sube = "5/A" };

            // ogr1.BilgileriYazdir(); 


            Ogrenci[] ogrenciler = new Ogrenci[4] {ogr1,ogr2,ogr3, ogr4 };

            //ogrenciler[0] = ogr1;
            //ogrenciler[1] = ogr2;
            //ogrenciler[2] = ogr3;

             foreach(var ogrenci in ogrenciler) {
                Console.WriteLine(ogrenci.BilgileriYazdir());
                

             }


            // Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.AdSoyad} ve şubesi {ogrenci.Sube}.");
            // Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.AdSoyad} ve şubesi {ogrenci.Sube}");

        }
    }

    class Ogrenci {
        // property => string,int

        public string? OgrenciNo { get; set; }
        public string? AdSoyad { get; set; }
        public string? Sube { get; set; }

        // methods => bilgileriyazdir()

        public string BilgileriYazdir() // Void'in geri dönüş değeri yok.
        {
            return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}.";
        }
       
    }

}


