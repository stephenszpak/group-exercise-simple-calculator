﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {

        string testPattern = @"\b(?<FirstNum>\d+)\s*\b(?<Operator>[\+\/\-\+\%])\s*\b(?<SecondNum>\d+)";

        public void StringSplitter (string UserInput)
        {
            Regex Regex = new Regex(testPattern);


            if (true == Regex.IsMatch(UserInput))
            {

            }
            else
            {
                Console.WriteLine("input is invalid");

        private readonly object opr;

        public string Operator { get; set; }
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public string userInput { get; set; }
        

        
        public Expression()
        {
            Operator = null;
            FirstNum = 0;
            SecondNum = 0;   
        }

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


        public void VerifyExpression(string userInput)
        {
            string expressionString = @"\b(?<FirstNum>\d+)\s*\b(?<Operator>[\+\/\-\+\%])\s*\b(?<SecondNum>\d+)";
            Regex regExString = new Regex(expressionString);

            Match match = regExString.Match(userInput);

            if (match.Success)
            {
                FirstNum = int.Parse(match.Groups["FirstNum"].Value);
                Operator = match.Groups["Operator"].Value.ToString();
                SecondNum = int.Parse(match.Groups["SecondNum"].Value);

            }
        }

    }
}
