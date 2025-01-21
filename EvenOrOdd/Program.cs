using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get user to input an number
            Console.WriteLine("Input a number vaule");
            // collect the number 
            int usernumber = Convert.ToInt32(Console.ReadLine());
            //test number to see if even or odd by seeing if its divisible by 2
            if (usernumber % 2 == object)
            {
                //print out result
                Console.WriteLine(usernumber + " : is even number");
            }
            else 
            {
                //print out results
                Console.WriteLine(usernumber + " : is odd number");
            }

            Console.ReadLine();
            

        }
    }
}
