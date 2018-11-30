using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messinWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 5;

            while ( i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            while (j >= 0)
            {
                Console.WriteLine(j);
                j--;
            }
            for(int x = 0; x <= 5; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
