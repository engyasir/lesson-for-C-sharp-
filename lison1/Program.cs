using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lison1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number1, number2;
            Double result;
            Console.WriteLine("Enter the first number : ");
            number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            number2 = Double.Parse(Console.ReadLine());
            result = number1 * number2;
            Console.WriteLine("The result is :" + result);
            Console.ReadKey();
            // برنامج ضرب عددين 
        }
    }
}
