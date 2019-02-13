using System;
using System.Collections.Generic;
using System.Linq;

namespace FindwiseUppgift
{
    public class SimpleSearch
    {
        Dictionary<string, List<DocumentRatio>> index; //skapar en dictionary index där strängen, id och ratio kan sparas

        public SimpleSearch() //konstruktor: tomt index om vi har gammalt i, måste skapas för att index ska kunna fyllas
        {
            index = new Dictionary<string, List<DocumentRatio>>();
        }

        public void UpdateIndex(string content, int documentId) //kollar ifall ordet är unikt och räknar hur många gånger varje ord förekommer i strängen content
        {
            if (content == null)
            {
                //skicka med fras
                return; // om dokumentet är tomt gör vi inget
            }

            List<string> allWords = content.Split(' ').ToList();
            List<string> uniqueWords = content.Split(' ').Distinct().ToList();

            int numberOfWords = allWords.Count();//räknar totala antalet ord i en fras

            foreach (string uniqueWord in uniqueWords)
            {

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
                    index.Add(uniqueWord, new List<DocumentRatio>()); //tom låda att fylla
                }

                var dr = new DocumentRatio //både om ordet redan rinns och om det inte finns anges även ett id och procentsats, är det per ord eller per "fras"?
                {
                    Id = documentId,
                    Ratio = occurenceRatio
                };
                index[uniqueWord].Add(dr); // exakt vad händer här???
            }
        }

        public List<DocumentRatio> Search(string searchterm)
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
    }
}
