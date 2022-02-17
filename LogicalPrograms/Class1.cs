using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Class1
    {
        public void PrimeNumber()
        {
            int i, m, value = 0;

            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("It is not a prime number");
                    value = 1;
                    //break;
                }
            }
            if (value == 0)
            {
                Console.WriteLine("It is a prime number");
            }

        }
    }
}

    

