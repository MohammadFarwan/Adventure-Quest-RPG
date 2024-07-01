using System;

namespace AdventureQuestRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero", 100, 20, 10);
            Monster monster = new Goblin("Goblin", 50, 15, 5);

            StartBattle(player, monster);

            Console.WriteLine("Adventure complete!");
        }

        static void StartBattle(Player player, Monster enemy)
        {
            BattleSystem battleSystem = new BattleSystem();

            Console.WriteLine($"A wild {enemy.Name} appears!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                // Player's turn
                Console.WriteLine($"It's {player.Name}'s turn.");
                battleSystem.Attack(player, enemy);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");
                    break;
                }

                // Enemy's turn
                Console.WriteLine($"It's {enemy.Name}'s turn.");
                battleSystem.Attack(enemy, player);

                if (player.Health <= 0)
                {
                    Console.WriteLine($"You were defeated by the {enemy.Name}...");
                    break;
                }
            }
        }
    }
}
