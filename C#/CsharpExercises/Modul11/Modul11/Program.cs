using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul11
{
    class Program
    {
        static double sum;
        static List<int> list = new List<int> { 3, 10, 7 };
        static List<int> listHigherThanFive = new List<int>();
        static List<string> listStars = new List<string>();

        public static void Main(string[] args)
        {

            //TODO: en funktion som summerar en lista av heltal med och utan Linq
            //TODO: en funktion som tar listan med heltal och returnerar medelvärde med och utan Linq
            //TODO: en funktion som tar listan med heltal och sätter ** på varje sida om ett tal

            //Summera UTAN Linq
            //SumListNumbers(list);

            //Summera MED Linq;
            //SumListNumbersLinq(list);

            //Average UTAN Linq
            //AverageListNumbers(list);

            //Average MED Linq
            //AverageListNumbersLinq(list);

            //Skriv ut alla nummer högre än fem UTAN Linq
            //List<int> numberHigherThanFive = numberHigherThanFIve(list)
            //NumberHigherThanFive(list);
            //DisplayNumbers(listHigherThanFive);

            //Skriv ut alla nummer högre än fem MED Linq
            //List<int> listHigherThanFive = new listHigherThanFive(list);
            //NumberHigherThanFiveLinq(list);
            //DisplayNumbers(listHigherThanFive);

            //Stars UTAN Linq
            NumbersWithStars(list);
            DisplayNumbers(listStars);

            //Stars MED Linq
            NumbersWithStarsLinq();
            DisplayNumbers(listStars);
        }

        //METODER SOM PRINTAR
        private static void DisplayNumbers(List<string> listStars)
        {
            foreach (var number in listStars)
            {
            Console.WriteLine(number);
            }
            //{string.Join(",", starslist)}")
        }

        private static void DisplayNumbers(List<int> listHigherThanFive)
        {
            foreach (var number in listHigherThanFive)
            {
                Console.WriteLine(number);
            }
        }

        //METODER SOM GÖR NÅGOT
        public static double SumListNumbers(List<int> list)
        {
            foreach (var number in list)
            {
                sum += number;
            }
            return sum;
        }

        private static void SumListNumbersLinq(List<int> list)
        {
            double avg = sum / list.Count;
            //Console.WriteLine(avg);
            Console.WriteLine($"Sum: {list.Sum()}");
        }

        private static void AverageListNumbers(List<int> list)
        {
            foreach (var number in list)
            {
                sum += number;
            }
            //var avg = ((list[0] + list[1] + list[3])/list.Count);
            //Console.WriteLine(avg);
        }

        private static void AverageListNumbersLinq(List<int> list)
        {
            double average = list.Average();
            //Console.WriteLine(average);
            Console.WriteLine($"Average: {list.Average()}");
        }

        public static void NumberHigherThanFive(List<int> list)
        {
            //var listHigherThanFive = new List<int>();

            foreach (var number in list)
            {
                if (number > 5)
                {
                    listHigherThanFive.Add(number);
                }
            }
        }

        private static void NumberHigherThanFiveLinq(List<int> list)
        {
            foreach (int number in list.Where(number => number > 5))
            {
                listHigherThanFive.Add(number);
            }
            //List<int> listHigherThanFive = list.Where(number => number > 5).ToList();
        }

        private static void NumbersWithStars(List<int> list)
        {
            foreach (var number in list)
            {
                listStars.Add("*" + number + "*");
            }
        }

        private static void NumbersWithStarsLinq()
        {
            List<string> listStars = list.Select(number => "*" + number + "*").ToList();
        }
    }
}
