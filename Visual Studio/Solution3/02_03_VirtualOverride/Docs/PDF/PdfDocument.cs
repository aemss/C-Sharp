
namespace Docs.PDF;

public class PdfDocument : Document

{
    public PdfDocument(string title) : base(title)
    {

    }
    public override void Print()
    {
        // base.Print();
        Console.WriteLine($"PDF Belgesi Yazdırılıyor: {Title}");

    }

}

