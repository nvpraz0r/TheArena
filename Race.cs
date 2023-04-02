namespace TheArena
{
    class Race
    {
        public string? Name {get; set;}
        public int Health {get; set;}
        public int Attack {get; set;}
        public int Defense {get; set;}

        public Race (string Name, int Health, int Attack, int Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
        }
    }
}