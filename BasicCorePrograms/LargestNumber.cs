﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public static void SearchLargestNumber()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = Math.Max(number1, Math.Max(number2, number3));

            Console.WriteLine("The largest number is: " + largestNumber);
        }
    }
}
