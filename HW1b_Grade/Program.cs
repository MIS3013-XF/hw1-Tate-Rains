// HW1b Grade

// Tate Rains:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;

            double sum;
            const double total = 5.00;

            string name1AsString;
            string name2AsString;
            string studentIDAsString;
            string num1AsString;
            string num2AsString;
            string num3AsString;
            string num4AsString;
            string num5AsString;

            Console.WriteLine("What is your first name?");
            name1AsString = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            name2AsString = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            studentIDAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homework?");
            num1AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            num2AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the quizzes?");
            num3AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the midterm?"); 
            num4AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final?");
            num5AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);
            num3 = Convert.ToDouble(num3AsString);
            num4 = Convert.ToDouble(num4AsString);
            num5 = Convert.ToDouble(num5AsString);

            sum = num1 + num2 + num3 + num4 + num5;

            sum = sum / total;

            Console.WriteLine($"{name1AsString} {name2AsString} ({studentIDAsString}), your final grade is {sum}%");
            Console.ReadKey();
        }
    }
}
