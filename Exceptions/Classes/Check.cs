using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Classes
{
    internal class Check
    {
        public void CheckMethod(string age) 
        {
            age = Console.ReadLine();
            while (!TypeCheckInt(age))
            {
                Console.WriteLine("Yoshingizni sonda kiriting:");
                age = Console.ReadLine();
            }
             bool TypeCheckInt(String input)
            {
                int number = 0;
                return int.TryParse(input, out number);
            }
        }
    }
        
}
