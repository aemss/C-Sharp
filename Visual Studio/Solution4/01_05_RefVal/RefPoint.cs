
namespace _01_05_RefVal;

internal class RefPoint
{
    public int X { get; set; }
    public int Y { get; set; }
    public RefPoint(int x,int y)
    {
        Y = y;
    }

    public override string ToString() => $"RefPoint: {X}, {Y}";
    
          
    

}
