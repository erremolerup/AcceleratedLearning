using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint02
{
    class Program
    {
        //METODER
        static void Main(string[] args)
        {
            string rooms = GetRoomsFromUser();
            List<Room> listOfRooms = CreateListOfRooms(rooms);
            PrintRooms(listOfRooms);
            PrintLargestRoom(listOfRooms);

            Console.WriteLine();
        }

        //Be användaren mata in rum och storlek på rum
        //Returnera user input till string
        private static string GetRoomsFromUser()
        {
            Console.WriteLine("Ange namn på rum: ");
            string rooms = Console.ReadLine();
            return rooms;
        }

        //Gör en första split av user input-string till en array
        //Gör sedan en split per rum i arrayen och använd index för att koppla namn och storlek till rum/m2
        //Eftersom det inte går att parsea 40m2 som en string måste m2 tas bort, görs genom replace m2 till ingenting ""
        //Addera varje rum till listOfRooms
        //Returnera listOfRooms
        private static List<Room> CreateListOfRooms(string rooms)
        {
            string[] roomsArray = rooms.Split('|');
            List<Room> listOfRooms = new List<Room>();

            foreach (var room in roomsArray)
            {
                string[] splitRooms = room.Trim().Split(' ');

                var roomie = new Room();
                roomie.Name = splitRooms[0].ToString();
                roomie.Size = int.Parse(splitRooms[1].Replace("m2", ""));
                listOfRooms.Add(roomie);
            }
            return listOfRooms;
        }

        //Skapa en counter som börjar vid 1
        //Skriv ut rumnamn och nummer med countern
        private static void PrintRooms(List<Room> listOfRooms)
        {
            Console.WriteLine();
            int counter = 1;

            foreach (var room in listOfRooms)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"* Rumnamn {counter}: {room.Name}");
                counter++;
                Console.ResetColor();
            }
        }

        //Ordna rummen i storleksordning, i fallande ordning
        //Skapa en ny variabel för största rummet och ta det första numret i ordningen (det största)
        private static void PrintLargestRoom(List<Room> listOfRooms)
        {
            var roomsOrderedBySize = listOfRooms.OrderByDescending(x => x.Size);
            var largestRoom = roomsOrderedBySize.First();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Det största rummet är {largestRoom.Name} på {largestRoom.Size}m2");
            Console.ResetColor();
        }
    }
}
