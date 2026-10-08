
namespace Contracts;

public class SmartPhone : IRechargeable, IConnectable
{
    public String Model { get; set; }

    public SmartPhone(string model)
    {
        Model = model;
    }

    public void Connect()
    {
        Console.WriteLine($"{Model} Model bağlandı.");
    }

    public void Recharge()
    {
        Console.WriteLine($"{Model} model şarj ediliyor.");
    }
}


