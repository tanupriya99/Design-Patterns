using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public interface IWeapon
    {
        int Damage {get; }
        void Use(IEnemy enemy);
    }
}