using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName= null;
            string inputSales = null;
            char name = '\0';
            double dSales = 0;
            double eSales = 0;
            double fSales = 0;
            double dTotal = 0;
            double eTotal = 0;
            double fTotal = 0;
            double total = 0;


            while(name != 'Z' || name !='z')
            {
                WriteLine("Sales Associates, please enter your first initial >>> ");
                inputName = ReadLine();
                name = Convert.ToChar(inputName);
                if(name == 'd' || name == 'D')
                {
                    WriteLine("Enter your sales or 'z' to exit");
                    inputSales = ReadLine();
                    dSales = Convert.ToDouble(inputSales);
                    dTotal = dTotal + dSales;
                    WriteLine("Your totakl is ${0}", dTotal);
                   
                }
                else if(name == 'e' || name == 'E')
                {
                    WriteLine("Enter your sales or 'z' to exit");
                    inputSales = ReadLine();
                    eSales = Convert.ToDouble(inputSales);
                    eTotal = eTotal + eSales;
                    WriteLine("Your total is ${0}", eTotal);
                   
                }
                else if(name == 'f' || name == 'F')
                {
                    WriteLine("Enter your sales or 'z' to exit");
                    inputSales = ReadLine();
                    fSales = Convert.ToDouble(inputSales);
                    fTotal = fTotal + fSales;
                    WriteLine("Your total is ${0}", fTotal);
                    
                }
                else
                {
                    WriteLine("ERROR Sales Associates, please enter yur first initial >>>  ");
                }

            }
        }
    }
}
