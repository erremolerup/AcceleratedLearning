using System;
using System.Collections.Generic;

namespace Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> listOfRooms = new List<Room>();

            Console.WriteLine("Ange namn på rum:");
            string inputRooms = Console.ReadLine();
            string[] roomsSplit = inputRooms.Split('|');

            string roomNumbers = "1,2,3,4,5,6,7";
            string[] roomNumbersSplit = roomNumbers.Split(',');
            foreach (var unit in roomNumbersSplit)
            {
                roomsSplit.Add(unit);
            }

            foreach (var room in roomsSplit)
            {
                string[] nameSize = room.Split(' ');

                var roomie = new Room();
                roomie.Name = nameSize[0];
                roomie.Size = nameSize[1];
                
            }
        }
    }
}
