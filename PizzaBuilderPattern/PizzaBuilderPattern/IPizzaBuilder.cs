using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilderPattern
{
    public interface IPizzaBuilder
    {
        void BuildDough();

        void BuildSauce();

        void BuildTopping();

        Pizza GetPizza();
    }

}
