using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet;

class Student
{
    public Student(int id, string name)
    {
        Name = name;
        ID = id;
    }

    public int ID { get; private set; }
    public String Name { get; private set; }

    public override bool Equals(object? obj)
    {
        if (obj is Student other)
            return ID == other.ID; // doğru mu ?
        return false; // doğru değilse false döndür.
    }

    public override int GetHashCode()
    {
        return ID.GetHashCode();
    }

    public override string ToString() => $"{ID} {Name}";


}
