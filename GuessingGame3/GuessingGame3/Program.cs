﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int count = 0;
            int min = 1;
            int max = 11;
            int againL = 1;
            int againH = 10;


            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);



            while (guess != randomNumber)
            {
                Console.WriteLine("Enter a number between 1 and 10 >> ");
                guess = int.Parse(ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                    count++;
                    if(guess <= againL)
                    {
                        WriteLine("What are you doing?! That was stupid!");
                    }
                    againL = guess;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                    count++;
                    if (guess >= againH)
                    {
                        WriteLine("What are you doing?! That was stupid!");
                    }
                    againH = guess;
                }
                else if (guess < 0 || guess > 10)
                {
                    Console.WriteLine("ERROR!");
                }

            }
            if (guess == randomNumber)
            {
                count++;
                Console.WriteLine("You are correct! It took you {0} times to guess {1}", count, randomNumber);
            }

        }
    }
}
