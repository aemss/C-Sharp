
// Oturum bilgileri
using System.Text;

String userEmail = "enes77782@gmail.com";
String[] endpoints = { "/home", "/products/usb-c-cable","/cart","/checkout" };

// İlk raporu üret 
string report1 = BuildSessionReport(userEmail,
    endpoints,
    sessionId: "S-1001");

string report2 = BuildSessionReport("crazyboyaykut@hotmail.com",
    new[] { "/home", "/search" },
    sessionId: "S-1002");


Console.WriteLine(report1);
Console.WriteLine("\n\n");
Console.WriteLine(report2);

 string BuildSessionReport(string userEmail, string[] endpoints, string sessionId)
{
    // String Builder
    var sb = new StringBuilder(capacity:256);
    // Olay Ekleme
    sb.AppendLine($"User: {userEmail}");
    sb.AppendLine($"Session ID: {sessionId}");
    sb.Append("Visited: ");

    foreach (var item in endpoints)
    {
        sb.Append(item).Append(",");
    }
    // Fazla Ayracı temizleme
    if (endpoints.Length > 0);
        sb.Remove(sb.Length - 2, 2);
    sb.AppendLine();
    sb.AppendLine($"Login Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

    // Güvenlik
    sb.Replace("@gmail.com", "@domain.local");
    sb.Replace("@hotmail.com", "@domain.local");

    string report = sb.ToString();
    return report;

    // Başlık
    string header = $"SESSION LOG {DateTime.Now:yyyy:MM:dd} \n";
    sb.Insert(0, header);

}

Console.ReadKey();


