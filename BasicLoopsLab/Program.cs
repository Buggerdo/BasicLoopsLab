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
                        _ = new ExerciseOne(); // starts the first exersice
                        break;
                    case "2":
                        _ = new ExerciseTwo(); // starts the second exersice
                        break;
                    case "3":
                        _ = new ExerciseThree(); // starts the third exersice
                        break;
                    case "4":
                        _ = new ExerciseFour(); // starts the forth exersice
                        break;
                    case "5":
                        _ = new ExerciseFive(); // starts the fifth exersice
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                } 
            } while(true);
        }
    }
}
