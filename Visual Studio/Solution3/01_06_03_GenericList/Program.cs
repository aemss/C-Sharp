
using System.Collections.Generic;

namespace ConsoleApp 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Generic List
            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>() {"Ali", "Ahmet","Enes","Mehmet"};

            List<Product> urunler = new List<Product>();

            urunler.Add(new Product() { Id = 1, Title = "Iphone 17", Price = 125000 });
            urunler.Add(new Product() { Id = 2, Title = "Iphone 18", Price = 135000 });
            urunler.Add(new Product() { Id = 3, Title = "Iphone 19", Price = 145000 });

            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Iphone 20", Price = 155000 });
            
            urunler.RemoveAt(0);
            urunler.Remove(urunler[1]);

            foreach (var urun in urunler) 
            {
                Console.WriteLine(urun.Title + ": " + urun.Price);
            }



        }

        

    }

    class Product 
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }



    }


}


