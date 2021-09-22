namespace RPG.Class
{
    public abstract class Character
    {
        // 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }

        public int CombatRound(int enemyDamage, int damageDealt)
        {
            this.Health -= (enemyDamage - this.Defense);


            return damageDealt;
        }

        // Check if the character is alive or dead
        public bool AliveStatus()
        {
            if (this.Health < 0)
            {
                return false;
            }

            return true;
        }
    }
}