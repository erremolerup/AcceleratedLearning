using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class ConsoleHelper
    {
        internal static string AskForUserName()
        {
            Console.Write("Enter username: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
