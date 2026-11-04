
namespace Log;
public class SecureFileLogger : FileLogger
{
    public SecureFileLogger(string message,string path) : base(message,path)
    {

    }

    public override void Log()
    {
        char[] chars = logMessage.ToCharArray();
        Array.Reverse(chars);
        string encyrpted = new string(chars);

        File.AppendAllText(filePath, encyrpted + Environment.NewLine);
        Console.WriteLine($"Şifrelenmiş Log Yazıldı: {filePath}");
    }

}