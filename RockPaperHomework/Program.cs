using RockPaperHomework.Classes;
using System;

namespace RockPaperHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Gamers");
                       
            Game gamenew = new Game();

            gamenew.startGame();

            Console.WriteLine("Thanks for playing");

            Console.ReadLine();
        }
    }
}
