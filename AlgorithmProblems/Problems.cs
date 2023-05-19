using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class Problems
    {
        public void Permutation(string a , int x , int y)
        {
            if (x == y)
            {
                Console.WriteLine(a);
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    a = Swap(a , x , i);
                    Permutation(a , x + 1 , y );
                    a = Swap(a , x , i);
                }
            }
        }
        public string Swap(string p , int i , int j)
        {
            char temp;
            char[] charArray = p.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            
            string s = new string(charArray);
            return s;
        }
    }
}
