namespace _01_02_Byte;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(nameof(SByte));
        Console.WriteLine($"Alt Limit: {SByte.MinValue,20}");
        Console.WriteLine($"Üst Limit: {SByte.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(SByte),20}\n");

        // Unsigned 8-Bit Integer
        Console.WriteLine(nameof(Byte));
        Console.WriteLine($"Alt Limit: {Byte.MinValue,20}");
        Console.WriteLine($"Üst Limit: {Byte.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(Byte),20}\n");

        // Signed 16-Bit Integer
        Console.WriteLine(nameof(Int16));
        Console.WriteLine($"Alt Limit: {Int16.MinValue,20}");
        Console.WriteLine($"Üst Limit: {Int16.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(Int16),20}\n");

        // Unsigned 16-Bit Integer
        Console.WriteLine(nameof(UInt16));
        Console.WriteLine($"Alt Limit: {UInt16.MinValue,20}");
        Console.WriteLine($"Üst Limit: {UInt16.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(UInt16),20}\n");

        // signed 32-Bit Integer
        Console.WriteLine(nameof(Int32));
        Console.WriteLine($"Alt Limit: {Int32.MinValue,20}");
        Console.WriteLine($"Üst Limit: {Int32.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(Int32),20}\n");

        // Double
        Console.WriteLine(nameof(Double));
        Console.WriteLine($"Alt Limit: {Double.MinValue,20}");
        Console.WriteLine($"Üst Limit: {Double.MaxValue,20}");
        Console.WriteLine($"Boyut: {sizeof(Double),20}\n");

    }
}
