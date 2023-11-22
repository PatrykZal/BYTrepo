using CalculatorDesignPattern.IInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern.Implementation
{
    public class MultiplicationHandler : IOperationHandler
    {
        private IOperationHandler _handler;

        public void SetNext(IOperationHandler handler) 
        {
            _handler = handler;
        }

        public double Handle(CalculationRequest req) 
        {
            if (req.Operation == "multiply") 
            {
                return req.Operand1 * req.Operand2;
            }
            else if (_handler != null)
            {
                return _handler.Handle(req);
            }
            else
            {
                throw new InvalidOperationException("Operation not supported.");
            }
        }

    }
}
