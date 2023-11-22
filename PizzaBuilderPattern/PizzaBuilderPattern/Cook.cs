using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilderPattern
{
    public class Cook
    {
        private IPizzaBuilder _pizzaBuilder;

        public void SetPizzaBuilder(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza() => _pizzaBuilder.GetPizza();

        public void ConstructPizza()
        {
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }

}
