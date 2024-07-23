using System;

namespace Debuging_a_ConsoleApp
{
    /// <summary>
    /// Demonstrate debugging a console app
    /// </summary>

    class MainClass
    {
        public static void Main(string[] args)
        {
            float angle;

            // Prompt for and get angle
            Console.WriteLine("Enter angle in degrees: ");
            angle = float.Parse(Console.ReadLine());

            // convert angle to radians
            // angle *= (float)180 / (float)Math.PI;
            angle *= (float)Math.PI / 180;

            // calculate and print cos and sin
            Console.WriteLine(Math.Cos(angle));
            Console.WriteLine(Math.Sin(angle));

        }
    }
}
