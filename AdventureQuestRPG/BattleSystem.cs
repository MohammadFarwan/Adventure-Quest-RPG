using System;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        public void Attack(Character attacker, Character target)
        {
            int damage = CalculateDamage(attacker, target);
            target.Health -= damage;

            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage.");
            Console.WriteLine($"{target.Name}'s health is now {target.Health}.");

            if (target.Health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
            }
        }

        private int CalculateDamage(Character attacker, Character target)
        {
            int damage = attacker.AttackPower - target.Defense;
            if (damage < 0)
                damage = 0;

            return damage;
        }
    }
}
