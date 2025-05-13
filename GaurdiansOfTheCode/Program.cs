using System;

namespace GaurdiansOfTheCode
{
    class Program{
        static void Main(string[] args)
        {
            PrimaryPlayer player = PrimaryPlayer.Instance;
            System.Console.WriteLine($"{player.Name} - {player.Level}");
        }
    }
}
