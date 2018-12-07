using System;
using System.Collections.Generic;

namespace Checkpoint_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> listOfRooms = new List<Room>();
            //List<Room> listOfUnits = new List<Room>();
            List<Room> numberOfRooms = new List<Room>();

            Console.WriteLine("Ange namn på rum: ");
            string inputRooms = Console.ReadLine();

            string[] rooms = inputRooms.Split('|');

            foreach (var unit in rooms)
            {
                string[] nameSize = unit.Split(' ');

                //for (int i = 0; i < unit.Length; i++)
                //{
                //    string s = nameSize[1];
                //    string sPart1 = s.Substring(0, 2);
                //    string sPart2 = s.Substring(2, 2);
                //}

                //var result = new List<string>();
                //int counter = 1;
                //foreach (var item in nameSize)
                //{
                //    string newItem;

                //    if (counter % 2 == 0)
                //        newItem = item.Substring(0, 2);
                //    else
                //        newItem = item;

                //    result.Add(newItem);

                //    counter++;
                //}
                var room = new Room
                {
                    Name = nameSize[0],
                    Size = nameSize[1]
                };

                //string sU = (sPart1);
                //room.sU = int.Parse(sPart1);
                listOfRooms.Add(room);
            }
            //string roomNumbers = "1,2,3,4,5,6";
            //foreach (int room in roomNumbers)
            //{
            //    string[] numbers = roomNumbers.Split(',');
            //    int roomNumber = new Room();
            //    roomNumber.Number = int.Parse(roomNumbers[0]);
            //    listOfRooms.Add(roomNumber);
            //}


            foreach (var room in listOfRooms)
            {
                Console.WriteLine($"* Rumnamn: {room.Name} {room.Size}");
            }
        }
    }
}
