using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArena
{
    class Race
    {
        public String race;
        public int health;
        public int attack;
        public int defense;
        public int agility;
        public int magicAttack;
        public int magicDefense;

        public Race(String race, int health, int attack, int defense, int agility, int magicAttack, int magicDefense)
        {
            this.race = race;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
            this.agility = agility;
            this.magicAttack = magicAttack;
            this.magicDefense = magicDefense;
        }

        public override string ToString()
        {
            return $"{race}--> \tHealth: {health} \tAttack: {attack} \tDefense: {defense} \tAgility: {agility} \tMagic Attack: {magicAttack} \tMagic Defense: {magicDefense}";
        }
    }
}
