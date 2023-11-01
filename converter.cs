/* By Isaac Emmanuel */
/* X: @1cbyc */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A binary number is made up of elements called bits where each bit can be 1 or 0 */
namespace SoloLearn
{
    class Program
    {
        static string toBinary(int n)
        {
            if (n == 0)
            {
                return "0";
            }
    
            string binary = "";
            while (n > 0)
            {
                // The % (modulus) operator returns the remainder of the division
                int rem = n % 2;
                // add the result (0 or 1)
                binary = rem + binary;
                // divide the number by 2
                n = n / 2;
            }
    
            return binary;
        }
        
        static void Main(string[] args)
        { 
            //sample number
            int number = 156;
            
            Console.WriteLine(toBinary(number));
        }
    }
}
