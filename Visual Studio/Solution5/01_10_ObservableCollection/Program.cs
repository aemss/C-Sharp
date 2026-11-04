
using ObservableCollection;

var manager = new StudentManager();

manager.AddStudent(new Student(1,"İsmail"));
manager.AddStudent(new Student(6,"Kerem"));
manager.AddStudent(new Student(3, "Buğra"));

manager.PrintAll();

manager.RemoveStudentByID(1);
manager.PrintAll();





