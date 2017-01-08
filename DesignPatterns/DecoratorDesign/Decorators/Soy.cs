using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesign.Decorators
{
    public class Soy : CondimentDecorator
    {
        Beverage bevrage;
        public Soy(Beverage bv)
        {
            bevrage = bv;
        }
        public override double Cost()
        {
            return .15 + bevrage.Cost();
        }
        public override string GetDescription()
        {
            return $"{bevrage.GetDescription()}, Soy";
        }
    }
}
