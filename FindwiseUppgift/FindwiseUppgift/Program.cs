using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FindwiseUppgift
{
    public class Program
    {
        static Dictionary<string, List<DocumentRatio>> index; //skapar en dictionary index där strängen, id och ratio kan sparas

        static void Main(string[] args) //metoder för att fylla index med innehåll
        {
            //ResetIndex();
            CreateIndex();
            string searchTerm = GetUserInput();
            List<DocumentRatio> result = Search(searchTerm);
            DisplayResult(result);
        }

        private static void CreateIndex() //skapar index-innehåll med id 1, 2 och 3
        {
            UpdateIndex("findwise findwise", 1);
            UpdateIndex("hej findwise", 2);
            UpdateIndex("findwise är kul", 3);
        }

        public static void ResetIndex() //tomt index om vi har gammalt i
        {
            index = new Dictionary<string, List<DocumentRatio>>();
        }

        public static void UpdateIndex(string content, int documentId) //kollar ifall ordet är unikt och räknar hur många gånger varje ord förekommer i strängen content
        {
            if (content == null)
            {
                return; // om content är tom returnerar vi inget
            }

            List<string> allWords = content.Split(' ').ToList();
            List<string> uniqueWords = content.Split(' ').Distinct().ToList();

            foreach (string uniqueWord in uniqueWords)
            {
                int numberOfWords = allWords.Count();//räknar totala antalet ord i en fras
                //int numberOfUniqueWords = uniqueWords.Count(); behövs ej?

                int wordOccurrence = 0; //jämför word i uniqueWords med item i allWords, ökar med ett för varje match

                foreach (var word in allWords)
                {
                    if (word == uniqueWord) 
                    {
                        wordOccurrence++;
                    }
                }

                // Alternativ med linq: int counter2 = allWords.Count(w => w == uniqueWord);

                decimal occurenceRatio = (decimal)wordOccurrence / numberOfWords; //räknar ut hur många procent sökordet upptar av varje fras genom att ta hur många gånger ordet förekommer i strängen / antalet totala ord

                if (!index.ContainsKey(uniqueWord)) //om ordet inte redan finns i index adderas det och en tom lista till index
                {
                    index.Add(uniqueWord, new List<DocumentRatio>());
                }

                var dr = new DocumentRatio //både om ordet redan rinns och om det inte finns anges även ett id och procentsats, är det per ord eller per "fras"?
                {
                    Id = documentId,
                    Ratio = occurenceRatio
                };
                index[uniqueWord].Add(dr); // exakt vad händer här???
            }
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Sök på ord:");
            string searchTerm = Console.ReadLine();
            searchTerm = searchTerm.ToLower();

            return searchTerm;
        }

        public static List<DocumentRatio> Search(string searchterm)
        {
            if (index.ContainsKey(searchterm))
            {
                List<DocumentRatio> documentRatios = index[searchterm]; //vad händer här i ord?

                var result = documentRatios.OrderByDescending(x => x.Ratio).ToList();

                return result;
            }
            else
            {
                return new List<DocumentRatio>(); // annars returnerar man en tom lista?
            }
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


        //public static void CreateIndex_Hardcoded()
        //{
        //    var documentRatioList1 = new List<DocumentRatio>();

        //    var documentratio1 = new DocumentRatio
        //    {
        //        Id = 1,
        //        Ratio = .25m
        //    };
        //    var documentratio2 = new DocumentRatio
        //    {
        //        Id = 2,
        //        Ratio = .50m
        //    };

        //    documentRatioList1.Add(documentratio1);
        //    documentRatioList1.Add(documentratio2);

        //    var stringText = "doris";

        //    index.Add(stringText, documentRatioList1);

        //    var documentRatioList2 = new List<DocumentRatio>();

        //    var documentratio3 = new DocumentRatio
        //    {
        //        Id = 1,
        //        Ratio = .25m
        //    };
        //    documentRatioList2.Add(documentratio3);
        //    index.Add("hund", documentRatioList2);
        //}
    }
}
