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
            double sales;
            double dTotal = 0;
            double eTotal = 0;
            double fTotal = 0;

            while(name != 'Z' || name !='z')
            {
                WriteLine("Sales Associates, please enter yur first initial >>> ");
                inputName = ReadLine();
                name = Convert.ToChar(inputName);
                if(name == 'd' || name == 'D')
                {
                    WriteLine("Enter your sales or 'z' to exit");
                    inputSales = ReadLine();
                    sales = Convert.ToDouble(inputSales);
                    dTotal = dTotal + sales;
                }
                else if(name == 'e' || name == 'E')
                {
                    WriteLine("Enter your sales or 'z' to exit");
                    inputSales = ReadLine();
                    sales = Convert.ToDouble(inputSales);
                    eTotal = eTotal + sales;
                }
            }
        }
    }
}
