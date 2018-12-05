using System;
using System.IO;

namespace Modul9
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new FileSystemWatcher();
            x.Path = @"C:\Users\Administrator\Desktop\TMP";
            x.EnableRaisingEvents = true;
            x.Created += AFileWasCreated;
            x.Changed += AFileWasChanged;
            x.Deleted += AFileWasDeleted;

            Console.WriteLine($"I'm watching this folder: '{watchingPath}'");
            Console.ReadKey();
        }

        private static void AFileWasCreated(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine($"File {file.Name} was created!");
        }
        private static void AFileWasDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("A file was deleted!");
        }

        private static void AFileWasChanged(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine($"File {file.Name} was changed!");
        }
    }

}
