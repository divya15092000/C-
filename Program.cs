using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int a = 0; a <= n; a++)
            {
                for (int b = 0; b <= n - a; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c <= a; c++)
                {
                    Console.Write("* ");
                }
            }
        }
    }
}
