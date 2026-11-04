
using System.Collections.Generic;


namespace Ctor;

internal class Student
{
    public int ID { get;} //get okunabilir,set değiştirilebilir.
    public String Name { get;}

    public Student()
    {
        ID = 0;
        Name = "Bilinmiyor ";
    }

    public Student(int id, String name)
    {
        ID = id;
        Name = name ?? "Bilinmiyor";    
    }
    public override string ToString() => $"Id: {ID,-5} Name: {Name}";
  

}
