using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection;

class StudentManager
{
    public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();
    public StudentManager()
    {
        // Abonelik
        Students.CollectionChanged += OnStudentsChanged;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    public bool RemoveStudentByID(int id)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].ID.Equals(id))
            {
                Students.RemoveAt(i);
                return true;
            }
            
        }
        Console.WriteLine($"ID {id} bulunamadı. ");
        return false;
    }
    public void PrintAll()
    {
        Console.WriteLine("=== Öğrenci Listesi === ");
        foreach(var s in Students)
        {
            Console.WriteLine(s);
        }
    }

    private void OnStudentsChanged(object? sender,
        NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine(e.Action);
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if(e.NewItems is not null)
                    foreach (Student s in e.NewItems)
                        Console.WriteLine($"[+] Eklendi: {s}");
                break;
            case NotifyCollectionChangedAction.Remove:
                if(e.OldItems is not null)
                    foreach(Student s in e.OldItems)
                        Console.WriteLine($"[-] Silindi. {s}");
                break;

            default:
                Console.WriteLine("Reset!");
                break;
        }
    }
}