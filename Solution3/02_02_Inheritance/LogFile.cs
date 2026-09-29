
class LogFile : FileHandler
{
    public LogFile(string filePath) : base(filePath)
    {

    }
    // Log ekleme
    public void AppendLog(String logMessage)
    {
        using (StreamWriter sw = File.AppendText(FilePath))
        {
            sw.WriteLine($"{DateTime.Now}: {logMessage}");
        }
        Console.WriteLine("Log Dosyaya eklendi.");
    }
}

