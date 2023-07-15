using BasicCorePrograms;
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Flip coin Program");
        Console.WriteLine("Hello User!\n Please Enter the index no. of the program you want to run.");
        FlipTheCoin Coin = new FlipTheCoin();
        Coin.FlipCoin();
    }
}
