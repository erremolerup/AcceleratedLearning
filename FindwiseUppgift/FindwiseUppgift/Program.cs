using System;
using System.Collections.Generic;
using System.IO;

namespace FindwiseUppgift
{
    public class Program
    {
        // *Metoder för att fylla index med innehåll*

        static void Main(string[] args) 
        {
            var simpleSearch = new SimpleSearch();
            SearchForFindwise(simpleSearch);
            SearchForForest(simpleSearch);

            string searchTerm = GetUserInput();
            List<DocumentRatio> result = simpleSearch.Search(searchTerm);
            DisplayResult(result);
        }
       
        private static string GetUserInput()
        {
            Console.WriteLine("Sök på ord:");
            string searchTerm = Console.ReadLine();
            searchTerm = searchTerm.ToLower();

            return searchTerm;
        }

        private static void DisplayResult(List<DocumentRatio> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine($"Document-Id: {item.Id} innehåller sökordet till: {item.Ratio * 100} %");
            }

            if (result.Count == 0)
            {
                Console.WriteLine($"Din sökning innehöll inga träffar...");
            }
        }

        private static void SearchForFindwise(SimpleSearch simpleSearch)
        {
            simpleSearch.UpdateIndex("findwise findwise", 1);
            simpleSearch.UpdateIndex("hej findwise du är kul", 2);
            simpleSearch.UpdateIndex("findwise är kul", 3);
        }

        private static void SearchForForest(SimpleSearch simpleSearch)
        {
            simpleSearch.UpdateIndex(File.ReadAllText("Data/Barrskog.txt"), 1);
            simpleSearch.UpdateIndex(File.ReadAllText("Data/Fjällskog.txt"), 2);
            simpleSearch.UpdateIndex(File.ReadAllText("Data/Lövskog.txt"), 3);
        }
    }
}
