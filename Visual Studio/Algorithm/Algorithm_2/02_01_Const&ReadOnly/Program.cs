
// static ve const beraber kullanılamaz.
//static const int c = 23;

var mc = new SampleClass(11, 22);

Console.WriteLine($"x = {mc.x}\ny = {mc.y}");
Console.WriteLine($"C1 = {SampleClass.C1}\nC2 = {SampleClass.C2}");

class SampleClass
{
    public int x;
    public int y;

    public const int C1 = 5;
    public const int C2 = C1 + 5;

    public SampleClass(int p1,int p2)
    {
        x = p1;
        y = p2;
    }

} 
    
