
File.WriteAllText("deneme.txt", "Merhaba ");
File.AppendAllText("deneme.txt", "BTK Akademi");

using (StreamReader sr = File.OpenText("deneme.txt"))
{
    var s = "";

    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);

    }

}



/*
// string sonuc = File.ReadAllText("deneme.txt");
string[] sonuc = File.ReadAllLines("deneme.txt");

Console.WriteLine(sonuc[0]);
Console.WriteLine(sonuc[1]);



using (StreamWriter sw = File.CreateText("deneme.txt"))
    {
        sw.WriteLine("Merhaba");
        sw.WriteLine("BTK");
        sw.WriteLine("Akademi");

    }

    using (StreamWriter sw = File.AppendText("deneme.txt"))
    {
        sw.WriteLine("");
        sw.WriteLine("Merhaba");
        sw.WriteLine("BTK");
        sw.WriteLine("Akademi");

    }




// sw.Close(); Bu şekilde dosya kapatılabilir. Ancak using kullanmak daha iyi bir yöntemdir.
*/
