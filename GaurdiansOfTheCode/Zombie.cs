using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class Zombie : IEnemy
    {
        private int _health;
        private readonly int _level;
        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public int Overtimedamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Zombie(int health, int level, int armor)
        {
            _health = health;
            _level = level;
            Armor = armor;
        }

        public void Attack(PrimaryPlayer player)
        {
            System.Console.WriteLine("Zombie attaking "+player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            System.Console.WriteLine("Zombie defending from "+player.Name);
        }
    }
}