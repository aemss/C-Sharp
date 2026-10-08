
using HashSet;

var manager = new EventManager();

var s1 = new Student(1, "Enes");
var s2 = new Student(2, "Ali");
var s3 = new Student(5, "Efe");
var s4 = new Student(4, "Eray");

manager.AddAttendee(s1);
manager.AddAttendee(s2);
manager.AddAttendee(s3);
manager.AddAttendee(s4);
 
manager.AddCertified(s1);
manager.AddCertified(s3);


manager.PrintAllStudents();
Console.WriteLine("");
manager.PrintCertifiedAttendees();
Console.WriteLine("");
manager.PrintNotCertified();

Console.ReadKey();
