// HW1a Sales Total

// Tate Rains:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            double sum;
            double sum2;
            double sum3;
            const double multiplier = 0.085;

            string productAsString;
            string num1AsString;
            string num2AsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            productAsString = Console.ReadLine();
            Console.WriteLine($"How many {productAsString} do you want to buy?");
            num1AsString = Console.ReadLine();
            Console.WriteLine($"What is the price for each {productAsString}?");
            num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);

            sum = num1 * num2;

            Console.WriteLine($"Your subtotal for your bill is ${sum.ToString("N2")}");

            sum2 = sum * multiplier;

            Console.WriteLine($"Your sales tax for your bill is ${sum2.ToString("N2")}");

            sum3 = sum + sum2;

            Console.WriteLine($"Your total for your bill is ${sum3.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
