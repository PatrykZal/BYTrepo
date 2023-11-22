using CalculatorDesignPattern.IInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern.Implementation
{
    public class DivisionHandler : IOperationHandler
    {
        private IOperationHandler _handler;


        public void SetNext(IOperationHandler handler)
        {
            _handler = handler;
        }

        public double Handle(CalculationRequest request)
        {
            if (request.Operation == "divide")
            {
                return request.Operand1 / request.Operand2;
            }
            else if (_handler != null)
            {
                return _handler.Handle(request);
            }
            else
            {
                throw new InvalidOperationException("Operation not supported.");
            }
        }

    }
}
