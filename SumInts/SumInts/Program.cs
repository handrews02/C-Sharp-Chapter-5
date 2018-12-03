using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            string inputString;
        
            while(num != 999)
            {
                WriteLine("Enter a number or 999 to exit >>>");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = (sum + num) - 999;
            }
            WriteLine("The sum is " + sum);
        }
    }
}
