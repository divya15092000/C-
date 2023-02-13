using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1, i;
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                n = n * i;
                Console.WriteLine(n);
            }
        }
    }
}
