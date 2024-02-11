using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // How many vowels is in a word
            Console.WriteLine("Type In Your Word: ");
            string userInput = Console.ReadLine();

            string[] vowels = { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" };
            Console.WriteLine(userInput);
            int vowelAmount = 0;
            int amountOfTimesA = 0;
            int amountOfTimesE = 0;
            int amountOfTimesI = 0;
            int amountOfTimesO = 0;
            int amountOfTimesU = 0;


            foreach (char vowel in userInput)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    vowelAmount++;
                    if (vowel == 'a' || vowel == 'A')
                    {
                        amountOfTimesA++;
                    }

                    if (vowel == 'e')
                    {
                        amountOfTimesE++;
                    }
                    if (vowel == 'i')
                    {
                        amountOfTimesI++;
                    }
                    if (vowel == 'o')
                    {
                        amountOfTimesO++;
                    }
                    if (vowel == 'u')
                    {
                        amountOfTimesU++;
                    }
                }

            }

            if (vowelAmount >= 1)
            {
                Console.WriteLine($"There's {vowelAmount} Vowel/s, And They Are: \n");

                bool check = userInput.Contains(vowels[0].ToLower());
                if (check == true)
                {
                    // foreach statement which will check how many times does certain vowel appear & then display it
                    string vowelA = vowels[0].ToLower();
                    Console.WriteLine($"{vowelA} x{amountOfTimesA}");

                }
                bool checkTwo = userInput.Contains(vowels[1].ToLower());
                if (checkTwo == true)
                {
                    string vowelE = vowels[1].ToLower();
                    Console.WriteLine($"{vowelE} x{amountOfTimesE}");
                }
                bool checkThree = userInput.Contains(vowels[2].ToLower());
                if (checkThree == true)
                {
                    string vowelI = vowels[2].ToLower();
                    Console.WriteLine($"{vowelI} x{amountOfTimesI}");
                }
                bool checkFour = userInput.Contains(vowels[3].ToLower());
                if (checkFour == true)
                {
                    string vowelO = vowels[3].ToLower();
                    Console.WriteLine($"{vowelO} x{amountOfTimesO}");
                }
                bool checkFive = userInput.Contains(vowels[4].ToLower());
                if (checkFive == true)
                {
                    string vowelU = vowels[4].ToLower();
                    Console.WriteLine($"{vowelU} x{amountOfTimesU}");
                }

            }
            else
            {
                Console.WriteLine("There's No Vowels In Word You've Submitted!");
            }


        }
    }
}
