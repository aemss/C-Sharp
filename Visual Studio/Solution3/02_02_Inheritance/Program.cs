
LogFile logfile = new LogFile("log.txt");

// üst sınıf (base) özellikleri
logfile.WriteToFile("Başlangıç log kaydı ");
Console.WriteLine(logfile.ReadFromFile());

// alt sınıf özellikleri
logfile.AppendLog("Kullanıcı Sisteme Giriş Yaptı.");
logfile.AppendLog("Veri Güncelleme İşlemi Gerçekleştirildi.");

Console.WriteLine("Son Dosya İçeriği: ");
Console.WriteLine(logfile.ReadFromFile());

