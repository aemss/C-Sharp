
using SortedList;

ILibrararyService library = new Library();

library.AddBook(new Book(12,"Martin Eden","Jack London"));
library.AddBook(new Book(15,"Çocukluk","Tolstoy"));
library.AddBook(new Book(8,"Güzel Dost","Mauppassant"));

library.TryFindById(12,out Book book);
library.RemoveAtPosition(2);

var libImp = library as Library;
Console.WriteLine($"ID 20 indeks: {libImp?.IndexOfID(8)}");



library.PrintAll();

