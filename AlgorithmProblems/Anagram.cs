using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class Anagram
    {
        public void Word()
        {
            Console.Write("Enter words to check an anagram: ");
            string one = Console.ReadLine();
            string two = Console.ReadLine();

            if (one.Length != two.Length)
            {
                Console.WriteLine("Given word is not an anagram.");
            }
            else
            {
                char[] word1 = one.ToCharArray();
                Array.Sort(word1);
                one = word1.ToString();

                char[] word2 = two.ToCharArray();
                Array.Sort(word2);
                two = word2.ToString();

                if (one.Equals(two))
                {
                    Console.WriteLine("Given word is anagram.");
                }
                else
                {
                    Console.WriteLine("Gievn word is not an anagram.");
                }
            }
        }
    }
}
