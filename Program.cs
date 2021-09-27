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
            Console.WriteLine("Welcome to this wonderful RPG");
            System.Console.WriteLine("Please select a class!\n1 for Fighter\n2 for Mage\n3 for Tank");
            int classNumber = Int32.Parse(Console.ReadLine());
            System.Console.Write("Now enter a name!");
            Player player = new Player(Console.ReadLine(), classNumber);
            Enemy enemy = new Enemy();

            System.Console.WriteLine("Player class is: {0} and name is {1}", player.PlayerClass, player.Name);

            // Generate the initial map

            Room[,] mapArray = Startup.MapCreator();
            mapArray[player.Location[0], player.Location[1]].PlayerEntered();
            // Game Loop
            while (player.Alive == true && enemy.Alive == true)
            {

                Engine.Render(mapArray);
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
