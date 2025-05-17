using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class FireStaff : IWeapon
    {
        private int _damage;
        private int _fireDamage;
        public int Damage {get => _damage;}
        public FireStaff (int damage, int fireDamage)
        {
            _damage = damage;
            _fireDamage = fireDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Overtimedamage = _fireDamage;
        }
    }
}