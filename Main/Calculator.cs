using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Calculator
    {
        private double operand1;
        private double operand2;
        private double _result;
        public double Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        public Calculator(double operand1, double operand2) 
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
        public double Add()
        {
            return Add(operand1, operand2);
        }
        public static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public double Subtract()
        {
            return Subtract(operand1, operand2);
        }
        public static double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        
        public double Multiply()
        {
            return Multiply(operand1, operand2);
        }
        public static double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public double Divide()
        {
            return Divide(operand1, operand2);
        }
        public static double Divide(double operand1, double operand2)
        {
            //TODO:Validation for divide by 0
            return operand1 / operand2;
        }
    }
}
