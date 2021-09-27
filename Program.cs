using System;
using RPG.Class.Characters;
using RPG.Class.Rooms;
using RPG.Class.Engine;
using System.Linq;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            // Testing generating the characteer
            System.Console.WriteLine("Enter a name");
            Player player = new Player(Console.ReadLine(), 1);
            Enemy enemy = new Enemy();

            // Generate the initial map

            Room[,] mapArray = Startup.MapCreator();
            mapArray[player.Location[0], player.Location[1]].PlayerEntered();
            // Game Loop
            while (player.Alive == true && enemy.Alive == true)
            {

                Engine.Render(mapArray, player);
                // Update the room the player was in as a room the player isn't in
                mapArray[player.Location[0], player.Location[1]].PlayerLeft();

                // Movement input 
                player.LocationUpdate(Movement.PlayerMovement());

                // Update the map for the player entering a new room
                mapArray[player.Location[0], player.Location[1]].PlayerEntered();


            }
        }
    }
}
