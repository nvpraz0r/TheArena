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
        private string playerName;
        private string playerRace;
        private string playerJob;

        // player stats
        private int playerHealth {get; set;}
        private int playerAttack {get; set;}
        private int playerDefense {get; set;}
        private int playerAgility {get; set;}

        // SPACE BELOW FOR PLAYER GEAR

        public Character(string playerChoosenName, string playerChoosenRace, string playerChoosenJob)
        {
            this.playerName = playerChoosenName;
            this.playerRace = playerChoosenRace;
            this.playerJob = playerChoosenJob;
        }

        public Character(int health, int attack, int defense, int agility)
        {
            playerHealth = health;
            playerAttack = attack;
            playerDefense = defense;
            playerAgility = agility;
        }
    }
}
