using System;
using System.IO;
using System.Linq;
public class FileIO
{
    public void LearnDirectories()
    {
        Directory.CreateDirectory(@"../ABC");
        string fileHello = File.ReadAllText("Hello.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"../ABC/Folder{i + 1}");
            File.WriteAllText($"../ABC/Folder{i + 1}/Hello.cs", fileHello);
        }
    }
    static void Main99 (string[] args)
    {
        FileIO fileIO = new FileIO();
        fileIO.LearnDirectories();
    }
} 