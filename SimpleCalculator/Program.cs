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

            int counter = 0;
            Console.Write($"[{counter}]> ");


        public void MathEquations(int firstNum, int secondNum, char opr)
        {
            if (opr == '+')
            {
                Calculator addNum = new Calculator();
                addNum.Add(firstNum, secondNum);
            }
            else if (opr == '-')
            {
                Calculator subtractNum = new Calculator();
                subtractNum.Subtract(firstNum, secondNum);
            }
            else if (opr == '*')
            {
                Calculator multiplyNum = new Calculator();
                multiplyNum.Multiply(firstNum, secondNum);
            }
            else if (opr == '/')
            {
                Calculator divideNum = new Calculator();
                divideNum.Divide(firstNum, secondNum);
            }
            else if (opr == '%')
            {
                Calculator modNum = new Calculator();
                modNum.Modulus(firstNum, secondNum);
            }
        }


    }
}
