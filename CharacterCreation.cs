using System;
using System.Collections.Generic;

namespace TheArena
{
    public class CharacterCreation
    {

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

            // player types their name
            do
            {
                Console.Clear();

                System.Console.WriteLine("Please enter your character's name");
                System.Console.WriteLine("\t=====||=====");
                System.Console.WriteLine();

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
                System.Console.WriteLine("\t=====||=====");
                System.Console.WriteLine();

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
                System.Console.WriteLine("\t=====||=====");
                System.Console.WriteLine();

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
            List<Race> RaceList = new List<Race>();
            RaceList.Add(new Race("Human", 40, 5, 5));
            RaceList.Add(new Race("Elvan", 40, 5, 5));
            RaceList.Add(new Race("Dwarf", 40, 5, 5));

            // looks unconvential, but it does exactly what I want it to
            // (lines up with the data below)
            System.Console.WriteLine("Race" + "\t " + "Health" + "\t " + "Attack" + "\t " + "Defense");

            for(int i = 0; i < RaceList.Count; i++)
            {
                System.Console.WriteLine(RaceList[i].Name + "\t " + RaceList[i].Health + "\t " + RaceList[i].Attack + "\t " + RaceList[i].Defense);
            }

            return Console.ReadLine();
        }

        public string ChooseJob()
        {

            List<Job> JobList = new List<Job>();
            JobList.Add(new Job("Knight", 40, 5, 5));
            JobList.Add(new Job("Wizard", 40, 5, 5));
            JobList.Add(new Job("Rogue", 40, 5, 5));

            // looks unconvential, but it does exactly what I want it to
            // (lines up with the data below)
            System.Console.WriteLine("Job" + "\t " + "Health" + "\t " + "Attack" + "\t " + "Defense");

            for(int i = 0; i < JobList.Count; i++)
            {
                System.Console.WriteLine(JobList[i].Name + "\t " + JobList[i].Health + "\t " + JobList[i].Attack + "\t " + JobList[i].Defense);
            }

            return Console.ReadLine();
        }
    }
}