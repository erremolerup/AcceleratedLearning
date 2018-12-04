using System;
using System.IO;

namespace Uppgift8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilestuff();
            //WriteToFile();
        }

        private static void WriteToFile()
        {
            string text = "Beckis gillar hundar";

            File.WriteAllText(@"C:\Projekt\Beckisärbäst.txt", text);
        }

        private static void WriteFilestuff()
        {
            Console.Write("Enter a file name: ");
            Console.ForegroundColor = ConsoleColor.Green;

            string fileName = Console.ReadLine();

            try
            {
                File.CreateText(fileName);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I guess there is no such thing....");
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("A new file was created.");
            Console.WriteLine();
        }
    }
}
