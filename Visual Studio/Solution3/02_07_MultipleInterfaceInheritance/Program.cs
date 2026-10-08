
using Contracts;


SmartPhone phone = new SmartPhone("Pixy 10");
phone.Recharge();
phone.Connect();

IRechargeable batteryRef = phone;
IConnectable netRef = phone;

Console.WriteLine("Arayüz Kullanımı");
batteryRef.Recharge();
netRef.Connect();

