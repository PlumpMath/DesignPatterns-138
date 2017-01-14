using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryDesign
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string pizzaName)
        {
            Pizza pizza = CreatePizza(pizzaName);
            pizza.Prepare();
        }
        protected abstract Pizza CreatePizza(string item);
    }
}
