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
                        Calculator addNumbers = new Calculator();
                        Console.WriteLine("   = " + addNumbers.Add(firstNum, secondNum));
                        break;

                    case "-":
                        Calculator subtractNumbers = new Calculator();
                        Console.WriteLine("   = " + subtractNumbers.Subtract(firstNum, secondNum));
                        break;

                    case "*":
                        Calculator multiplyNumbers = new Calculator();
                        Console.WriteLine("   = " + multiplyNumbers.Multiply(firstNum, secondNum));
                        break;

                    case "/":
                        Calculator divideNumbers = new Calculator();
                        Console.WriteLine("   = " + divideNumbers.Divide(firstNum, secondNum));
                        break;

                    case "%":
                        Calculator modulusNumbers = new Calculator();
                        Console.WriteLine("   = " + modulusNumbers.Modulus(firstNum, secondNum));
                        break;

                    default:
                        break;
                }
                counter++;
            }
        }
    }
}
