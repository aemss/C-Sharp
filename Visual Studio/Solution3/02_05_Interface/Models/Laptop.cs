using Contracts;
namespace Models;
public class Laptop : IReachargable
{
    public String Model { get; } // Sadece Okunabilir
    private int batterLevel; // iç durum | field
    public int BatteryLevel => batterLevel;

    public Laptop(String model, int initialBatteryLevel = 40)
    {
        Model = model;
        batterLevel = Math.Clamp(initialBatteryLevel, 0, 100);
    }

    public void Recharge(int amount)
    {
        batterLevel = Math.Clamp(batterLevel + amount, 0, 100);
        Console.WriteLine($"[Laptop] {Model} şarj edildi.Seviye %{batterLevel}");
    }

}



