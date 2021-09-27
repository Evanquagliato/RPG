using RPG.Class.Characters;

namespace RPG.Class.Rooms
{
    public abstract class Room
    {
        public Character RoomCharacter { get; set; }
        public bool PlayerLocation { get; set; } = false;
        public string RoomSymbol { get; set; }

        public Room()
        {
            // Render as a ! as a "oh no this is an error!"
            this.RoomSymbol = "!";
        }

        public void PlayerEntered()
        {
            this.PlayerLocation = true;
        }

        public void PlayerLeft()
        {
            this.PlayerLocation = false;
        }
    }
}