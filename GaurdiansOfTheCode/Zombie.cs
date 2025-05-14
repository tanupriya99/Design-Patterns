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

        public Zombie(int health, int level)
        {
            _health = health;
            _level = level;
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