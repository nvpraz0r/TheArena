using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArena
{
    class Game
    {
        public static List<string> races = new List<string>();
        public static List<int> raceStats = new List<int>();

        public static List<string> jobs = new List<string>();
        public static List<int> jobStats = new List<int>();

        public static string header;

        static void Main(string[] args)
        {
            ReadJobs();

            for(int i = 0; i < jobStats.Count; i++)
            {
                Console.WriteLine(jobStats[i]);
            }
        }

        public static void ReadJobs()
        {
            string filename = @"~\data\jobs.csv";
            using(var reader = new StreamReader(filename))
            {
                header = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(",");
                    // name,hp,attack,defense,agility
                    jobs.Add(values[0]);
                    jobStats.Add(Convert.ToInt32(values[1]));
                    jobStats.Add(Convert.ToInt32(values[2]));
                    jobStats.Add(Convert.ToInt32(values[3]));
                    jobStats.Add(Convert.ToInt32(values[4]));
                }
            }
        }


    }
}
