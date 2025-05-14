using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    public class Gameboard
    {
        private PrimaryPlayer _player;
        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
        }

        public void PlayArea(int lvl)
        {
            //Spawn some enemies
            if (lvl == 1)
            {
                PlayFirstLevel();
            }
        }

        public void PlayFirstLevel()
        {
            const int currentlvl = 1;
            List<IEnemy> enemies = new List<IEnemy>();
            for (int i=0;i<10;i++)
            {
                enemies.Add(EnemyFactory.SpawnZombie(currentlvl));
            }

            for (int i=0;  i<3; i++)
            {
                enemies.Add (EnemyFactory.SpawnWarewolf(currentlvl));
            }

            foreach (var enemy in enemies)
            {
                System.Console.WriteLine($"{enemy.GetType()}, health = {enemy.Health}, level = {enemy.Level}");
            }
        }
    }
}