
// Arayüz Tür
using Contracts;
using Models;

IReachargable[] devices = new IReachargable[]
{
    new Phone("Pixy 7 ", 30),
    new Laptop("Ultrabook 14", 55)

}; 

Console.WriteLine("=== Başlangıç Batarya Seviyeleri === ");

foreach(var device in devices)
{
    Console.WriteLine($"{device.GetType().Name} " +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-',25));
}

Console.WriteLine("=== Tüm cihazları şarj et === ");
foreach(var device in devices)
{
    device.Recharge(25);

}

Console.WriteLine("=== Bitiş Batarya Seviyeleri === ");

foreach (var device in devices)
{
    Console.WriteLine($"{device.GetType().Name} " +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-', 25));
}
