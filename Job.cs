namespace TheArena
{
    class Job
    {
        public string? name {get; set;}
        public int health {get; set;}
        public int attack {get; set;}
        public int defense {get; set;}

        public Job(string name, int health, int attack, int defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }
    }
}