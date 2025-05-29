using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GaurdiansOfTheCode
{
    public class Gameboard
    {
        private PrimaryPlayer _player;
        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);  //this is actual loose couple in action
        }

        public async Task PlayArea(int lvl)
        {
            //Spawn some enemies
            if (lvl == 1)
            {
                _player.Cards = (await FetchCards()).ToArray();
                Console.WriteLine("Ready to play Level 1");
                Console.ReadKey();
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
                while (enemy.Health > 0 || _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                    System.Console.WriteLine($"{enemy.GetType()}, health = {enemy.Health}, level = {enemy.Level}");
                }
                
            }
        }

        private async Task<IEnumerable<Card>> FetchCards()
        {
            using (var http = new HttpClient())
            {
                var cardJson = await http.GetStringAsync("http://localhost:5126/api/Cards");
                return JsonConvert.DeserializeObject<IEnumerable<Card>>(cardJson);
            }
        }
    }
    
}