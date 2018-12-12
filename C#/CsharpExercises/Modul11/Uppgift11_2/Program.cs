using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Uppgift11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = CreateListOfCustomers("CustomerShort.txt");
            DisplayCustomersByAge(list);
            DisplayCustomersByFirstName(list);
            MenOlderThan35(list);
            DisplayManipulate(MenOlderThan35);
        }

        private static void DisplayManipulate(Action<List<Customer>> menOlderThan35)
        {
            Console.WriteLine("Manipulated list: ");
            var manipulatedList = menOlderThan35.Select(cw => new Customer
            {
                Id = c.Id,
                Age = c.Age + 1000,
                FirstName = A + c.Name,

            });
        }

        private static void MenOlderThan35(List<Customer> list)
        {
            Console.WriteLine("Men older than 35: ");
            var sortedMenOlderThan35 = list.Where(customer => customer.Age > 35).ToList();

            foreach (var item in sortedMenOlderThan35)
            {
                PrintCustomerInfo(item);
            }
            Console.WriteLine();

        }

        private static void DisplayCustomersByFirstName(List<Customer> list)
        {
            Console.WriteLine("Sorted list by firstname: ");
            var sortedByFirstname = list.OrderBy(customer => customer.FirstName).ToList();

            foreach (var item in sortedByFirstname)
            {
                PrintCustomerInfo(item);
            }
            Console.WriteLine();
        }

        private static void DisplayCustomersByAge(List<Customer> list)
        {
            Console.WriteLine("Sorted list by age: ");
            var sortedByAge = list.OrderBy(customer => customer.Age).ToList();

            foreach (var item in sortedByAge)
            {
                PrintCustomerInfo(item);
            }
            Console.WriteLine();
        }

        private static void PrintCustomerInfo(Customer item)
        {
            Console.WriteLine($"{item.FirstName.PadRight(20)} {item.Age.ToString().PadRight(20)}{item.Gender}");
        }

        private static List<Customer> CreateListOfCustomers(string textFile)
        {
            string[] allLines = File.ReadAllLines(textFile);
            List<Customer> CustomerInfo = new List<Customer>();

            foreach (var line in allLines)
            {
                string[] customerLine = line.Split(',');
                Customer customer = new Customer();

                customer.Id = int.Parse(customerLine[0]);
                customer.FirstName = customerLine[1];
                customer.LastName = customerLine[2];
                customer.Email = customerLine[3];
                customer.Gender = (Gender)Enum.Parse(typeof(Gender), customerLine[4]);
                customer.Age = int.Parse(customerLine[5]);

                CustomerInfo.Add(customer);
            }
            return CustomerInfo;
        }
    }
}
