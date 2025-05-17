using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class IceStaff : IWeapon
    {
        private int _damage;
        private int _paralyzedFor;
        public int Damage {get => _damage;}

        public IceStaff(int damage, int paralyzedFor)
        {
            _damage = damage;
            _paralyzedFor = paralyzedFor;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Paralyzed = true;
        }
    }
}