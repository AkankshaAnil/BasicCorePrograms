using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonant
    {
        public static void DetermineVowelOrConsonant()
        {
            Console.WriteLine("Enter an alphabet: ");
            char alphabet = Console.ReadLine().ToLower()[0];

            if (IsAlphabet(alphabet))
            {
                if (IsVowel(alphabet))
                {
                    Console.WriteLine("The alphabet is a vowel.");
                }
                else
                {
                    Console.WriteLine("The alphabet is a consonant.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid alphabet.");
            }
        }

        private static bool IsAlphabet(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private static bool IsVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
    }

}
