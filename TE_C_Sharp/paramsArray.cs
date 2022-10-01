using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_C_Sharp
{
    internal class paramsArray
    {
        public static void Main()
        {
            Multiplication(1);
            Multiplication(2,3);
            Multiplication(4,5,6);
            Multiplication(7,8,9,10); 
        }
        public static void Multiplication(params int[] n)
        {
            int res = 0;
            foreach(int i in n)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Multiplication table for {i}");
                for(int j = 1; j <= 10; j++) {
                    res = i * j;
                    Console.WriteLine($"{i} * {j} = {res}");
                    }
            }
        }
    }
}
