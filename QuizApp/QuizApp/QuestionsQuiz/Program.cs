using System;
using System.Collections.Generic;

namespace QuestionsQuiz
{
    class Program
    {
        private static void PopulateQuizItems(Quiz quiz)
        {
            if (quiz == null) return;

            quiz.QuizItems.Add(new QuizItem
            {
                Question = "What does the word 'virile' mean?",
                PossibleAnswers = new List<string>
        {
            "Like a rabbit",
            "Like a man",
            "Like a wolf",
            "Like a horse"
        },
                CorrectAnswerIndex = 1,
                DisplayCorrectAnswerImmediately = true
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();

            var quiz = new Quiz(new User(userName));
            PopulateQuizItems(quiz);
            quiz.BeginTest();

            
        }
    }
}
