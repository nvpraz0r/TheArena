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
