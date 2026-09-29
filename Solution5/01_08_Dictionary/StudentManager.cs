using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary;

 class StudentManager
{
    private Dictionary<int, Student> students;
    public StudentManager()
    {
        students = new Dictionary<int, Student>();
    }

    public void AddStudent(Student student)
    {
        // ID kontrolü : key tekrar edemez!
        if (!students.ContainsKey(student.ID))
        {
            students.Add(student.ID,student);
            Console.WriteLine($"{student.Name} başarıyla eklendi. ");
        }
        else
        {
            Console.WriteLine($"{student.ID} numaralı öğrenci zaten mevcut. ");
        }
    }
    public void RemoveStudent(int id)
    {
        if(students.Remove(id))
            Console.WriteLine($"{id} numaralı öğrenci silindi. ");
        else
            Console.WriteLine($"{id} numaralı öğrenci bulunamadı. ");
    }

    public void FindStudent(int id)
    {
        // TryGetValue ile öğrenci arayacağız.
        if(students.TryGetValue(id, out Student student))
            Console.WriteLine($" {student} bulundu. ");

        else Console.WriteLine($"Öğrenci bulunamadı: {id}");
    }

    public void PrintAll()
    {
        Console.WriteLine("\n == Öğrenci Listesi === ");
        foreach(var s in students.Values)
        {
            Console.WriteLine(s);
        }
    }



}
