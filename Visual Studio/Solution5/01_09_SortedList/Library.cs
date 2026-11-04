using System;
using System.Collections.Generic;
using System.Text;

namespace SortedList;

internal class Library : ILibrararyService
{
    private readonly SortedList<int, Book> books;

    public Library()
    {
        books = new SortedList<int, Book>(); 
    }

    public void AddBook(Book book)
    {
        if (books.ContainsKey(book.ID)) { 
            Console.WriteLine($"IdD : {book.ID} zaten tanımlı! ");
        return;
        }
        
        books.Add(book.ID, book);
        Console.WriteLine($"{book.Title} başarılı bir şekilde eklendi.");

    }
        
 
    public void PrintAll()
    {
        Console.WriteLine("=== Kİtap Listesi ===");
        foreach(var b in books)
        {
            Console.WriteLine(b.Value);
        }
    }

    public void RemoveAtPosition(int index)
    {
        if (index < 0 || index >= books.Count) 
        {
            Console.WriteLine("Geçersiz indeks! ");
            return;
        }
        int key = books.Keys[index];
        books.RemoveAt(index);
        Console.WriteLine("İndeks silindi: key={key}");
    }

    public bool RemoveBookByID(int id)
    {
        bool removed = books.Remove(id);
        Console.WriteLine(removed ? $"Silindi: {id}": $"Bulunamadı: {id}");
        return removed;

        }
    public bool TryFindById(int id, out Book book)
    {
        bool ok = books.TryGetValue(id, out book);
        Console.WriteLine(ok ? $"Kitap bulundu: {book}": $"ID : {id}");
        
        return ok;
    }

    public int IndexOfID(int id) => books.IndexOfKey(id);

}
