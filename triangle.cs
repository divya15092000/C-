using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 50;
            for (b = 1; b <= a; b++)
            {
                for(c = 1; c <= a - b; c++)
                {
                    Console.Write(" ");
                }
                for (d = 1; d <= b; d++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
              
            }
        }
    }
}
