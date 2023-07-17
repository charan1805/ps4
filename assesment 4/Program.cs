using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_4
{
    
   

namespace assignment_4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Imput a #: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine($"The number {num} is positive.");
                }
                else if (num < 0)
                {
                    Console.WriteLine($"The number {num} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is zero.");
                }


                string checkOddEven = (num % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"The number {num} is " + checkOddEven + ".");

                Console.ReadLine();
            }
        }
    }
}
   

