﻿using BasicCorePrograms;
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Flip coin Program");
        Console.WriteLine("Hello User!\nPlease Enter the index no. of the program you want to run.");
        Console.WriteLine("1.Flip the Coin\n2.Leap Year\n3.Power Of 2\n4.HarmonicNumber\n5.Factors\n6.Quotient And Remainder\n7.Swap Number\n8.Even & Odd\n9.Vowel Or Consonant\n10. Largest Among Three Number");

        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                FlipTheCoin.FlipCoin();
                break;
            case 2:
                LeapYear.DetermineLeapYear();
                break;
            case 3:
                Power.PowerOf();
                break;
            case 4:
                HarmonicNumber.PrintHarmonicNumber();
                break;
                case 5: 
                    Factors.PrintPrimeFactors();    
                break;
                case 6: 
                    QuotientAndRemainder.ComputeQuotientAndRemainder();
                break;
                case 7:
                    SwapTwoNumbers.Swapumbers();
                break;
                case 8: 
                    EvenOdd.EvenOrOdd();
                break;
                case 9:
                    VowelOrConsonant.DetermineVowelOrConsonant();
                break;
                case 10:
                    LargestNumber.SearchLargestNumber();
                break;
            default:
                Console.WriteLine("Please Enter a Valid Index No.");
                break;
        }
        Console.ReadLine();
    }
    }

