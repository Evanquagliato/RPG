using System;
using RPG.Class.Characters;
using RPG.Class.Rooms;

namespace RPG.Class.Engine
{
    public class Engine
    {
        // Draws the rooms via the DrawRoom method on each object
        // To render a map based on the size of the room
        public static void Render(Room[,] room, Player player)
        {
            Console.Clear();
            for (int i = 0; i < room.GetLength(0); i++)
            {
                for (int j = 0; j < room.GetLength(1); j++)
                {
                    room[i, j].DrawRoom();
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");

            System.Console.WriteLine("Player Name: " + player.Name);
            System.Console.WriteLine("Player Health: " + player.Health);
        }
        // WIP combat processor
        public static void Combat(Player player, Enemy enemy)
        {
            bool combat = true;
            while (combat)
            {
                player.CombatRound(enemy.Attack);
                enemy.CombatRound(player.Attack);
                System.Console.WriteLine("Do you want to stay engaged? Enemy is at {0} health", enemy.Health);
                System.Console.Write("Yes or No");
                string response = System.Console.ReadLine().ToLower();
                if (response == "No")
                {
                    System.Console.WriteLine("Leave the room!");
                    break;
                }
            }
        }

    }


}