using System;
using RPG.Class.Characters;
using RPG.Class.Rooms;

namespace RPG.Class.Engine
{
    public class Engine
    {
        public static Room[,] MapCreator()
        {
            Room[,] mapArray = new Room[5, 10];
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    mapArray[i, j] = RoomGenerator();
                }
            }

            return mapArray;
        }

        public static void Render(Room[,] room)
        {
            for (int i = 0; i < room.GetLength(0); i++)
            {
                for (int j = 0; j < room.GetLength(1); j++)
                {
                    System.Console.Write(room[i, j].RoomSymbol);
                }
                System.Console.WriteLine("");
            }
        }

        private static Room RoomGenerator()
        {
            Room tempRoom;
            switch (RoomRandomizer())
            {
                case 1:
                    tempRoom = new EnemyRoom();
                    break;
                case 2:
                    tempRoom = new EmptyRoom();
                    break;
                case 3:
                    tempRoom = new NPCRoom();
                    break;
                default:
                    tempRoom = new EmptyRoom();
                    break;
            }

            return tempRoom;
        }

        // Return a weighted randomizer for room types
        private static int RoomRandomizer()
        {
            var rand = new Random();

            switch (rand.Next(5))
            {
                case 1:
                case 2:
                    return 1;
                case 3:
                case 4:
                    return 2;
                case 5:
                    return 3;
                default:
                    return 0;

            }
        }
    }
}