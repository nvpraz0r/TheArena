using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArena
{
    public class StringUtils
    {
        // list available jobs for a player to choose from
        public string CharacterJobMenu(string[] jobs)
        {
            for(int i = 0; i < jobs.Length; i++)
            {
                Console.WriteLine( (i + 1) + $". {jobs[i]}");
            }
            return Console.ReadLine().ToLower();
        }
        // list available races for a player to choose from
        public string CharacterRaceMenu(string[] races)
        {
            for(int i = 0; i < races.Length; i++)
            {
                Console.WriteLine( (i + 1) + $". {races[i]}");
            }
            return Console.ReadLine().ToLower();
        }
    }
}
