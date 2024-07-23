using System;

namespace IntegerAndDataTypes
{
    /// <summary>
    /// Integers Data Types lecture code
    /// </summary>

    class MainClass
    {
        /// <summary>
        /// 1. Demonstrates integer data types
        /// 2. Practice, declaring, assigning and printing a variable
        /// 3. Calculate altitude change between two locations
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {

            // Program 1
        
            int totalsecondsPlayed = 100;
            const int secondPerMinute = 60;


            // Calculate minutes and seconds palyed
            int minutesPlayed = totalsecondsPlayed / 60;

            int secondsPlayed = totalsecondsPlayed % secondPerMinute;


            // Print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

            Console.WriteLine("Hello World!");


            // Program 2

            // declare, assign and print a variable
            int age;
            age = 42;

            Console.WriteLine("Age: " + age);


            // Program 3

            // get locations

            Console.WriteLine("Enter altitude at first location: ");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter altitude at second location: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            // Calculate and print altitude change
            int altitudeChange = secondAltitude - firstAltitude;

            Console.WriteLine();
            Console.WriteLine("Altitude change: " + altitudeChange);

        }
    }
}
