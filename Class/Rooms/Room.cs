using RPG.Class.Characters;

namespace RPG.Class.Rooms
{
    public abstract class Room
    {
        public Character RoomCharacter { get; set; }
        private bool PlayerLocation { get; set; } = false;
        public string RoomSymbol { get; set; }

        public Room()
        {
            // Render as a ! as a "oh no this is an error!"
            this.RoomSymbol = "!";
        }

        // Draw the room with it's symbol. If it sees the player, draw a P instead
        public void DrawRoom()
        {
            if (PlayerLocation)
            {
                System.Console.Write("P");
            }
            else
            {
                System.Console.Write(RoomSymbol);
            }

        }

        // Runs when a player's coords match the object
        public void PlayerEntered()
        {
            this.PlayerLocation = true;
        }

        // Runs when a players coords no longer match the object
        public void PlayerLeft()
        {
            this.PlayerLocation = false;
        }
    }
}