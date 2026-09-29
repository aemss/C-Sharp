using Log;

namespace Log;
public class Logger
{
    protected String logMessage; //{ get; set; } Sınıf dışından erişilmediği için get ve set'e gerek yok.
                                 // diğer sınıflar buna ulaşabilir, ama sınıf dışından ulaşmak mümkün değil.

    public Logger(String  message)
    {
        logMessage = message;
    }
    public virtual void Log()
    {
        Console.WriteLine($"Log mesajı: {logMessage}");
    }


}




    public class FileLogger : Logger
{
    protected String filePath;
    public FileLogger(string message) : this(message, "log.txt")
    {

    }
    public FileLogger(string message, string path) 
        : base (message)
    {
        filePath = path;
    }

    public override void Log()
    {
        File.AppendAllText(filePath, logMessage + Environment.NewLine);
        Console.WriteLine("log dosyaya yazıldı: " + filePath);
    }

    }
