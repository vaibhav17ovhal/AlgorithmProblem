﻿using System;

namespace AlgorithmProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problem");

            Console.WriteLine("\n ===================== \n");

            Problems pp = new Problems();
            string a = "VAI";
            int n = a.Length;
            pp.Permutation(a , 0, n - 1);
        }
    }
}
