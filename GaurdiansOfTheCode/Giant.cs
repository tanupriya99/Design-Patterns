using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class Giant : IEnemy
    {
        private int _health;
        private readonly int _level;
        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public Giant(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            System.Console.WriteLine("Giant attaking "+player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            System.Console.WriteLine("Giant defending from "+player.Name);
        }
    }
}