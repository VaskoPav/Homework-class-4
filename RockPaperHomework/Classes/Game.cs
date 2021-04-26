using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperHomework.Classes
{
    public class Game
    {
        public Player player1;
        public Player player2;

        public Game()
        {

        }
        public void startGame()
        {
            bool goGame = true;

            
            while (goGame)
            {
                Console.WriteLine("Enter the number of rounds (First player to reach the winning rounds is the winner)");
                int rounds = int.Parse(Console.ReadLine());

                              
                Console.WriteLine("Enter the name of the first player");
                player1 = new Player();
                player1.Score = 0;
                player1.FirstName = Console.ReadLine();


                Console.WriteLine("Enter the name of the ssecond player");
                player2 = new Player();
                player2.Score = 0;
                player2.FirstName = Console.ReadLine();


                Weapon rock = new Weapon();
                rock.Id = 0;
                rock.Weakness = 2;
                rock.FirstName = "Rock";

                Weapon paper = new Weapon();
                paper.Id = 1;
                paper.Weakness = 1;
                paper.FirstName = "Paper";

                Weapon scissors = new Weapon();
                scissors.Id = 2;
                scissors.Weakness = 0;
                scissors.FirstName = "Scissors";

                while (rounds != player1.Score && rounds != player2.Score)
                {
                    Console.WriteLine($"Player {player1.FirstName} chose your weapon");
                    Console.WriteLine("1- Rock");
                    Console.WriteLine("2- Paper");
                    Console.WriteLine("3- Scissors");

                    int weaponsGame =int.Parse(Console.ReadLine());
                    switch (weaponsGame)
                    {
                        case 1:
                            player1.weapon = rock;
                            break;
                        case 2:
                            player1.weapon = paper;
                            break;
                        case 3:
                            player1.weapon = scissors;
                            break;
                        default:
                            Console.WriteLine("Try again");
                            break;
                    }


                    if (player1.weapon.Weakness == player2.weapon.Id)
                    {
                        player2.Score += 1;
                        Console.WriteLine($"The player {player2.FirstName} won");
                        Console.WriteLine("<-------------------------------------->");

                    }
                    else if (player2.weapon.Weakness == player1.weapon.Id)
                    {
                        player1.Score += 1;
                        Console.WriteLine($"The player {player1.FirstName} won");
                        Console.WriteLine("<-------------------------------------->");
                    }
                    else
                    {
                        Console.WriteLine("It is a tie");
                    }

                    Console.WriteLine("<-------------------------------------->");

                    Console.WriteLine($"The player {player1.FirstName} with score {player1.Score} : Second player {player2.FirstName} with score {player2.Score}");

                    Console.WriteLine("<-------------------------------------->");

                    if (player2.Score == rounds)
                    {
                        Console.WriteLine("**********************");
                        Console.WriteLine($"The player {player2.FirstName} has won the game");
                        Console.WriteLine("**********************");
                    }
                    else if (player1.Score == rounds)
                    {
                        Console.WriteLine("**********************");
                        Console.WriteLine($"The player {player1.FirstName} has won the game");
                        Console.WriteLine("**********************");
                    }

                    

                }
                Console.WriteLine("Click any key to continue!");
                Console.ReadLine();
                Console.Clear();


            }
            Console.WriteLine("The game is over! Click any key to continue!");
        }
    }
}

