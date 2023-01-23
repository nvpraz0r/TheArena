using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArena
{
    class Character
    {
        // player information
        public string playerName {get; set;}
        public string playerRace {get; set;}
        public string playerJob {get; set;}

        // player stats
        public int playerHealth {get; set;}
        public int playerAttack {get; set;}
        public int playerDefense {get; set;}
        public int playerAgility {get; set;}
        public int playerMagicAttack {get; set;}
        public int playerMagicDefense {get; set;}

        public Character()
        {
        }

        public Character(string name, string race, string job)
        {
            this.playerName = name;
            this.playerRace = race;
            this.playerJob = job;
        }

        public Character(int health, int attack, int defense, int agility, int magicAttack, int magicDefense)
        {
            this.playerHealth = health;
            this.playerAttack = attack;
            this.playerDefense = defense;
            this.playerAgility = agility;
            this.playerMagicAttack = magicAttack;
            this.playerMagicDefense = magicDefense;
        }
    }
}
