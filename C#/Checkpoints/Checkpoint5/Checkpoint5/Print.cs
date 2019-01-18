using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnomes
{
    public class Print
    {
        DataAccess _dataAccess = new DataAccess();

        internal void Run()
        {
            List<Gnome> gnomes = _dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);
        }

        private void DisplayGnomes(List<Gnome> gnomes)
        {
            Header("Tomtar: ");
            ShowAllGnomes();
        }

        private void ShowAllGnomes()
        {
            List<Gnome> list = _dataAccess.GetGnomesFromDatabase();
            foreach (var item in list)
            {
                Console.Write(item.Id.ToString().PadRight(10));
                Console.Write(item.Name);
                Console.WriteLine();
            }
        }

        private void Header(string v)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v.ToUpper());
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
