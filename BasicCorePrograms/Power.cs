﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Power
    {
        public static void PowerOf()
        {
            Console.WriteLine("Enter the power value (0 <= N < 31): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0 || n >= 31)
            {
                Console.WriteLine("Invalid input. N should be between 0 and 30.");
                return;
            }

            Console.WriteLine("Powers of 2 up to 2^{0}:", n);
            for (int i = 0; i <= n; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i, power);
            }
        }
    }
}
