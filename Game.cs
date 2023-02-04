using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*
*   Current Objective(s):
*   =====================
*
*   =Reformat displayed information during gameplay
*       -text should be centered
*
*
*   Short Term Objective(s):
*   =====================
*
*   =Combat
*       -check opponent agility
*           - if x > y then x goes first -- you get the picture
*
*
*
*
*
*   Completed Objective(s):
*   =====================
*   =Send character data to Character Class ✓✓✓
*       -test data transfered properly by requesting it at the end of character creation ✓✓✓
*
*   =Condense switch statements✓✓✓
*       -if(input == "xyz" || "")✓✓✓
*       -use ternary operator if possible
*
*   =Retrieve data from playableRaces & playableJob lists✓✓✓
*
*   =Calculate data from relevant data from playableRaces & playableJob lists✓✓✓
*       -test data transfered properly by requesting it at the end of chracter creation✓✓✓
*
*   =Send user input data to CalculatePlayerStats ✓✓✓
*       -print stats to confirm proper merge ✓✓✓
*
*   =Send elements of an array to Character Class✓✓✓
*
*   =Retrieve character data that was given to Character Class and print it to console to prove proof of concept✓✓✓
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

            System.Console.WriteLine("Back in the main method");

            Character character = new Character();
            System.Console.WriteLine(character.playerName);
            System.Console.WriteLine(character.playerRace);
            System.Console.WriteLine(character.playerJob);
            System.Console.WriteLine(character.playerHealth);
            System.Console.WriteLine(character.playerAttack);
            System.Console.WriteLine(character.playerDefense);
            System.Console.WriteLine(character.playerAgility);
            System.Console.WriteLine(character.playerMagicAttack);
            System.Console.WriteLine(character.playerMagicDefense);
        }

        // this method handles character creation and input validation for character creation
        internal static void CharacterCreation()
        {
            // stat design: all start at 5 (except MGD)
            // design philosophy: to gain one point you must lose one point
            // {HP, ATK, DF, AGL, MAG, MGD}
            List<Race> playableRaces = new List<Race>();
            playableRaces.Add(new Race("Human", 5, 5, 5, 5, 5, 4));
            playableRaces.Add(new Race("Dwarf", 6, 5, 6, 4, 4, 4));
            playableRaces.Add(new Race("Elvan", 4, 5, 4, 6, 6, 5));            

            // 0, 1, 2, 3 - job bonus stat distribution
            // {HP, ATK, DF, AGL, MAG, MGD}
            List<Job> playableJobs = new List<Job>();
            playableJobs.Add(new Job("Warrior", 2, 3, 1, 0, 0, 0));
            playableJobs.Add(new Job("Thief", 1, 2, 0, 3, 0, 0));
            playableJobs.Add(new Job("Wizard", 1, 0, 0, 0, 3, 2));

            // boolean to facilitate input validation
            bool running = true;

            // user choices
            string race = "";
            string job = "";

            //
            // name
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            StringUtils.CleanConsole(1);



            // both race and job selection are in do-while loops because user picks them from a list
            // 
            // race
            do
            {
                System.Console.WriteLine("Please select a race.");

                foreach(Race displayRace in playableRaces)
                {
                    System.Console.WriteLine(displayRace);
                }

                string raceChoice = Console.ReadLine();

                if(raceChoice.ToLower() == "human" || raceChoice.ToLower() == "dwarf" ||raceChoice.ToLower() == "elvan")
                {
                    race = raceChoice.ToLower();
                    running = false;
                    StringUtils.CleanConsole(1);
                } 
                else
                {
                    System.Console.WriteLine("Invalid input. Please try again.");
                    StringUtils.CleanConsole(3);
                }

            } while (running);

            // set running to true for reuse in the next loop
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

                if(jobChoice.ToLower() == "warrior" || jobChoice.ToLower() == "thief" ||jobChoice.ToLower() == "wizard")
                {
                    job = jobChoice.ToLower();
                    running = false;
                    StringUtils.CleanConsole(1);
                }
                else
                {
                    System.Console.WriteLine("Invalid input. Please try again.");
                    StringUtils.CleanConsole(3);
                }

            } while (running);

            // send player character data to Character Class
            Character player = new Character(name, race, job);

            // send player chosen race and job to CalculatePlayerStats method
            CalculatePlayerStats(race, job);
        }

        // this method calculates player attributes driven by the race and job selections
        // then sends the calculated attributes to the character class
        internal static void CalculatePlayerStats(string race, string job)
        {
            // intermediary arrays - these will be used as an inbetween
            int[] raceArray = {};
            int[] jobArray = {};

            // stat design: all start at 5 (except MGD) - to gain one point you must lose one point
            // {HP, ATK, DF, AGL, MAG, MGD}
            int[] human = { 5, 5, 5, 5, 5, 4 };
            int[] dwarf = { 6, 5, 6, 4, 4, 4 };
            int[] elvan = { 4, 5, 4, 6, 6, 5 };

            // 0, 1, 2, 3 - job bonus stat distribution
            // {HP, ATK, DF, AGL, MAG, MGD}
            int[] warrior = { 2, 3, 1, 0, 0, 0 };
            int[] thief = { 1, 2, 0, 3, 0, 0 };
            int[] wizard = { 1, 0, 0, 0, 3, 2 };

            // set intermediary race array to it's input counterpart
            switch (race.ToLower())
            {
                case "human":
                    raceArray = human;
                    break;
                case "dwarf":
                    raceArray = dwarf;
                    break;
                case "elvan":
                    raceArray = elvan;
                    break;
                default:
                    break;
            }

            // set intermediary job array to it's input counterpart
            switch (job.ToLower())
            {
                case "warrior":
                    jobArray = warrior;
                    break;
                case "thief":
                    jobArray = thief;
                    break;
                case "wizard":
                    jobArray = wizard;
                    break;
                default:
                    break;
            }

            // merge race array with job array -- order doesn't matter as long as the one with the sum is sent to the character class
            for(int i = 0; i < raceArray.Length; i++)
            {
                raceArray[i] += jobArray[i]; 
            }

            // send stats to Character Class
            Character playerStats = new Character(raceArray[0], raceArray[1], raceArray[2], raceArray[3], raceArray[4], raceArray[5]);
        }
    }
}
