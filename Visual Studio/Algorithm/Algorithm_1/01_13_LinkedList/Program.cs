namespace _01_13_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");

            sehirler.AddAfter(sehirler.Find("Ordu"),"Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous.Previous, ("Yalova"));
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Last.Previous, "Zonguldak");

            Console.WriteLine("Gidiş Güzergâhı\n");

            var eleman = sehirler.First;
            while(eleman != null )
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine("\nDönüş Güzergâhı\n");
            var gecici = sehirler.Last;
            while (gecici != null) 
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }

            
        }
    }
}
