namespace RPG.Class.Characters
{
    public class Player : Character
    {
        public string PlayerClass { get; set; }
        public int[] Location { get; set; } = new int[] { 0, 0 };
        public Player()
        {
            Name = "Chad";
            Health = 10;
            Attack = 2;
            Defense = 0;
            CharacterType = "Player";
        }

        public Player(string name, int playerClass)
        {
            // Fighter
            if (playerClass == 1)
            {
                Health = 10;
                Attack = 2;
                Defense = 1;
                PlayerClass = "Fighter";
            }

            // Mage
            else if (playerClass == 2)
            {
                Health = 10;
                Attack = 3;
                Defense = 0;
                PlayerClass = "Mage";
            }

            // Tank
            else if (playerClass == 3)
            {
                Health = 15;
                Attack = 1;
                Defense = 1;
                PlayerClass = "Tank";
            }

            CharacterType = "Player";
            this.Name = name;
        }

        public void LocationUpdate(int[] coords)
        {
            Location[0] += coords[0];
            Location[1] += coords[1];
        }
    }
}