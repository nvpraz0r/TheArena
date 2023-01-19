using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    NOTES
    -----
    add player gear into Character.cs
    -----

*/


namespace TheArena
{
    class Game
    {
        // Main Method
        // Design philosophy: only loop when I absolutely need to loop
        static void Main(string[] args)
        {
            Welcome();
            CharacterCreation();
        }

        //
        public static void Welcome()
        {
            Console.WriteLine("\t\tWelcome");
            Console.WriteLine("\t\tTo The");
            Console.WriteLine("\t\tA R E N A");
            CleanConsole(10);
        }

        public static void CharacterCreation()
        {
            //What's your name?
            //choose a race
            //choose a class
            //calculate what to send to the character constructor

            // {HP, ATK, DF, AGL}
            int[] human = {5, 5, 5, 5};
            int[] dwarf = {6, 5, 6, 4};
            int[] elf = {4, 5, 4, 7};

            bool running = true;

            do
            {
                Console.WriteLine("What is your name?");
                string input = Console.ReadLine();
                int num = -1;

                if(!int.TryParse(input, out num))
                {
                    
                }
            } while(running);

        }

        public static void CleanConsole(int waitTimeSeconds)
        {
            try
            {
                waitTimeSeconds *= 1000;
                System.Threading.Thread.Sleep(waitTimeSeconds);
                Console.Clear();
            }
            catch (Exception)
            {
                //can't return anything without the compiler freaking out about a void method
            }
        } 
    }
}
