using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Class1
    {
        public void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(" Entered the number is a perfect number");

            }
            else
            {
                Console.WriteLine("Entered the number is not a perfect number");

            }
        }
    }
}

    

