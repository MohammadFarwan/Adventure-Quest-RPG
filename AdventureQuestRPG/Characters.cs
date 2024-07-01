using System;

namespace AdventureQuestRPG
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int Health { get;  set; }
        public int AttackPower { get; protected set; }
        public int Defense { get; protected set; }

        public Character(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }
    }

    public class Player : Character
    {
        public Player(string name, int health, int attackPower, int defense)
            : base(name, health, attackPower, defense)
        {
        }
    }

    public abstract class Monster : Character
    {
        public Monster(string name, int health, int attackPower, int defense)
            : base(name, health, attackPower, defense)
        {
        }
    }

    public class Goblin : Monster
    {
        public Goblin(string name, int health, int attackPower, int defense)
            : base(name, health, attackPower, defense)
        {
        }
    }
}
