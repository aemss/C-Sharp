
using Ctor;

var manager = new StudentManager();

manager.Add(new Student(1, "Ahmet"));
manager.Add(new Student(2, "Ali"));

manager.PrintAll();
