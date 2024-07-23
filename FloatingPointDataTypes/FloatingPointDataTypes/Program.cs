using System;

namespace FloatingPointDataTypes
{
    /// <summary>
    /// Floating Point Data Types lecture code 
    /// </summary>

    class MainClass
    {
        /// <summary>
        /// Demonstrates floating point data types
        /// </summary>
        /// <param name="args"></param>        

        public static void Main(string[] args)
        {
            // Program 1

            int score = 1360;
            int totalSecondsPlayed = 10000;

            // calculate and print points per seconds
            float pointsPerSecond = (float)score / totalSecondsPlayed;

            Console.WriteLine("Points per Seconds: " + pointsPerSecond);

            Console.WriteLine("Hello World!");

            // Program 2

            // set values
            const int maxScore = 100;
            int score2 = 50;

            // calculate and print percentage
            float percent = ((int)score2 / maxScore) * 100;
            float percent2 = ((float)score2 / maxScore) * 100;

            Console.WriteLine("Percentage: " + percent + "%");
            Console.WriteLine("Percentage: " + percent2 + "%");


        }
    }
}
