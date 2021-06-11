using System;

namespace MethodExercise
{
    class Program
    {
        /* Exercise 1: includes AskAndRespond method */
        public static string AskAndRespond(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /* Exercise 2: includes the next 5 operator methods (+ - * / % ) */
        public static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static int Divide(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }

        public static int Modulus(int numberOne, int numberTwo)
        {
            return numberOne % numberTwo;
        }

        static void Main(string[] args)
        {
            /* Exercise 1 - excutes a mad libs game. uses method AskAndRespond */
            Console.WriteLine("Welcome to Danielle's Mini Mad Libs Game!!");
            Console.WriteLine("Please answer the following questions.");
            Console.WriteLine("Press enter to begin.");
            Console.ReadLine();

            var name = AskAndRespond("What is your name?");
            var color = AskAndRespond("What is your favorite color?");
            var animal = AskAndRespond("What is your farvorite animal?");
            var band = AskAndRespond("What is your favorite band?");
            var number = Convert.ToInt32(AskAndRespond("What is your favorite number?"));

            Console.WriteLine($"{name} decided to take a trip to the beach. {name} then saw a {animal}, which startled {name} because it was {color}.");
            Console.WriteLine($"To clear the air {name} took a deep breath and counted to {number}.");
            Console.WriteLine($"Afterwards, {name} put on some headphones and listened to {band} for the rest of the trip.");

            /*Exercise 2 - uses operator methods (+ - * / %) */ 
            int numStudents = Add(30, 17);
            Console.WriteLine($"There are {numStudents} students in my art class.");

            int numDogs = Subtract(22, 6);
            Console.WriteLine($"We found {numDogs} stray dogs in the city.");

            int numPizza = Multiply(20, 2);
            Console.WriteLine($"The office ordered {numPizza} pizzas to feed all the employees.");

            int numComputers = Divide(80, 10);
            Console.WriteLine($"The IT department was responsible for updating {numComputers} computers.");

            int numLawns = Modulus(12, 8);
            Console.WriteLine($"Scott has {numLawns} lawns left to mow this afternoon.");

        }

    }
}
