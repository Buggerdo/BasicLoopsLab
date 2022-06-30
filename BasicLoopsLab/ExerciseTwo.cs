using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLab
{
    internal class ExerciseTwo
    {
        public ExerciseTwo()
        {
            int num = Tools.GetInt(0);

            for(int i = num; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for(int i = 0; i <= num; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
