using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Class1
    {
        public void Reverse()
        {
            int number, reminder,reverse=0;
            Console.WriteLine("Enter the numbers to reverse");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;

            }
            Console.WriteLine("The reversed numbers are :" + reverse);
        }
    }
}

    

