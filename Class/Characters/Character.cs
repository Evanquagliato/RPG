namespace RPG.Class.Characters
{
    public abstract class Character
    {
        // Default stats for any NPC
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; } = 1;
        public int Attack { get; set; } = 0;
        public int Defense { get; set; } = 0;
        public bool Alive { get; set; } = true;
        // Player, Enemy, Vendor, or NPC
        public string CharacterType { get; set; }

        // Process a round of combat
        public int CombatRound(int enemyDamage)
        {
            this.Health -= (enemyDamage - this.Defense);
            if (Health <= 0)
            {
                Alive = false;
                System.Console.WriteLine("It appears the {0} is dead", this.CharacterType);
            }
            return Attack;
        }
    }
}