using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterLowerCaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = '\0';
            string inputLetter = null;

            while(letter != '!')
            {
                Console.WriteLine("Enter a lowercase letter >>> ");
                inputLetter = Console.ReadLine();
                letter = Convert.ToChar(inputLetter);
                if(letter >= 'a' && letter <= 'z')
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }    
    }
}
