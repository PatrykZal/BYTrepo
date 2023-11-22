using CalculatorDesignPattern.IInterface;
using CalculatorDesignPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    public class Calculator
    {
        private IOperationHandler _chain;

        public Calculator()
        {
            var addition = new AdditionHandler();
           
            var multiplication = new MultiplicationHandler();

            var division = new DivisionHandler();

            var substraction = new SubstractionHandler();

            addition.SetNext(multiplication);
            multiplication.SetNext(substraction);
            substraction.SetNext(division);

            _chain = addition;

        }

        public double Calculate(CalculationRequest request)
        {
            return _chain.Handle(request);
        }
    }

}
