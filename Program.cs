using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace CarManagement
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string RegistrationNumber { get; set; }
        public string OwnerName { get; set; }
    }

    public class CarManagement
    {
        private static object RegisterCar()
        {
            Console.WriteLine("Make: [Car Model]");
            string carMake = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Model: [Car Model]");
            string carModel = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Year: [Car Year]");
            string carYear = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Registration Number: [Registration number]");
            string registrationNumber = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Registration Number: [Registration number]");
                registrationNumber = Console.ReadLine();
                if (registrationNumber.Length == 6)
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Owner: [Owner Name]");
            string ownerName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Thanks for registering your car with us.");
            Car car = new Car()
            {
                Make = carMake, Model = carModel, Year = carYear, RegistrationNumber = registrationNumber, OwnerName = ownerName
            };
            return car;
        }
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Register car");
                Console.WriteLine("2. Search for car");
                string? userInput = Console.ReadLine();
                Menu(userInput);
            }
        }

        private static void Menu(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Car car = (Car)RegisterCar();
 
                break;

                case "2":   

                break;
            }
        }
    }
}
