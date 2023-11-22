using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    public class CalculationRequest
    {
        public string Operation { get; }
        public double Operand1 { get; }
        public double Operand2 { get; }

        public CalculationRequest(string operation, double operand1, double operand2)
        {
            Operation = operation;
            Operand1 = operand1;
            Operand2 = operand2;
        }
    }
}
