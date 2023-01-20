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
            bool running = true;

            string name;
            string race;
            string job;

            // {HP, ATK, DF, AGL}
            int[] human = {5, 5, 5, 5};
            int[] dwarf = {6, 5, 6, 4};
            int[] elf = {4, 5, 4, 7};

            // array of races
            string[] races = {"Human", "Dwarf", "Elf"};

            // {HP, ATK, DF, AGL}
            // 0, 1, 2, 3 - stat distribution
            int[] warrior = {2, 3, 1, 0};
            int[] theif = {1, 2, 0, 3};
            int[] wizard = {1, 3, 0, 2};
            
            // array of jobs
            string[] jobs = {"Warrior", "Theif", "Wizard"};

            StringUtils stringUtils = new StringUtils();

            // name
            do
            {
                Console.WriteLine("Please enter your name.");

                string nameChoice = Console.ReadLine();

                if(!String.IsNullOrEmpty(nameChoice))
                {
                    name = nameChoice;
                }

            } while (running);

            // set running back to true
            running = true;

            // race
            do
            {
                Console.WriteLine("Please select a race");

                //
                string raceChoice = stringUtils.CharacterRaceMenu(races);

                // 
                switch (raceChoice)
                {
                    case "1":
                        race = "human";
                        running = false;
                        break;
                    case "2":
                        race = "dwarf";
                        running = false;
                        break;
                    case "3":
                        race = "elf";
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        CleanConsole(2);
                        break;
                }



            }while(running);

            // set running back to true
            running = true;

            // class
            do
            {
                // prompt for user input and display choices
                Console.WriteLine("Please select a class");

                // 
                string jobChoice = stringUtils.CharacterJobMenu(jobs);

                switch (jobChoice)
                {
                    case "1":
                        job = "warrior";
                        running = false;
                        break;
                    case "2":
                        job = "theif";
                        running = false;
                        break;
                    case "3":
                        job = "wizard";
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try agian");
                        CleanConsole(2);
                        break;
                }
                
            } while (running);

            // finalize settings

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
