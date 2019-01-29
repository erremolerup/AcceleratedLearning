using System;
using System.Collections.Generic;
using System.Linq;

namespace RepetitionCheckpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rooms = "Vardagsrum 40m2 On | Kök 20m2 On"; // GetRoomsFromUser();
            List<Rooms> listOfRooms = CreateListOfRooms(rooms);
            PrintRooms(listOfRooms);
            PrintLargestRoom(listOfRooms);
            PrintLightOnOrOff(listOfRooms);
            PrintNumberOfRooms(rooms);
        }

        private static void PrintNumberOfRooms(string rooms)
        {
            string[] roomsArray = rooms.Split('|');

            var numberOfRooms = roomsArray.Count();

            Console.WriteLine($"Lägenheten består av {numberOfRooms} rum");
        }

        private static void PrintLightOnOrOff(List<Rooms> listOfRooms)
        {
            foreach (var room in listOfRooms)
            {
                
                if (room.LightOnOrOff == true)
                {
                    Console.WriteLine($"Ljuset är tänt i {room.Name}");
                }
                else
                {
                   
                }


            }

           
        }

        private static string GetRoomsFromUser()
        {
            Console.WriteLine("Ange namn, storlek och om lyset är på i ett rum: ");
            string rooms = Console.ReadLine();
            return rooms;
        }

        private static List<Rooms> CreateListOfRooms(string rooms)
        {
            string[] roomsArray = rooms.Split('|');

            List<Rooms> listOfRooms = new List<Rooms>();

            foreach (var room in roomsArray)
            {
                string[] splitRooms = room.Trim().Split(' ');

                bool x;
                if (splitRooms[2] == "On")
                {
                    x = true;
                }
                else
                {
                    x = false;
                }

                var roomie = new Rooms
                {
                    Name = splitRooms[0],
                    Size = int.Parse(splitRooms[1].Replace("m2", " ")),
                    LightOnOrOff = x
                };
                listOfRooms.Add(roomie);
            }
            return listOfRooms;
        }

        private static void PrintRooms(List<Rooms> listOfRooms)
        {
            Console.WriteLine();
            int counter = 1;

            foreach (var room in listOfRooms)
            {
                Console.WriteLine($"* Rumnamn {counter}: {room.Name}");
                counter++;
            }
        }

        private static void PrintLargestRoom(List<Rooms> listOfRooms)
        {
            var roomsOrderedBySize = listOfRooms.OrderByDescending(x => x.Size);
            var largestRoom = roomsOrderedBySize.First();

            Console.WriteLine($"Det största rummet är {largestRoom.Name} på {largestRoom.Size}m2");
        }
    }
}
