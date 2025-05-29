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
                TestApiConnection().Wait();

                Gameboard board = new Gameboard();
                board.PlayArea(1);

                Console.ReadKey();
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
    }
}
