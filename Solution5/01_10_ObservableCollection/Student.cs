using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableCollection;

class Student
{
    public Student(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public int ID { get; }
    public String Name { get; set; }

    public override string ToString() => $"{ID} {Name}";


}
