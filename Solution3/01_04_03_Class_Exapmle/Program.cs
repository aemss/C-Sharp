/*

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var asker1 = new Asker()
            {
                İsim = "Svadyalı Şövalye",
                Level = 28,
                Can = 58
            };

            var asker2 = new Asker();
            asker2.İsim = "Nord Kahramanı";
            asker2.Level = 30;
            asker2.Can = 60;

            Console.WriteLine($"1. Askerin Özellikleri:\nİsmi: " +
                $"{asker1.İsim}\n" +
                $"Leveli: {asker1.Level}\n" +
                $"Canı: {asker1.Can}\n"
                );
         

            Console.WriteLine($"2. Askerin Özellikleri:\nİsmi: {asker2.İsim}\nLeveli: {asker2.Level}\nCanı: {asker2.Can}\n"); ;    


        }

        

    }
    class Asker
    {
        public string? İsim { get; set; }
        public int Level { get; set; }
        public int Can { get; set; }
    }
    


}
*/

// 1. SÖZLÜK OLUŞTURMA
// Anahtar: string (İsim), Değer: Yoldas (Nesne)
Dictionary<string, Yoldas> handakiYoldaslar = new Dictionary<string, Yoldas>();

// Yoldaşları "new Yoldas(...)" diyerek doğrudan sözlüğün içine doğurtuyoruz
handakiYoldaslar.Add("Lezalit ", new Yoldas("Lezalit ", 90));
handakiYoldaslar.Add("Artimenner ", new Yoldas("Artimenner ", 80)); 

List<Yoldas> ordu = new List<Yoldas>();
ordu.Add(handakiYoldaslar["Lezalit "]);
ordu.Add(handakiYoldaslar["Artimenner "]);

Console.WriteLine("--- SAVAŞ SONU RAPORU ---");

foreach(Yoldas siradaki in ordu)
{
    siradaki.HasarAl(25);
    Console.WriteLine(siradaki.İsim + " isimli yoldaşın yeni canı: " + siradaki.CaniSoyle());


}

// 4. STATİC SAYAÇ
Console.WriteLine("\nHandan partiye katılan toplam yoldaş sayısı: " + Yoldas.HanciYoldasSayaci);


class Yoldas

{


    public string İsim;
    private int Can;

    public static int HanciYoldasSayaci = 0;
    public int CaniSoyle()
    {
        return Can;
    }

    public Yoldas(string Baslangıcİsmi, int BaslangıcCan)
    {
        İsim = Baslangıcİsmi;
        Can = BaslangıcCan;
        HanciYoldasSayaci++;
    }

    public void HasarAl(int HasarMiktari)
    {
        Can -= HasarMiktari;
        if (Can < 0)
            Can = 0;


    }

}

