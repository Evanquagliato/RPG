using System;
using RPG.Class.Characters;
using RPG.Class.Rooms;

namespace RPG.Class.Engine
{
    public class Engine
    {
        // Draws the rooms via the DrawRoom method on each object
        // To render a map based on the size of the room
        public static void Render(Room[,] room)
        {
            for (int i = 0; i < room.GetLength(0); i++)
            {
                for (int j = 0; j < room.GetLength(1); j++)
                {
                    room[i, j].DrawRoom();
                }
                System.Console.WriteLine("");
            }
        }


    }
}