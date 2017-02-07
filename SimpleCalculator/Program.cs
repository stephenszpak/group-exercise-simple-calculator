using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (true)
            {
                Console.Write($"[{counter}]> ");

                string Command = Console.ReadLine();

                Expression expression = new Expression();
                expression.VerifyExpression(Command);
                int firstNum = expression.FirstNum;
                int secondNum = expression.SecondNum;
                string Operator = expression.Operator;

                switch (Operator)
                {
                    case "+":
                        Calculator calcAdd = new Calculator();
                        Console.WriteLine("   = " + calcAdd.Add(firstNum, secondNum));
                        break;

                    case "-":
                        Calculator calcSubtract = new Calculator();
                        Console.WriteLine("   = " + calcSubtract.Subtract(firstNum, secondNum));
                        break;
                            
                    case "*":
                        Calculator calcMultiply = new Calculator();
                        Console.WriteLine("   = " + calcMultiply.Multiply(firstNum, secondNum));
                        break;

                    case "/":
                        Calculator calcDivide = new Calculator();
                        Console.WriteLine("   = " + calcDivide.Divide(firstNum, secondNum));
                        break;

                    case "%":
                        Calculator calcModulus = new Calculator();
                        Console.WriteLine("   = " + calcModulus.Modulus(firstNum, secondNum));
                        break;

                    default:
                        break;
                }
                counter++;
            }
        }
    }
}
