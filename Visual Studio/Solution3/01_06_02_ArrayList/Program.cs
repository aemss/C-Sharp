
using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            // non-genetic => object
            // dinamik
            ArrayList liste = new ArrayList();

            liste.Add(10);
            liste.Add("10");
            liste.Add("Ali");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList() 
            {
                5,
                "Ahmet",
                false,
                4.5,
                null
            };

            int[] sayilar = { 10, 20, 30 };
            liste.AddRange(sayilar);

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();

            Console.WriteLine(eleman);
            Console.WriteLine(isim);

           
            // insert

            liste.Insert(1, "Enes");
            liste.InsertRange(2, liste2);

            // remove
            liste.Remove(null); 
            liste.RemoveAt(0);       // 0. indexteki elemanı siler
            liste.RemoveRange(2, 3); // 2. indexten itibaren 3 elemanı siler

            // contains, index
            Console.WriteLine(liste.Contains(100));
            Console.WriteLine(liste.IndexOf(10));

            // foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}


        }

    }

}

