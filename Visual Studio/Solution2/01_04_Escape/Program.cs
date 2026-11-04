
// kaçış karakteri
string report = "Log Raporu\n\t- Kullanıcı: admin\n\t- İşlem:Yedekleme";
Console.WriteLine(report);

// dosya yolları
string path1 = "C:\\Users\\Admin\\Documents\\data.txt";
Console.WriteLine("Kaçış karakteri ile yol:" +  path1);

// verbatim
Console.WriteLine("\n");
string path2 = @"C:\\Users\\Admin\\Documents\\data.txt";
Console.WriteLine("Verbatim ile yol: " + path2 );

// JSON
string jsonEscaped = "{\"username\" : \"admin\"}";
Console.WriteLine("JSON çıkışı: " +  jsonEscaped);

// JSON verbatim
Console.WriteLine("\nJSON verbatim:");
string jsonVerbatim = @"{
""username"" : ""admin""
""status"" : ""activity""
}";

Console.WriteLine(jsonVerbatim);

Console.ReadKey();