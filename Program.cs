using System;
using RPG.Class.Characters;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to this wonderful RPG");
            System.Console.WriteLine("Please select a class!\n1 for Fighter\n2 for Mage\n3 for Tank");
            int classNumber = Int32.Parse(Console.ReadLine());
            System.Console.Write("Now enter a name!");
            Player player = new Player(Console.ReadLine(), classNumber);
            Enemy enemy = new Enemy();

            System.Console.WriteLine("Player class is: {0} and name is {1}", player.PlayerClass, player.Name);

            // Simulate combat for testing
            while (player.Alive == true && enemy.Alive == true)
            {
                player.CombatRound(enemy.Attack);
                enemy.CombatRound(player.Attack);

                System.Console.WriteLine("Player HP: {0} | Enemy HP: {1}", player.Health, enemy.Health);
                System.Console.ReadLine();
            }
        }
    }
}
