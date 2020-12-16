using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, counter, start, end;
            Console.WriteLine("Starting Number");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upto: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start, end);

            for (num = start; num <= end; num++)
            {
                counter = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
    
}
