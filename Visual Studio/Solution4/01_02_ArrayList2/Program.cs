// Tanımlama


using System.Collections;

var students = new ArrayList();

// Ekleme

students.Add("Ali");
students.Add("Mehmet");
students.Add("Celal");
students.Add("Enes");

Console.WriteLine("===Başlangıc Listesi===\n");
PrintList(students);

// Silme
students.Remove("Mehmet");
students.RemoveAt(0);

Console.WriteLine("===Silme Sonrası Liste===\n");
PrintList(students);

students[0] = "Arda";

Console.WriteLine("===Güncelleme Sonrası Liste===\n");
PrintList(students);

// Araya ekleme
students.Insert(1, "Kemal");

Console.WriteLine("===Ekleme Sonrası Liste===\n");
PrintList(students);

static void PrintList(ArrayList list)
{
    for(int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"Index: {i} -> {list[i]} ");
    }

}

