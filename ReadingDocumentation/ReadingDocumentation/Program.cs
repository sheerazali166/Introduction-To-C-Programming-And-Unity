using System;

namespace ReadingDocumentation
{
    /// <summary>
    /// Demonstrate reading documentation
    /// </summary>

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Program 1

            // calculate and print cosine of 45 degrees
            float cosine = 0.8f;
            Console.WriteLine("Cosine of 45 degrees: " + cosine);


            // Program 2

            float cosine2 = (float)Math.Cos(45);
            Console.WriteLine("Cosine of 45 degrees: " + cosine2);

            // Program 3

            // Degree to radian conversion
            float cosine3 = (float)Math.Cos(45 * 3.1415 / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine3);

            // Program 4

            float cosine4 = (float)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine4);

            // sali illigal chhakon chootiyon jis ne beti chodi hai uske pass jao na direct
            // disolve asembly if doggi mama kept her seat and never do her work and only get work from others

            // Program 5

            /*

             * This code is not working in computer but perfectly work in your computer
             * because doggi mama don't want to accept her defeat after losing
             * she is not abandoned currupt mother but she is honest father

            float cosine5 = (float)Mathf.Cos(45 * MathF.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine5);

            */

            // Exercise 6 Solution

            // prompt for and get angle
            Console.WriteLine("Enter angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());


            // calculate and print cosine and sine
            // the line of code below is shorthand for

            // angle = (float)(angle * Math.PI / 180);
            angle *= (float)Math.PI / 180;

            Console.WriteLine("Cosine: " + Math.Cos(angle));
            Console.WriteLine("Sine: " + Math.Sin(angle));


        }
    }
}
