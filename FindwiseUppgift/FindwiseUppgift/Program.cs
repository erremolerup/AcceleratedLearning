using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FindwiseUppgift
{
    class Program
    {

        static Dictionary<string, List<DocumentRatio>> index = new Dictionary<string, List<DocumentRatio>>();

        static void Main(string[] args)
        {
            //Dic1();

            //Dic2();
            //Dic3();

            //Dic4();

            CreateIndex("min hund doris heter doris", 1);
            CreateIndex("hej doris", 2);
            Console.WriteLine("Sök på ord:");
            string searchterm = Console.ReadLine();

            List<DocumentRatio> result = Search(searchterm);
            DisplayResult(result);

        }

        private static void DisplayResult(List<DocumentRatio> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine("Document-Id: " + item.Id + " " + item.Ratio * 100 + "%");
            }

            if (result.Count == 0)
            {
                Console.WriteLine($"Din sökning innehöll inga träffar...");
            }
        }

        private static List<DocumentRatio> Search(string searchterm)
        {
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

        public static void CreateIndex(string content, int documentId)
        {
            // min hund doris heter doris
            // hej doris

            // 1) plocka ut orden
            // 2) lägg in dem i index'et


            List<string> allWords = content.Split(' ').ToList();
            List<string> uniqueWords = content.Split(' ').Distinct().ToList();

            foreach (string word in uniqueWords)
            {
                int numberOfWords = allWords.Count();
                int numberOfUniqueWords = uniqueWords.Count();

                var counter = 0;
                foreach (var item in allWords)
                {
                    if (item == word)
                    {
                        counter++;
                    }
                }

                decimal ratio = (decimal)counter / numberOfWords;

                // kolla om "doris" finns i index'et

                if (!index.ContainsKey(word))
                {
                    index.Add(word, new List<DocumentRatio>());
                }

                var dr = new DocumentRatio
                {
                    Id = documentId,
                    Ratio = ratio
                };

                index[word].Add(dr);
            }


        }

        public static void CreateIndex_Hardcoded()
        {
            var documentRatioList1 = new List<DocumentRatio>();

            var documentratio1 = new DocumentRatio
            {
                Id = 1,
                Ratio = .25m
            };
            var documentratio2 = new DocumentRatio
            {
                Id = 2,
                Ratio = .50m
            };

            documentRatioList1.Add(documentratio1);
            documentRatioList1.Add(documentratio2);

            var stringText = "doris";

            index.Add(stringText, documentRatioList1);

            var documentRatioList2 = new List<DocumentRatio>();

            var documentratio3 = new DocumentRatio
            {
                Id = 1,
                Ratio = .25m
            };
            documentRatioList2.Add(documentratio3);
            index.Add("hund", documentRatioList2);
        }




        private static void Dic4()
        {
            var d4 = new Dictionary<string, List<Cup>>();
            var cupList = new List<Cup>();
            var cup1 = new Cup
            {
                Color = "green",
                Contains = "coffee"
            };
            var cup2 = new Cup
            {
                Color = "blue",
                Contains = "tea"
            };

            cupList.Add(cup1);
            d4.Add("Erikas koppar", cupList);


            List<Cup> cups = d4["Erikas koppar"];
            foreach (Cup cup in cups)
            {
                Console.WriteLine(cup.Color);

            }


        }

        private static void Dic3()
        {
            var d2 = new Dictionary<int, Person>();
            var person = new Person();
            person.Age = 23;
            person.Name = "Erika";
            d2.Add(3, person);

            d2.Add(4, new Person
            {
                Age = 27,
                Name = "Oscar"
            });

            Console.WriteLine(d2[3].Age);
        }

        private static void Dic2()
        {
            var d1 = new Dictionary<int, string>();
            d1.Add(100, "din");
            d1.Add(20, "häst");

            Console.WriteLine(d1[20]);



        }

        private static void Dic1()
        {
            var d1 = new Dictionary<string, int>();

            d1.Add("min", 100);
            d1.Add("hund", 33);

            d1.Add("katt", 444);

            int x = d1["katt"];
            Console.WriteLine(x);
            Console.WriteLine(d1["min"]);
            // Console.WriteLine(d1["bil"]); // Sur!

            if (d1.ContainsKey("katt"))
            {
                Console.WriteLine("Katt finns med");
            }


        }
    }
}
