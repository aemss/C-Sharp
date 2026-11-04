
namespace Docs.Words;
public class WordDocument : Document
{
    public WordDocument(string title) : base(title)
    {

    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Word Belgesi Yazdırılıyor: {Title}");
    }


}

