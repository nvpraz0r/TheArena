using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArena
{
    public class StringUtils
    {
        public void Title()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("To The");
            Console.WriteLine("A R E N A");
            CleanConsole(3);
        }

        public void CharacterCreation()
        {
            // stat design: all start at 5 (except MGD) - to gain one point you must lose one point
            // {HP, ATK, DF, AGL, MAG, MGD}
            int[] human = { 5, 5, 5, 5, 5, 4 };
            int[] dwarf = { 6, 5, 6, 4, 4, 4 };
            int[] elf = { 4, 5, 4, 6, 6, 5 };

            // array of races
            string[] races = { "Human", "Dwarf", "Elf" };

            // 0, 1, 2, 3 - stat distribution
            // {HP, ATK, DF, AGL, MAG, MGD}
            int[] warrior = { 2, 3, 1, 0, 0, 0 };
            int[] theif = { 1, 2, 0, 3, 0, 0 };
            int[] wizard = { 1, 0, 0, 0, 3, 2 };

            // array of jobs
            string[] jobs = { "Warrior", "Theif", "Wizard" };

            // boolean to facilitate input validation
            bool running = true;

            // user choices
            string name = "";
            string race = "";
            string job = "";

            //
            // name
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            CleanConsole(1);

            // 
            // race
            do
            {
                // prompt
                Console.WriteLine("Please select a race.");

                // begin user input section
                string raceChoice = CharacterRaceMenu(races);
                switch (raceChoice)
                {
                    case "1":
                        race = "human";
                        running = false;
                        CleanConsole(1);
                        break;
                    case "2":
                        race = "dwarf";
                        running = false;
                        CleanConsole(1);
                        break;
                    case "3":
                        race = "elf";
                        running = false;
                        CleanConsole(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        CleanConsole(3);
                        break;
                }

            } while (running);

            // set running to true
            running = true;

            // 
            // job
            do
            {

                Console.WriteLine("Please select a job class.");

                // begin user input section
                string jobChoice = CharacterRaceMenu(jobs);
                switch (jobChoice)
                {
                    case "1":
                        job = "warrior";
                        running = false;
                        CleanConsole(1);
                        break;
                    case "2":
                        job = "theif";
                        running = false;
                        CleanConsole(1);
                        break;
                    case "3":
                        job = "wizard";
                        running = false;
                        CleanConsole(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        CleanConsole(3);
                        break;
                }

            } while (running);

            // send it all to Character Class
            Console.WriteLine(name + race + job);
        }

        // list available races for a player to choose from
        public string CharacterRaceMenu(string[] races)
        {
            for (int i = 0; i < races.Length; i++)
            {
                Console.WriteLine((i + 1) + $". {races[i]}");
            }
            return Console.ReadLine().ToLower();
        }

        // list available jobs for a player to choose from
        public string CharacterJobMenu(string[] jobs)
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                Console.WriteLine((i + 1) + $". {jobs[i]}");
            }
            return Console.ReadLine().ToLower();
        }

        // this method will clear the console given the amount of seconds
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
