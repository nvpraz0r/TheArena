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
*   
*   =Retrieve character data that was given to Character Class and print it to console to prove proof of concept
*
*
*   Short Term Objective(s):
*   =====================
*   =Reformat displayed information during gameplay
*       -text should be centered
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

            // test to confirm data made it to the recipient
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerRace);
            Console.WriteLine(player.playerJob);

            // FOR NOW calculate the stats being sent without sending them
            // print results to confirm proper merging of arrays
            CalculatePlayerStats(race, job);
        }

        // this method does nothing for now -- retrieve data from the List objects then come back to calculate
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

            // merging two arrays
            for(int i = 0; i < raceArray.Length; i++)
            {
                raceArray[i] += jobArray[i]; 
            }

            // test merge of the two arrays
            foreach(int i in raceArray)
            {
                System.Console.WriteLine(i);
            }


            // psuedo code
            // send stats to Character Class
            // Character.Character(({0}, {1}), var1, var 2);

        }
    }
}
