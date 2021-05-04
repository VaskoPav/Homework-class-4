using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Models
{
    public static class Questions
    {

        static int correct = 0; 
        static int questions = 0; 

        public static void CurrentQuestion(string correctAnswer)
        {
            questions++;
            do
            {
                string userAnswer = Console.ReadLine();
                if (userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
                {
                    Console.WriteLine("Error -Please Enter Valid Input");
                }
                else
                {
                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine("That is correct!");
                        correct++;
                        break;
                    }
                    else if (userAnswer != correctAnswer) 
                    {
                        Console.WriteLine("Sorry, that is incorrect.");
                        break;
                    }
                }
            }
            while (true);
            

        }
        public static void QuestionsAnswer()
        {
            

            //Question 1
            
            Console.WriteLine(" \nQuestion 1 - What is the capital of Tasmania? " +
                            "\n\nA. Dodoma \nB. Hobart  \nC. Launceston  \nD. Wellington \n\n");
            CurrentQuestion("B");
            Console.Write("Press \'ENTER\' to continue...");
            Console.ReadLine();
            

            //Question 2
            Console.WriteLine("Question 2 -What is the tallest building in the Republic of the Congo? " +
                            "\n\nA. Kinshasa Democratic Republic of the Congo Temple \nB.Palais de la Nation  \nC.Kongo Trade Centre  \nD. Nabemba Tower \n\n");
            CurrentQuestion("D");
            Console.Write("Press \'ENTER\' to continue...");
            Console.ReadLine();
            

            //Question 3
            Console.WriteLine("Question 3 -Which of these is not one of Pluto's moons? " +
                            "\n\nA.Styx \nB.Hydra  \nC.Nix  \nD. Lugia \n\n");
            CurrentQuestion("C");
            Console.Write("Press \'ENTER\' to continue...");
            Console.ReadLine();
            

            //Question 4
            Console.WriteLine("Question 4 -What is the smallest lake in the world? " +
                            "\n\nA.Onega Lake \nB. Benxi Lake  \nC.Kivu Lake  \nD.Wakatipu Lake \n\n");
            CurrentQuestion("B");
            Console.Write("Press \'ENTER\' to continue...");
            Console.ReadLine();
            
             
            //Question 5
            Console.WriteLine("Question 5- What country has the largest population of alpacas? " +
                            "\n\nA.Chad \nB.Peru  \nC.Australia  \nD.Niger \n\n");
            CurrentQuestion("B");
            Console.Write("Press \'ENTER\' to continue...");
            Console.ReadLine();

           
            
            Console.WriteLine("You got " + correct + " out of " + questions + " correctly!");

           
        }
    }
}

