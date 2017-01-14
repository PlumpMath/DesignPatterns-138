using DesignPatterns.AbstractFactoryDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryDesign
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            pizzaInGredientFactory = ingredientFactory;

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing");
        }
    }
}
