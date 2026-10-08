
using System.Collections;

namespace ArrayListWithOOP;

public class StudentsManager
{
    private ArrayList students;
    public StudentsManager()
    {
        students = new ArrayList();
    }
    public void  Add(String name)
    {
        students.Add(name);
        Console.WriteLine(name + " Eklendi.");
    }
    public void remove(String name)
    {
        students.Remove(name);
        Console.WriteLine(name + " silindi.");
    }
    public void removeAt(int index) 
    {
        if (index >= 0 && index < students.Count)
        {
            students.RemoveAt(index);
            Console.WriteLine("Silindi: " + students[index]);
        }else
            Console.WriteLine("Geçersiz index. ");
    }
    public void Update(int index,String name)
    {
        students[index] = name;
    }
    public void insert(int index, String name)
    {
        if(index >= 0 && index < students.Count)
        students.Insert(index, name);

    }
    public void PrintAll()
    {
        Console.WriteLine("\n===Öğrenci Listesi.===\n");
        foreach(var student in students)
        {
            Console.WriteLine(student);
        }
    }


}






