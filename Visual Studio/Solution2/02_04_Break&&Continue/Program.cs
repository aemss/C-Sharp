
//string isim = "Enes Mot";
//for(var i = 0; i < isim.Length; i++) 
//{
//    if (isim[i] == 's')
//        continue;
//    Console.WriteLine(isim[i]);

//}

/*
int x = 0;

while(x< 5) 
{
    x++;
    if(x == 3)
        continue;
    Console.WriteLine(x);
}
*/

var rnd = new Random();


int tutulan = rnd.Next(1, 100);

int hak = 3;

while(hak > 0) 
{
    Console.Write("sayı:");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if(sayi == tutulan)
    {
        Console.WriteLine("Bildiniz.");
    }
    else 
    {
        if( hak == 0)
        {
            Console.WriteLine("Oyun bitti");
            break;
        }
        if (tutulan > sayi)
        {
            Console.WriteLine("yukarı");
        }
        else
            Console.WriteLine("Aşağı");
    }
}


