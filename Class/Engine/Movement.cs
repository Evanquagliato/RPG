using System;
using RPG.Class.Characters;

namespace RPG.Class.Engine
{
    public static class Movement
    {
        public static int[] PlayerMovement()
        {

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    return MoveUp();

                case ConsoleKey.A:
                    return MoveLeft();

                case ConsoleKey.D:
                    return MoveRight();

                case ConsoleKey.S:
                    return MoveDown();

                default:
                    System.Console.WriteLine("Didn't move");
                    return new[] { 0, 0 };
            }

        }

        private static int[] MoveUp()
        {
            return new[] { -1, 0 };
        }
        private static int[] MoveLeft()
        {
            return new[] { 0, -1 };
        }
        private static int[] MoveRight()
        {
            return new[] { 0, 1 };
        }
        private static int[] MoveDown()
        {
            return new[] { 1, 0 };
        }
    }
}