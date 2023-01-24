using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*
*   Current Objective(s):
*   =====================
*   =Retrieve data from playableRaces & playableJob lists
*
*   =Calculate data from relevant data from playableRaces & playableJob lists
*       -test data transfered properly by requesting it at the end of chracter creation
*   
*   =Retrieve character data that was given to Character Class and print it to console to prove proof of concept
*
*
*   Short Term Objective(s):
*   =====================
*   =Reformat displayed information during character creation process
*       -text should be centered
*
*
*   Completed Objective(s):
*   =====================
*   =Send character data to Character Class ✓✓✓
*       -test data transfered properly by requesting it at the end of character creation ✓✓✓
*
*
*
*
*
*
*
*/

namespace TheArena
{
    class Game
    {
        public static void Main(string[] args)
        {
            StringUtils stringUtils = new StringUtils();
            // preparing this ahead of implementation
            // Arena arena = new Arena();

            // this method prints the game title
            stringUtils.Title();

            // this method handles character creation
            CharacterCreation();

            // preparing this function call ahead of time
            // this method handles the main gameplay loop
            // arena.Start();
        }

        internal static void CharacterCreation()
        {
            // stat design: all start at 5 (except MGD) - to gain one point you must lose one point
            // {HP, ATK, DF, AGL, MAG, MGD}
            // human = { 5, 5, 5, 5, 5, 4 };
            // dwarf = { 6, 5, 6, 4, 4, 4 };
            // elf = { 4, 5, 4, 6, 6, 5 };

            List<Race> playableRaces = new List<Race>();
            playableRaces.Add(new Race("Human", 5, 5, 5, 5, 5, 4));
            playableRaces.Add(new Race("Dwarf", 6, 5, 6, 4, 4, 4));
            playableRaces.Add(new Race("Elvan", 4, 5, 4, 6, 6, 5));            

            // 0, 1, 2, 3 - job bonus stat distribution
            // {HP, ATK, DF, AGL, MAG, MGD}
            // int[] warrior = { 2, 3, 1, 0, 0, 0 };
            // int[] theif = { 1, 2, 0, 3, 0, 0 };
            // int[] wizard = { 1, 0, 0, 0, 3, 2 };

            List<Job> playableJobs = new List<Job>();
            playableJobs.Add(new Job("Warrior", 2, 3, 1, 0, 0, 0));
            playableJobs.Add(new Job("Thief", 1, 2, 0, 3, 0, 0));
            playableJobs.Add(new Job("Wizard", 1, 0, 0, 0, 3, 2));

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
            StringUtils.CleanConsole(1);

            // 
            // race
            do
            {
                // prompt
                Console.WriteLine("\n\t\tPlease select a race.\n");

                foreach(Race displayRace in playableRaces)
                {
                    Console.WriteLine("=-=-=-=-=-=-=");
                    Console.WriteLine(displayRace);
                    System.Console.WriteLine();
                }

                // begin user input section
                string raceChoice = Console.ReadLine();
                switch (raceChoice)
                {
                    case "human":
                        race = "human";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    case "dwarf":
                        race = "dwarf";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    case "elvan":
                        race = "elvan";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        StringUtils.CleanConsole(3);
                        break;
                }

            } while (running);

            // set running to true
            running = true;

            // 
            // job
            do
            {

                // prompt
                Console.WriteLine("Please select a job.");

                foreach(Job displayJob in playableJobs)
                {
                    Console.WriteLine(displayJob);
                }

                // begin user input section
                string jobChoice = Console.ReadLine();
                switch (jobChoice)
                {
                    case "warrior":
                        job = "warrior";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    case "thief":
                        job = "thief";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    case "wizard":
                        job = "wizard";
                        running = false;
                        StringUtils.CleanConsole(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        StringUtils.CleanConsole(3);
                        break;
                }

            } while (running);

            // send player character data to Character Class
            Character player = new Character(name, race, job);

            // test to confirm data made it to the recipient
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerRace);
            Console.WriteLine(player.playerJob);
        }

        internal static void CalculatePlayerStats(int health, int attack, int agility, int defense, int magicAttack, int magicDefense)
        {
            Console.WriteLine("");
        }
    }
}
