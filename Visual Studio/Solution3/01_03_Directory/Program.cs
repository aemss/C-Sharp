
/*

//Directory.CreateDirectory("temp");
//Directory.CreateDirectory("temp/deneme");
//Directory.CreateDirectory("temp/deneme2");

if(Directory.Exists("temp/deneme2")) 
{
    Directory.Delete("temp/deneme2");
    
}else
{
    Console.WriteLine("Directory does not exist.");
}

//string path = @"C:\temp\DENEME ";
string path = Directory.GetCurrentDirectory() + "/temp";

Console.WriteLine(path);

Directory.CreateDirectory(path);

*/

 string rootPath = Directory.GetCurrentDirectory();

//string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

//foreach(var dir in dirs)
//{
//    Console.WriteLine(dir);
//}

string sourcepath = @"C:\Users\Desktop\WARBAND\img";
string dest_path = @"C:\Users\Desktop\WARBAND\images\";

string[] files = Directory.GetFiles(sourcepath, "*",SearchOption.AllDirectories);

foreach(var file in files)
{
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));
    
    var info = new FileInfo(file);
    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

    if(!Directory.Exists(dest_path))
    {
        Directory.CreateDirectory(dest_path);
    }

    string name = Path.GetRandomFileName() + Path.GetExtension(file);
    File.Copy(file, $"{dest_path}{name}");


}

