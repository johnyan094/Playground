using PinGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using TheCatOnTheMat;

namespace Playground
{
    class Program
    {
        private static int PinSet = 10;
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            //Generate pins with conditions
            GeneratePins();

            Console.WriteLine();

            //find word from sentence that occured the most
            TheCatOnTheMat();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void GeneratePins()
        {
            IRandomNumber rdn = new RandomNumber();
            Generate generator = new Generate(rdn);

            List<string> pinList = new List<string>();

            int counter = 0;

            while (counter < PinSet)
            {
                var pin = generator.GenreatePin();
                pinList.Add(pin);

                counter++;

                Console.WriteLine(pin);
            }
        }

        private static void TheCatOnTheMat()
        {
            string test = "The Cat On The Mat";
            var result = TheCatOnTheMatChecker.TheCatOnTheMat(test);

            Console.WriteLine(result);
        }
    }
}
