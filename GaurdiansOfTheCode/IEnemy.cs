using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public interface IEnemy
    {
        int Health {get; set;}
        int Level { get; }
        void Attack(PrimaryPlayer player);
        void Defend(PrimaryPlayer player);
    }
}