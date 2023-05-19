using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class InsertionSort
    {
        public void Sort()
        {
            Console.Write("Enter a String: ");
            string n = Console.ReadLine();

            string[] words = n.Split(" ");

            foreach(var data in words)
            {
                Console.WriteLine(data);
            }
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            foreach(var data in words)
            {
                Console.WriteLine(data);
            }
        }
    }
}
