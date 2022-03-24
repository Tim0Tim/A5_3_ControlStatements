using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_3_ControlStatements
{
    class AutoPolicyTest
    {
        static public void Main()
        {
            Console.WriteLine("Please incert state abreviation...(all caps are required)");
            string Test = Console.ReadLine();

            if (Test == "MA" || Test == "NJ" || Test == "NY" || Test == "PA" || Test == "CT" || Test == "ME" || Test == "NH" || Test == "PA" || Test == "VT")
            {
                Console.WriteLine($"{Test} is a No Fault State");
            }
            else
            {
                Console.WriteLine($"{Test} is Not a 'No Fault State' or is an invalid response");
            }

            
        }
    }
}
