using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightriangle
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number:");
           int a = int.Parse(Console.ReadLine());
          Console.WriteLine("number is: " + a);
            Console.WriteLine("Enter number:");
            int b = int.Parse(Console.ReadLine());
           Console.WriteLine("number is: " + b);
            Console.WriteLine("Enter number:");
            int c = int.Parse(Console.ReadLine());
          Console.WriteLine("number is: " + c);
            if (a>b&&a>c)
            {
                Console.WriteLine("a is greater");
            }else if(b>a && b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
        }
    }
}
