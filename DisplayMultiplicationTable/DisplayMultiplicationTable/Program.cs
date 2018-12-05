using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            for(int i = 1; i <=10; i++)
            {
                
                for(int j = 1; j <= 10; j++)
                {
                    
                    total = i * j;
                    Write("{0,5}", (total));
                }
                WriteLine();
            }
            
            
        }
        
    }
}
