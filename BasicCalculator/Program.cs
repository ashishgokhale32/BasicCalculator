using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Types of operations :-");
                Console.WriteLine("1. Addition\n2.Substraction\n3.Multiplication\n4.Division");
                Console.WriteLine();
                Console.WriteLine("Enter your choice:");
                byte choice = Convert.ToByte(Console.ReadLine());
                Calculator calc = new Calculator();
                int result = 0;
                switch (choice)
                {
                    case 1:
                        result = calc.Addition(num1, num2);
                        break;
                    case 2:
                        result = calc.Substraction(num1, num2);
                        break;
                    case 3:
                        result = calc.Multiplication(num1, num2);
                        break;
                    case 4:
                        result = calc.Division(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Internal error occurred!!");
            }
            
        }        
    }
}
