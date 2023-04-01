using System;
using System.Collections.Generic;

namespace TheArena
{
    public class CharacterCreation
    {
        // don't know why this works, but it does
        // https://csharp.net-tutorials.com/collections/lists/
        List<Race> RaceList = new List<Race>()
        {
            new Race() {name = "human", health = 20, attack = 5, defense = 5},
            new Race() {name = "elvan", health = 20, attack = 5, defense = 5},
            new Race() {name = "dwarf", health = 20, attack = 5, defense = 5}
        };

        List<Job> JobList = new List<Job>()
        {
            new Job() {name = "knight", health = 20, attack = 5, defense = 5},
            new Job() {name = "wizard", health = 20, attack = 5, defense = 5},
            new Job() {name = "rogue", health = 20, attack = 5, defense = 5}
        };

        // this method welcomes the player
        public void WelcomePlayer()
        {
            System.Console.WriteLine("Welcome To The Arena");

            var utils = new Utils();
            utils.WaitFunction(1);
            Console.Clear();
        }

        // this method instructs character creation
        public void CreateCharacter()
        {
            Utils utils = new Utils();
            Character player = new Character();
            string? input;
            bool running = true;
            do
            {
                Console.Clear();

                System.Console.WriteLine("Please enter your character's name");

                input = Console.ReadLine();

                // this statement sends input to TestForNullOrEmpty method
                // the method then returns true-false
                // if true the loop continues
                running = utils.TestForNullOrEmpty(input);
                running = utils.TestForNameLength(input);

                player.characterName = input;
            } while (running);

            running = true;

            // player chooses a race
            do
            {
                Console.Clear();

                System.Console.WriteLine("Please enter your character's race");

                input = ChooseRace();

                switch (input)
                {
                    case "1":
                        running = false;
                        player.characterRace = "human";
                        break;

                    case "2":
                        running = false;
                        player.characterRace = "elvan";
                        break;

                    case "3":
                        running = false;
                        player.characterRace = "dwarf";
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (running);

            running = true;


            // player chooses job
            do
            {
                Console.Clear();

                System.Console.WriteLine("Please choose your profession");

                input = ChooseJob();

                switch (input)
                {
                    case "1":
                        running = false;
                        player.characterJob = "knight";
                        break;

                    case "2":
                        running = false;
                        player.characterJob = "wizard";
                        break;

                    case "3":
                        running = false;
                        player.characterJob = "rogue";
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (running);


            System.Console.WriteLine($"Your character's name:\t {player.characterName}");
            System.Console.WriteLine($"Your character's race:\t {player.characterRace}");
            System.Console.WriteLine($"Your character's job:\t {player.characterJob}");

        }

        public string ChooseRace()
        {
            // looks unconvential, but it does exactly what I want it to
            // (lines up with the data below)
            System.Console.WriteLine("Race" + "\t " + "Health" + "\t " + "Attack" + "\t " + "Defense");

            for(int i = 0; i < RaceList.Count; i++)
            {
                System.Console.WriteLine(RaceList[i].name + "\t " + RaceList[i].health + "\t " + RaceList[i].attack + "\t " + RaceList[i].defense);
            }

            return Console.ReadLine();
        }

        public string ChooseJob()
        {

            // looks unconvential, but it does exactly what I want it to
            // (lines up with the data below)
            System.Console.WriteLine("Job" + "\t " + "Health" + "\t " + "Attack" + "\t " + "Defense");

            for(int i = 0; i < JobList.Count; i++)
            {
                System.Console.WriteLine(JobList[i].name + "\t " + JobList[i].health + "\t " + JobList[i].attack + "\t " + JobList[i].defense);
            }

            return Console.ReadLine();
        }
    }
}