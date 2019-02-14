using System;
using System.Collections.Generic;
using System.Linq;

namespace FindwiseUppgift
{
    public class SimpleSearch
    {
        Dictionary<string, List<DocumentRatio>> index; //skapar en dictionary index där strängen, id och ratio kan sparas
        
        // *Konstruktor: skapar nytt tomt index när programmet körs*

        public SimpleSearch() //konstruktor: tomt index om vi har gammalt i, måste skapas för att index ska kunna fyllas
        {
            index = new Dictionary<string, List<DocumentRatio>>();
        }

        // *Uppdaterar index'et utifrån ett dokument*

        public void UpdateIndex(string content, int documentId) //kollar ifall ordet är unikt och räknar hur många gånger varje ord förekommer i strängen content
        {
            if (content == null)
            {
                return; // om dokumentet är tomt gör vi inget, inget innehåll så ingen kan hitta det i en sökning
            }

            List<string> allWords = content.Split(new char[] { ' ','.',',' } ).Select(x => x.ToLower()).ToList();
            List<string> uniqueWords = allWords.Distinct().ToList();

            bool test = uniqueWords.Any(x => x == "träd");

            int numberOfWords = allWords.Count();//räknar totala antalet ord i en fras

            foreach (string uniqueWord in uniqueWords)
            {

                // *Räknar ut förekomsten av ordet*

                int wordOccurrence = 0; //jämför word i uniqueWords med item i allWords, ökar med ett för varje match

                foreach (var word in allWords)
                {
                    if (word == uniqueWord)
                    {
                        wordOccurrence++;
                    }
                }

                // Alternativ med linq: int counter2 = allWords.Count(w => w == uniqueWord);

                // *Beräknar hur populärt ordet är i procent*
                
                decimal occurenceRatio = Math.Round((decimal)wordOccurrence / numberOfWords, 5); //räknar ut hur många procent sökordet upptar av varje fras genom att ta hur många gånger ordet förekommer i strängen / antalet totala ord

                if (!index.ContainsKey(uniqueWord)) //om ordet inte redan finns i index adderas det och en tom lista till index
                {
                    index.Add(uniqueWord, new List<DocumentRatio>()); //tom låda att fylla
                }

                var documentRatio = new DocumentRatio //både om ordet redan rinns och om det inte finns anges även ett id och procentsats, är det per ord eller per "fras"?
                {
                    Id = documentId,
                    Ratio = occurenceRatio
                };

                // Lägger in Id och procent för varje unikt ord

                index[uniqueWord].Add(documentRatio); // öppnar skåpet och skriver in dr i listan
            }
        }

        // Kollar upp sökordet i index och ordnar efter antal träffar

        public List<DocumentRatio> Search(string searchterm)
        {
            searchterm = searchterm.ToLower();

            if (index.ContainsKey(searchterm))
            {
                List<DocumentRatio> documentRatios = index[searchterm]; //slår upp sökordet i index och ser vad som ligger bakom det, dvs listan med id och ratio

                var result = documentRatios.OrderByDescending(x => x.Ratio).ToList();

                return result;
            }
            else
            {
                return new List<DocumentRatio>(); // annars returnerar man en tom lista
            }
        }
    }
}
