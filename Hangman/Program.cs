using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the classic Hangman");
            Console.WriteLine("Please enter a letter, and let the game begin!\n");



            //Asterik in place of letters
            char[] word1 = { 'p', 'e', 'o', 'p', 'l', 'e' };
            char[] progressWord = new Char[word1.Length];
            string completedWord1 = string.Concat(word1);

            char[] word2 = { 'g', 'r', 'a', 'p', 'e', 's' };
            char[] progressWord2 = new Char[word2.Length];
            string completedWord2 = string.Concat(word2);

            for (int i = 0; i < word1.Length; i++)
            {
                progressWord[i] = '*';
            }
            for (int i = 0; i < word2.Length; i++)
            {
                progressWord2[i] = '*';
            }

            //1. check userinput is a letter in word1
            // --if it is, update progressWord to replace '*' with correct guess
            //2. Console.Writeline for userinput correct letter
            //3. console.writeline for userinput wrong letter
            //4 when word is solved, restart the program

            bool isRunning = true;
            while (isRunning == true)
            {
                char answer = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Welcome to the classic Hangman");
                Console.WriteLine("Please enter another letter...\n");
                //1
                for (int i = 0; i < word1.Length; i++)
                {
                    if (word1[i] == answer)
                    {
                        progressWord[i] = word1[i];
                    }
                }
                Console.WriteLine(progressWord);
                //2
                if (word1.Contains(answer))
                {
                    Console.WriteLine("You have chosen the correct letter!");
                }
                else if (!word1.Contains(answer))
                {
                    Console.WriteLine("Wrong letter, please try again");
                }
                //4
                if (string.Concat(progressWord) == completedWord1)
                {
                    Console.WriteLine("Congratulations! You did it!\n" +
                        "\n" +
                        "Press any key to continue");
                    isRunning = false;
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome back to the classic game Hangman!\n" +
                "Select a letter to start Round 2!\n");
            isRunning = true;
            while (isRunning == true)
            {
                char answer2 = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Welcome back to the classic game Hangman!\n" +
                    "Select another letter to start Round 2!\n");
                for (int i = 0; i < word2.Length; i++)
                {
                    if (word2[i] == answer2)
                    {
                        progressWord2[i] = word2[i];
                    }
                }
                Console.WriteLine(progressWord2);
                //2
                if (word2.Contains(answer2))
                {
                    Console.WriteLine("You have chosen the correct letter!");
                }
                else if (!word2.Contains(answer2))
                {
                    Console.WriteLine("Wrong letter, please try again");
                }
                //4
                if (string.Concat(progressWord2) == completedWord2)
                {
                    Console.WriteLine("Congratulations! You did it!\n" +
                        "\n" +
                        "Press any key to continue");
                    isRunning = false;
                }
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
