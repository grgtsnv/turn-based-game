using System;

namespace _PROJECT_TurnBasedCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100, 20, 13, "Player");
            Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
            Random random = new Random();


            while (!player.IsDead && !enemy.IsDead)
            {
                System.Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
                System.Console.WriteLine("Player turn! What will you do?");
                string choice = Console.ReadLine();

                if (choice == "a")
                    player.Attack(enemy);
                else
                    player.Heal();

                if (player.IsDead || enemy.IsDead)
                    break;

                System.Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);

                System.Console.WriteLine("Enemy's turn!");

                int rand = random.Next(0, 2);

                if (rand == 0)
                    enemy.Attack(player);
                else
                    enemy.Heal();
            }
        }
    }
}