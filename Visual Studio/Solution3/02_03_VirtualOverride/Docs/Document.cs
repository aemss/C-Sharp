
using System.Reflection.Metadata;

namespace Docs;

public class Document
{
    public String Title { get; set; }
    public Document(String title)
    {
        Title = title;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Belge yazdırılıyor: {Title}");

    }


}

