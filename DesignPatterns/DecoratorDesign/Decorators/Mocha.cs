using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesign.Decorators
{
    public class Mocha : CondimentDecorator
    {
        Beverage bevrage;
        public Mocha(Beverage bv)
        {
            bevrage = bv;
        }
        public override double Cost()
        {
            return .20 + bevrage.Cost();
        }
        public override string GetDescription()
        {
            return $"{bevrage.GetDescription()}, Mocha";
        }
    }
}
