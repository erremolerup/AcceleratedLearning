using System;
using System.Collections.Generic;
using System.Linq;

namespace FindwiseUppgift
{
    public class SimpleSearch
    {
        Dictionary<string, List<DocumentRatio>> index;
        
        // *Konstruktor: skapar nytt tomt index när programmet körs*

        public SimpleSearch()
        {
            index = new Dictionary<string, List<DocumentRatio>>();
        }

        // *Uppdaterar index'et utifrån ett dokument*

        public void UpdateIndex(string content, int documentId) 
        { 
            if (content == null)
            {
                return;
            }

            List<string> allWords = content.Split(new char[] { ' ','.',',' } ).Select(x => x.ToLower()).ToList();
            List<string> uniqueWords = allWords.Distinct().ToList();

            int numberOfWords = allWords.Count();

            foreach (string uniqueWord in uniqueWords)
            {
                // *Räknar ut förekomsten av ordet*

                int wordOccurrence = 0;

                foreach (var word in allWords)
                {
                    if (word == uniqueWord)
                    {
                        wordOccurrence++;
                    }
                }

                // *Beräknar hur populärt ordet är i procent*
                
                decimal occurenceRatio = Math.Round((decimal)wordOccurrence / numberOfWords, 5); 

                if (!index.ContainsKey(uniqueWord)) 
                {
                    index.Add(uniqueWord, new List<DocumentRatio>()); 
                }

                var documentRatio = new DocumentRatio
                {
                    Id = documentId,
                    Ratio = occurenceRatio
                };

                // *Lägger in Id och procent för varje unikt ord*

                index[uniqueWord].Add(documentRatio);
            }
        }

        // *Kollar upp sökordet i index och ordnar efter antal träffar*

        public List<DocumentRatio> Search(string searchterm)
        {
            searchterm = searchterm.ToLower();

            if (index.ContainsKey(searchterm))
            {
                List<DocumentRatio> documentRatios = index[searchterm];

                var result = documentRatios.OrderByDescending(x => x.Ratio).ToList();

                return result;
            }
            else
            {
                return new List<DocumentRatio>();
            }
        }
    }
}
