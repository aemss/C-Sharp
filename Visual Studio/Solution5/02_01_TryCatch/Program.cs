/*
try
{
    int a = 10;
    int b = 0;

    var result = a / b;
}
catch(DivideByZeroException d)
{
    throw new DivideByZeroException("Sıfıra bölme hatası. ");
}

catch(Exception ex)
{
    //Console.WriteLine($"Bir hata oluştu: {ex.Message}");
    throw new Exception($"Bir hata oluştu: {ex.Message}");
}
finally
{
    Console.WriteLine("Program sona eriyor...");

}
*/

try
{
    Console.WriteLine("Bir sayı giriniz: ");

    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bölen giriniz: ");
    int divisor = Convert.ToInt32(Console.ReadLine());
    //int result = number / divisor;
    int result = Divide(number, divisor);
    Console.WriteLine($"Sonuç : {result}");


} catch(FormatException) 
{
    //throw new FormatException("Geçerli bir sayı girmelisiniz. ");
    Console.WriteLine("Geçerli bir sayı girmelisiniz.");
}
catch(DivideByZeroException)
{
    Console.WriteLine($"Sıfıra bölünemez.");
}
catch(Exception ex)
{
    Console.WriteLine($"Beklenmeyen bir hata oluştu {ex.Message}");
}

finally
{
    Console.WriteLine("Program sona eriyor...");
}

int Divide(int a, int b)
{
    if (b.Equals(0))
        throw new DivideByZeroException("Bölen Sıfır Olmaaz.");
    return a / b;
}
