using System;
using System.Collections.Generic;

namespace Repetition_Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listOfAnimals = new List<Animal>();
            
            var animal1 = new Animal(4, "Erika");

            string inputAnimals = "Doris,4;Gösta,4;Curry,4";
            string[] animals = inputAnimals.Split(';');

            foreach (var animal in animals)
            {
                string[] nameAge = animal.Split(',');

                var dog = new Dog();
                dog.Name = nameAge[0];
                dog.Age = int.Parse(nameAge[1]);
                listOfAnimals.Add(dog);
            }

            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine($"{animal.Name} is {animal.Age} years old");
            }

            string inputHorses = "Ann Lucky,19;Kovo,6;Nala,3;Black Lotus,27";
            string[] horses = inputHorses.Split(';');

            foreach (var item in horses)
            {
                string[] nameAge = item.Split(',');

                var horse = new Horse();
                horse.Name = horses[0];
                horse.Age = int.Parse(horses[1]);
                listOfAnimals.Add(horse);
            }

            foreach (var animal in listOfAnimals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine($"{animal.Name} is a dog and {animal.Age} years old");
                }
            }
        }
    }
}
