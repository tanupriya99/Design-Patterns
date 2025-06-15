using Common;
using System;
using System.Threading.Tasks;

namespace GaurdiansOfTheCode
{
    class Program{
        static void Main(string[] args)
        {
            //PrimaryPlayer player = PrimaryPlayer.Instance;
            //System.Console.WriteLine($"{player.Name} - {player.Level}");
            try
            {
                //TestApiConnection().Wait();
                TestDecorators();
                //Gameboard board = new Gameboard();
                //board.PlayArea(1);

                //Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Failure to initialize game");
            }
            
        }

        private static async Task TestApiConnection()
        {
            int maxAttempts = 20;
            int atteminterval = 2000;
            using (var http = new HttpClient())
            {
                for (int i = 0; i < maxAttempts; i++)
                {
                    try
                    {
                        var response = await http.GetAsync("http://localhost:5126/api/Cards");
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return;
                        }
                    }

                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        Console.WriteLine("Lost connection to server. Attempting to re-connect");
                        Thread.Sleep(atteminterval);
                    }
                    
                }
                throw new Exception("Failed to connect to server");
            }
            
        }

        private static void TestDecorators()
        {
            Card soldier = new Card("Soldier", 25, 20);
            soldier = new AttackDecorator(soldier, "Sword", 15);
            soldier = new AttackDecorator(soldier, "Amulet", 5);
            soldier = new DefenseDecorator(soldier, "Helmet", 10);
            soldier = new DefenseDecorator(soldier, "Heavy Armor", 45);
            Console.WriteLine($"Final Stats: {soldier.Attack}/{soldier.Defense}");
        }
    }
}
