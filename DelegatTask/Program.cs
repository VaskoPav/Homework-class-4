using System;
using System.Collections.Generic;

namespace DelegatTask
{
    class Program
    {
        public delegate bool FootballClubs(string word1,string word2);
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Func<string, string, bool> CompareClubs = (word1, word2) => word1.Length > word2.Length;
           

            FootballClubs compareClubsFootball = new FootballClubs(CompareClubs);
            

            StringMagic("Manchester", "Milan", compareClubsFootball);
            



            Console.ReadLine();
        }
        

        private static void StringMagic(string v1, string v2, FootballClubs compareClubsFootball)
        {
            Console.WriteLine($"This club {v1} is bigger than {v2}");
        }
    }
}
