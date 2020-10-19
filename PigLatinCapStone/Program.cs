using System;

namespace PigLatinCapStone
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i--)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine();

                Console.Write("Enter word: ");
                string word = Console.ReadLine().ToLower();

                int VowelPost = -1;
                foreach (char letter in word)
                {
                    VowelPost = VowelPost + 1;
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        break;
                    }
                }

                string PigLatinWord = "";
                string BfLetters = "";
                string AfLetters = "";
                switch (VowelPost)
                {
                    case 0:
                        PigLatinWord = word + "way";

                        break;

                    case 1:
                        BfLetters = word.Substring(0, 1);
                        AfLetters = word.Substring(1);
                        PigLatinWord = AfLetters + BfLetters + "ay";

                        break;

                    case 2:
                        BfLetters = word.Substring(0, 2);
                        AfLetters = word.Substring(2);
                        PigLatinWord = AfLetters + BfLetters + "ay";

                        break;

                    default:
                        PigLatinWord = "Cant translate";

                        break;
                }

                Console.WriteLine("Translation: " + PigLatinWord);
                Console.WriteLine();
                Console.WriteLine("Would you,like to translate another word? (yes/no)");
                string contiueInput = Console.ReadLine();
                if (contiueInput == "yes")
                {
                    continue;
                }
                else if (contiueInput.Equals("no"))
                {
                    Console.WriteLine("Okay goodbye.");
                    break;

                }
                else
                {
                    Console.WriteLine("You didnt enter yes or no.");

                }

            }
        }
    }
}
