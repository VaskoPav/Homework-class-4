using System;

namespace Task_01_02
{
    class Program
    {
        static void funWithStrings(string newString)
        {

            Console.WriteLine("Enter your string");
            newString = Console.ReadLine();

            char[] result = newString.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);

            Console.WriteLine("--------------->");

            int stringLengh = newString.Length;
            Console.WriteLine("String lenght: " + stringLengh);

            for (int i = 0; i <= newString.Length; i++)
            {
                if (newString[i] == 'a' || newString[i] == 'e' || newString[i] == 'i' || newString[i] == 'o' || newString[i] == 'u')
                {

                    Console.Write("Vowels used: " + newString[i]);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("----------------->");
            int myWords = 1;
            int word = 0;
            string totalWords = newString;

            while (word <= totalWords.Length - 1)
            {
                if (totalWords[word] == ' ')
                {
                    myWords++;
                }
                word++;

            }
            Console.WriteLine("Total word: " + myWords);

            Console.WriteLine("-------------------->");

            string str = newString;
            int[] charCount = new int[256];
            int lenght = str.Length;
            for (int i = 0; i < lenght; i++)
            {
                charCount[str[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < lenght; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }

            }

            Console.WriteLine("Most used character: " + character);

            Console.WriteLine("-------------------->");

            string[] words = newString.Split();
            string longestWord = "";
            string shrtestWord = "";

            foreach (string wordLong in words)
            {
                if (wordLong.Length > longestWord.Length)
                {
                    longestWord = wordLong;
                    Console.WriteLine("Longest word: " + longestWord);
                    continue;


                }
                else if (wordLong.Length < longestWord.Length)
                {
                    shrtestWord = wordLong;
                    Console.WriteLine("Shortest word: " + shrtestWord);

                    break;
                }


            }

            Console.WriteLine("---------------------->");
        }


        static void removeSpace(string stringSpace)
        {
            string trimmedString = stringSpace.Trim();
            string stringwithSpace = "";
            char charNew = '_';

            for (int i = 0; i < trimmedString.Length; i++)
            {
                if (charNew == ' ' && trimmedString[i] == ' ')
                    continue;
                else
                {
                    stringwithSpace += trimmedString[i];
                    charNew = trimmedString[i];
                }
            }
            Console.WriteLine(stringwithSpace);


        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            funWithStrings("Enter your string");

            Console.WriteLine("Task 02------------------->");

            removeSpace("The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!");



            Console.ReadLine();
        }
    }
}
