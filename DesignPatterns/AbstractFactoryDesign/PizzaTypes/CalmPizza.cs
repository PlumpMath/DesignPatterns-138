using DesignPatterns.AbstractFactoryDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryDesign
{
    public class CalmPizza : Pizza
    {
        public CalmPizza(IPizzaIngredientFactory ingredientFactory)
        {
            pizzaInGredientFactory = ingredientFactory;

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing");
        }
    }
}
