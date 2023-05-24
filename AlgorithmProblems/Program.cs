using System;

namespace AlgorithmProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problem");

            //Console.WriteLine("\n ===================== \n");

            //Problems pp = new Problems();
            //string a = "VAI";
            //int n = a.Length;
            //pp.Permutation(a , 0, n - 1);

            //Console.WriteLine("\n ===================== \n");

            //BinarySearch bs = new BinarySearch();
            //bs.Binary();

            //Console.WriteLine("\n ===================== \n");

            //InsertionSort insertion = new InsertionSort();
            //insertion.Sort();

            //Console.WriteLine("\n ===================== \n");

            BubbleSort bubble = new BubbleSort();
            bubble.Sort();

            //Console.WriteLine("\n ===================== \n");

            //Anagram anagram = new Anagram();
            //anagram.Word();

            //Console.WriteLine("\n ===================== \n");

            //PrimeNumber number = new PrimeNumber();
            //number.Prime();
        }
    }
}
