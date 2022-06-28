using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLab
{
    internal class ExerciseFive
    {
        public ExerciseFive()
        {
            bool isDoorLocked = true;
            int code = 13579;
            int guess;
            int numOfGuesses = 1;

            do
            {
                guess = Tools.GetInt("Hi, please enter the key code: ");
                if(guess == code)
                {
                    isDoorLocked = false;
                    Console.Clear();
                    Console.WriteLine("The door unlocks");
                    Console.WriteLine("Welcome to the outside");
                    Console.WriteLine($"It took you {numOfGuesses} tries to unlock the door");
                }
                numOfGuesses++;
                if(numOfGuesses > 5)
                {
                    Console.WriteLine("Too many incorrect attempts");
                    break;
                }
            } while(isDoorLocked);
            
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
