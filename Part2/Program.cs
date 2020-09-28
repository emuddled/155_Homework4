/// Homework No. 4		Exercise Part 2
/// File Name: CoinFlip
/// @author: Evan Sinclair
/// Date:  Sept 26, 2020
///
/// Problem Statement:Write a program that will print out statistics for eight coin tosses. 
/// The user will input either an “h” for heads or a “t” for tails for the eight tosses. The 
/// program will then print out the total number and percentages of heads and tails.
/// 
/// Overall Plan:
/// 1)declare int variables for heads, tails and total flips
/// 2)give the user instructions for inputting coinflip results
/// 3)use a for loop to get 8 inputs and increment heads or tails 
/// 4)on an incorrect input, warn the user and decrement flips
/// 5)calculate percent heads and tails
/// 6)Output results
///
///
using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables to increment
            int heads = 0;
            int tails = 0;
            int flips;
            
            // char for input
            char headOrTail;
            
            // double to calculate percentage heads/tails
            double percentHeads;
            
            // for loop to read in flip results
            Console.WriteLine("Welcome to the coin flip program");
            Console.WriteLine("flip a coin 8 times and type in \"h\" for heads and \"t\" for tails after each flip");
            for (flips = 0; flips < 8; flips++)
            {
                Console.WriteLine("flip number " + (flips + 1));
                
                headOrTail = Convert.ToChar(Console.ReadLine());
                if (headOrTail == 'h')
                {
                    heads++;
                }
                else if (headOrTail == 't')
                {
                    tails++;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    flips--;
                }

            }
           
            // calculate and display information
            percentHeads = (Convert.ToDouble(heads) / 8) * 100;
            Console.WriteLine("Number of heads: " + heads);
            Console.WriteLine("Number of tails: " + tails);
            Console.WriteLine("Percent heads: " + percentHeads);
            Console.WriteLine("Percent tails: " + (100 - percentHeads));


        }
    }
}
