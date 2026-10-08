using System;
using System.Collections.Generic;
using System.Text;

namespace SortedList;
class Book
{
    public int ID { get; private set; } // sınıf içinde atama yapılabilir
    public String Title { get; private set; }
    public String Author { get; private set; }

    public Book(int id, string title, string author)
    {
        ID = id;
        Title = title;
        Author = author;
    }
    public void Rename(string newTitle)
    { 
        Title = newTitle;
    }
    
    public void ChangeAuthor(string AuthorName) => Author = AuthorName;




    public override string ToString() => $"{ID} {Title} - {Author} ";
    
        
    


}
