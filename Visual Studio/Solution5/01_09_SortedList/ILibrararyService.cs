using SortedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortedList;

interface ILibrararyService
{
    void AddBook(Book book);
    bool RemoveBookByID(int id);
    void RemoveAtPosition(int index);
    bool TryFindById(int id, out Book book);
    void PrintAll();


}


