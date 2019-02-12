using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FindwiseUppgift
{
    public class Program
    {

        static void Main(string[] args) //metoder för att fylla index med innehåll
        {
            var simpleSearch = new SimpleSearch();

            simpleSearch.UpdateIndex("findwise findwise", 1);
            simpleSearch.UpdateIndex("hej findwise", 2);
            simpleSearch.UpdateIndex("findwise är kul", 3);

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
    }
}
