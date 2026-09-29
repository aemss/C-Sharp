using Dictionary;
using System;
using System.Collections.Generic;
using System.Text;



var manager = new StudentManager();

manager.AddStudent(new Student(101,"Enes",3.2));
manager.AddStudent(new Student(102,"Said",2.5));
manager.AddStudent(new Student(103,"Kaan", 3.9));

manager.FindStudent(102);

manager.PrintAll();

Console.WriteLine();

manager.RemoveStudent(103);
manager.PrintAll();




