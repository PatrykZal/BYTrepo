using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDesignPattern.IInterface;

namespace CalculatorDesignPattern.Implementation
{
    public class AdditionHandler : IOperationHandler
    {
        private IOperationHandler _nextHandler;

        public void SetNext(IOperationHandler handler)
        {
            _nextHandler = handler;
        }

        public double Handle(CalculationRequest request)
        {
            if (request.Operation == "add")
            {
                return request.Operand1 + request.Operand2;
            }
            else if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                throw new InvalidOperationException("Operation not supported.");
            }
        }
    }

}
