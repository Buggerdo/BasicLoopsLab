using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLab
{
    internal class Tools
    {

        /// <summary>
        /// Checks to see if user wants to continue
        /// </summary>
        /// <returns>true or false</returns>
        public static bool IsYes()
        {
            do
            {              
                Console.Write("Would you like to continue (Y/N)? ");
                string awnser = Console.ReadLine().ToLower().Trim();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
            } while(true);
        }

        /// <summary>
        /// Gets an int from the user
        /// </summary>
        /// <returns></returns>
        public static int GetInt()
        {
            int x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!int.TryParse(Console.ReadLine(), out x));
            Console.Clear();
            return x;
        }
        /// <summary>
        /// Gets on int frome the user
        /// </summary>
        /// <param name="desc">Description of what int you need</param>
        /// <returns>int</returns>
        public static int GetInt(string desc)
        {
            int x;
            do
            {
                Console.Clear();
                Console.Write(desc);
            } while(!int.TryParse(Console.ReadLine(), out x));
            Console.Clear();
            return x;
        }
    }
}
