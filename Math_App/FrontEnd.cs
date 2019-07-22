using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Math_App
{
    class Program1
    {
        static void Main(string[] args)
        {
            Program1 frontEnd = new Program1();
            Calc calc = new Calc();
            frontEnd.Salutation();
            frontEnd.Compute();
        } 
        public void Salutation()
        {
            string cmd;
            Console.WriteLine("Welcome, enter the command 'start' or 'exit': ");
            Console.Write(":>");
            cmd = Console.ReadLine();
            switch (cmd)
            {
                case "start":
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bad command");
                    Salutation();
                    break;
            }
            return;
        }
        public void Compute()
        {
            Calc calc = new Calc();
            string oper = calc.GetOperator();
            double num1 = calc.GetNumber1();
            double num2 = calc.GetNumber2();
            double result = 0.0;
            switch (oper)
            {
                case "+":
                    calc.Add(num1, num2, oper);
                    break;
                case "-":
                    calc.Subtract(num1, num2, oper);
                    break;
                case "*":
                    calc.Multiply(num1, num2, oper);
                    break;
                case "/":
                    calc.Divide(num1, num2, oper);
                    break;
            }
            Continue();
        }
        public void Continue()
            {
                string cont;
                Console.WriteLine("\nContinue? (y or n)");
                Console.Write(":>");
                cont = Console.ReadLine();
                switch (cont)
                {
                    case "y":
                        Compute();
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bad command");
                        Continue();
                        break;
                }
                return;

            }
    }
}     
            
    
        

    
