using System;
using System.Collections;

namespace Checkpoint0
//Vi ska skriva en kod som låter användaren ange produkter och sedan trycka på return. 
//När användaren fått nog ska hon skriva exit. Då ska alla produkter visas
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdIn();
        }

        static void ProdIn()
        {
            ArrayList al = new ArrayList();
            
            Console.WriteLine("Skriv in dina valda produkter. Avsluta genom att skriva 'exit'\n");

            string produkt = "";
            bool running = true;
            string produktTemp = ""
  
          while (running)
            {
                produkt = Console.ReadLine(); //Variabeln produkt sätts till användarinput

                produktTemp = produkt.Trim();
                produktTemp = produktTemp.ToLower();

                if (produktTemp == "exit")// om variabeln produkt är exit ska loopen avslutas
                {
                    running = false;
                }
             
                else 
                {
                    al.Add(produkt); //Variabeln produkt läggs till i ArrayList al
                }
            }

            al.Sort(); // Sortering av produkter när listan är klar men innan den skrivs ut

            Console.WriteLine("\nDu angav följande produkter:\n");
            foreach (string item in al) //foreach loop för att skriva ut varje element i en arraylist
            {
                Console.WriteLine(item);
            }

           
        }


    }
}
