using BasicCorePrograms;
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Flip coin Program");
        Console.WriteLine("Hello User!\nEnter the index no. of the program you want to run.");
        Console.WriteLine("\"1.Flip the Coin\n2.Leap Year\n3.Power Of 2");

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
            default:
                Console.WriteLine("Please Enter a Valid Index No.");
                break;
        }
        Console.ReadLine();

    }
    }

