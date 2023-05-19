using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
        public void Sort()
        {
            Console.Write("Enter list of numbers: ");
            string n = Console.ReadLine();

            string[] words = n.Split(" ");

            int[] num = new int[words.Length];
            int count = 0;

            foreach (var data in words)
            {
                num[count] = Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            Console.WriteLine("");
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1 ; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            foreach(var data in num)
            {
                Console.WriteLine(data);
            }
        }
    }
}
