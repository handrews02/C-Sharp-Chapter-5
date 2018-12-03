using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string testScore;
            int test = 0;
            int total = 0;
            int average = 0;
            int score =0;
            string exitInput;

            while(test != '!')
            {
                WriteLine("Enter you test score >>>");
                testScore = ReadLine();
                test = Convert.ToInt32(testScore);
                if(test >= 0 && test <= 100)
                {
                    total = total + test;
                    score = score + 1;

                }
                else
                {
                    WriteLine("ERROR");
                }

                average = total / score;
                WriteLine("To exit >>> '!'");
                exitInput = ReadLine();
            }
            WriteLine("Your total is " + total);
            WriteLine("Your average is " + average);

        }
    }
}
