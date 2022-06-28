using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLab
{
    internal class Program
    {
       static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose an exercise");
                Console.WriteLine("Exercises 1 - 5");
                Console.WriteLine("Exit to quit");
                string choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();


                switch(choice)
                {
                    case "1":
                        _ = new ExerciseOne(); // starts the first exersise Hello, World!
                        break;
                    case "2":
                        _ = new ExerciseTwo(); // starts the second exersise 5 4 3 2 1 0 0 1 2 3 4 5
                        break;
                    case "3":
                        _ = new ExerciseThree(); // starts the third exersise The combination to get in is 13579
                        break;
                    case "4":
                        _ = new ExerciseFour(); // starts the forth exersise The combination to get in is 13579 While Loop
                        break;
                    case "5":
                        _ = new ExerciseFive(); // starts the fifth exersise The combination to get in is 13579 Do While Loop
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                } 
            } while(true);
        }
    }
}
