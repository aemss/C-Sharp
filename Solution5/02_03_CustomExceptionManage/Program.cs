using Errors;
using Model;
try
{
    Console.WriteLine("İsmi giriniz: ");
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    var person = new Person(age,name);
    person.PrintInfo();

}
catch(InvalidAgeException ex)
{
    Console.WriteLine($"Hata: + {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
}
finally
{
    Console.WriteLine("Program sonlandı...");
}


