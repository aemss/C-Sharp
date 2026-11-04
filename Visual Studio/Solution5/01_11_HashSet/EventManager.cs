using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet;

class EventManager
{
    private HashSet<Student> attendees = new HashSet<Student>();
    private HashSet<Student> certified = new HashSet<Student>();
    public void AddAttendee(Student student) => attendees.Add(student);
    public void AddCertified(Student student) 
        => certified.Add(student);
    public void PrintNotCertified()
    {
        var notCertified = new HashSet<Student>(attendees);
        notCertified.ExceptWith(certified);

        Console.WriteLine("\n=== Sertifika Almayanlar ===");
        foreach(var item in notCertified)
        {
            Console.WriteLine(item);
        }
    }
    public void PrintCertifiedAttendees()
    {
        var both = new HashSet<Student>(attendees);
        both.IntersectWith(certified);
        Console.WriteLine("\n=== Sertifika Alanlar ===");
        foreach (var item in both)
        {
            Console.WriteLine(item);
        }
    }
    public void PrintAllStudents()
    {
        var all = new HashSet<Student>();
        all.UnionWith(certified);

        Console.WriteLine("\n === Tüm Öğrencilerin Listesi===");
        foreach(var i in attendees)
        {
            Console.WriteLine(i);
        }
    }


}
