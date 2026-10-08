using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary;

class Student
{
    public int ID { get; set; }
    public String Name { get; set; }
    public Double GPA { get; set; }

    public Student(int id, string name,double gpa)
    {
        ID = id;
        Name = name;
        GPA = gpa;
    }
    public override string ToString() =>
        $"{ID, -5} {Name,-20} {GPA}";
}
    
    



