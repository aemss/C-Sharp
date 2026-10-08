
using System.Collections;

namespace Ctor;

internal class StudentManager
{
    private ArrayList students;

   

    public StudentManager()
    {
        students = new ArrayList();
    }
    public StudentManager(Student s) : this() // yukarıdaki satırın aynısını tekrar yazmamak için.
    {
        if (s is not null)
            students.Add(s);
    }

    public StudentManager(IEnumerable<Student> students) : this()
    {
        foreach(var std in students)
        {
            this.students.Add(std);
        }
    }
    public void Add(Student s)
    {
        if(s is null)
        {
            Console.WriteLine("Geçersiz Öğrenci!.");
            return;
        }
        students.Add(s);
    }
    public void PrintAll()
    {
        Console.WriteLine("===Öğrenciler===");
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i] is Student st)
            {
                Console.WriteLine($"{st}");
            }
        }
    }



        
    

}
