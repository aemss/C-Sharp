
using ArrayListWithOOP;

var manager = new StudentsManager();

manager.Add("Ali");
manager.Add("Mehmet");
manager.Add("Yusuf");
manager.Add("Efe");

manager.PrintAll();

manager.remove("Efe");
manager.removeAt(0);
manager.PrintAll();

manager.Update(0,"Kemal");

manager.PrintAll();

manager.insert(1,"Emre");
manager.PrintAll();


