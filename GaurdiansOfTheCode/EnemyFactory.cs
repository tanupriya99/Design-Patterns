using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public static class EnemyFactory
    {
        public static Warewolf SpawnWarewolf(int arealevel)
        {
            if (arealevel<5)
            {
                return new Warewolf(100, 12);
            }
            else{
                return new Warewolf(100, 20);
            }

        }

        public static Giant SpawnGiant(int arealevel)
        {
            if (arealevel<8)
            {
                return new Giant(100, 14);
            }
            else{
                return new Giant(100, 32);
            }

        }
        public static Zombie SpawnZombie(int arealevel)
        {
            if (arealevel<3)
            {
                return new Zombie(66, 2);
            }
            else if (arealevel>=3 && arealevel<10)
            {
                return new Zombie(66, 5);
            }
            else{
                return new Zombie(100, 8);
            }

        }
    }
}