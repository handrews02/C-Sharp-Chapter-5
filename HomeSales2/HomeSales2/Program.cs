using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string inputName = null;
            string inputSales = null;
            char name = '\0';
            double sales = 0;
            double dTotal = 0;
            double eTotal = 0;
            double fTotal = 0;
            double total;

            //get input
                WriteLine("Sales Associates, enter your initals >>> ");
                inputName = ReadLine();
                name = Convert.ToChar(inputName);

            //test for conditions
            while (name != 'Z' && name != 'z')
            {
               
                WriteLine("Sales Associates, enter your sales >>> ");
                inputSales = ReadLine();
                sales = Convert.ToDouble(inputSales);


                if (name == 'd' || name == 'D')
                    dTotal = dTotal + sales;
                else if (name == 'e' || name == 'E')
                    eTotal = eTotal + sales;
                else if (name == 'f' || name == 'F')
                    fTotal = fTotal + sales;

                WriteLine("Sales Associates, enter your initals >>> ");
                inputName = ReadLine();
                name = Convert.ToChar(inputName);
            }   

            //write output
            total = dTotal + eTotal + fTotal;
            WriteLine("F: Your total is ${0}", fTotal);
            WriteLine("E: Your total is ${0}", eTotal);
            WriteLine("D: Your total is ${0}", dTotal);
            WriteLine("Your grand total is ${0}", total);



        }
    }
}
