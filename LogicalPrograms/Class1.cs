using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Class1
    {
        public void Fibonacci()
        {
            int num1 = 0, num2 = 1, num3;
            
            Console.WriteLine("Enter the number of Elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num1 + " "); // prints value of 1st and 2nd 
            Console.WriteLine(num2 + " ");

            for (int i = 0; i < number; i++) 
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
    

