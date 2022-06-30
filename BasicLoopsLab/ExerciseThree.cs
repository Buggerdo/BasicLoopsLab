using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLab
{
    internal class ExerciseThree
    {
        public ExerciseThree()
        {
            bool isDoorLocked = true;
            int code = 13579;
           
            while(isDoorLocked)
            {
                int guess = Tools.GetInt("Hi, please enter the key code: ");

                if(guess==code) isDoorLocked = false;
            }
            Console.Clear();
            Console.WriteLine("The door unlocks");
            Console.WriteLine("Welcome to the outside");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
