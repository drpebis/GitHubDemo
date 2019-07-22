using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Math_App
{
    public class Calc
    {
        public string GetOperator()
        {
            Console.Clear();
            Console.WriteLine("Enter an operator (+, -, *, /)");
            Console.Write(":>");
            string oper = Console.ReadLine().ToString().ToLower();
            if (oper == "+")
            {
                return oper;
            }
            else if (oper == "-")
            {
                return oper;
            }
            else if (oper == "*")
            {
                return oper;
            }
            else if (oper == "/")
            {
                return oper;
            }
            else
            {
                Console.WriteLine("Invalid entry. Press Enter to retry.");
                Console.ReadLine();
                GetOperator();
            }
            return oper;

        }
        public double GetNumber1()
        {
            double num1 = 0.0;
            Console.Clear();
            Console.WriteLine("Enter number 1:");
            Console.Write(":>");
            string n1 = Console.ReadLine();
            if (Regex.IsMatch(n1, $"^[0-9]*"))
            {
                num1 = double.Parse(n1);
            }
            else
            {
                Console.WriteLine("Invalid entry, numbers only please");
                Console.ReadLine();
                GetNumber1();
            }
            return num1;
        }
        public double GetNumber2()
        {
            double num2 = 0.0;
            Console.WriteLine("Enter number 2:");
            Console.Write(":>");
            string n2 = Console.ReadLine();
            if (Regex.IsMatch(n2, $"^[0-9]*"))
            {
                num2 = double.Parse(n2);
            }
            else
            {
                Console.WriteLine("Invalid entry, numbers only please");
                Console.ReadLine();
                GetNumber2();
            }
            return num2;
        }
        public void Add(double num1, double num2, string oper)
        {
            double result = num1 + num2;
            Console.WriteLine($"\nThe result is: {num1} {oper} {num2} = {result}");
        }
        public void Subtract(double num1, double num2, string oper)
        {
            double result = num1 - num2;
            Console.WriteLine($"\nThe result is: {num1} {oper} {num2} = {result}");
        }
        public void Multiply(double num1, double num2, string oper)
        {
            double result = num1 * num2;
            Console.WriteLine($"\nThe result is: {num1} {oper} {num2} = {result}");
        }
        public void Divide(double num1, double num2, string oper)
        {
            Program1 frontEnd = new Program1();

            if (num2 == 0)
            {
                Console.WriteLine("Division by 0 is not valid. Press enter to retry");
                Console.ReadLine();
                frontEnd.Compute();
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($"\nThe result is: {num1} {oper} {num2} = {result}");
            }
        }
    }
}
