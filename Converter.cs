using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Distance Converter App!");
            Console.WriteLine("Please select an option from the menu:");
            Console.WriteLine("1. Miles to Feet");
            Console.WriteLine("2. Feet to Miles");
            Console.WriteLine("3. Miles to Meters");
            Console.WriteLine("4. Meters to Miles");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MilesToFeet();
                    break;
                case 2:
                    FeetToMiles();
                    break;
                case 3:
                    MilesToMeters();
                    break;
                case 4:
                    MetersToMiles();
                    break;
                default:
                    Console.WriteLine("Invalid option selected. Please try again.");
                    break;
            }
        }

        static void MilesToFeet()
        {
            Console.WriteLine("Please enter a distance in miles:");
            double miles = Convert.ToDouble(Console.ReadLine());
            double feet = miles * 5280;
            Console.WriteLine("{0} miles is equal to {1} feet.", miles, feet);
        }

        static void FeetToMiles()
        {
            Console.WriteLine("Please enter a distance in feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            double miles = feet / 5280;
            Console.WriteLine("{0} feet is equal to {1} miles.", feet, miles);
        }

        static void MilesToMeters()
        {
            Console.WriteLine("Please enter a distance in miles:");
            double miles = Convert.ToDouble(Console.ReadLine());
            double meters = miles * 1609.344;
            Console.WriteLine("{0} miles is equal to {1} meters.", miles, meters);
        }

        static void MetersToMiles()
        {
            Console.WriteLine("Please enter a distance in meters:");
            double meters = Convert.ToDouble(Console.ReadLine());
            double miles = meters / 1609.344;
            Console.WriteLine("{0} meters is equal to {1} miles.", meters, miles);
        }
    }
}
