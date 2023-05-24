using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BinarySearch
    {
        public void Binary<T>() where T : IComparable
        {
            Console.Write("Enter a sentence: ");
            string n = Console.ReadLine();

            string[] word = n.Split(" ");
            foreach(var data in word)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("Enter word to search: ");
            string search = Console.ReadLine();
            foreach(var data in word)
            {
                if (data.Equals(search))
                {
                    Console.WriteLine($"Found : {search}");
                    return;
                }
            }
            Console.WriteLine($"Not Found : {search}");
        }
    }
}
