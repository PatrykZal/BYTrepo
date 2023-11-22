using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilderPattern
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough() => _pizza.Dough = "Thin";
        public void BuildSauce() => _pizza.Sauce = "Tomato";
        public void BuildTopping() => _pizza.Topping = "Cheese";
        public Pizza GetPizza() => _pizza;
    }

}
