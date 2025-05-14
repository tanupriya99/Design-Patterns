using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class Warewolf : IEnemy
    {
        private int _health;
        private readonly int _level;
        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public Warewolf(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            System.Console.WriteLine("Warewolf attaking "+player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            System.Console.WriteLine("Warewolf defending from "+player.Name);
        }
    }
}