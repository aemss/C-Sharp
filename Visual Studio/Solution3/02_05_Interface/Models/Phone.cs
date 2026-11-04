
using Contracts;
namespace Models;

public class Phone : IReachargable
{
    public String Model { get; }
    private int batterLevel; // iç durum

    public int BatteryLevel => batterLevel;

    public Phone(String model, int initialBatterLevel = 50)
    {
        Model = model;
        batterLevel = initialBatterLevel; // /Math.Clamp(initialBatterLevel, 0, 100);
    }


    public void Recharge()
    {
        
    }

    public void Recharge(int amount)
    {
        batterLevel = Math.Clamp(batterLevel+amount,0,100);
        Console.WriteLine($"[Phone] {Model} şarj edildi.Seviye: %{batterLevel}");
    }

}



