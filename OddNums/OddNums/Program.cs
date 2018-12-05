using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=(99 + 1); i ++)
            {
                if(i % 2 != 0)
                {
                    Write(i.ToString());

                }
                Write();
            }

        }
    }
}
