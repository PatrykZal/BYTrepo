using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilderPattern
{
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough() => _pizza.Dough = "Thick";
        public void BuildSauce() => _pizza.Sauce = "Barbeque";
        public void BuildTopping() => _pizza.Topping = "Pepperoni";
        public Pizza GetPizza() => _pizza;
    }

}
