using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesign.Decorators
{
    public class Whip : CondimentDecorator
    {
        Beverage bevrage;
        public Whip(Beverage bv)
        {
            bevrage = bv;
        }
        public override double Cost()
        {
            return .10 + bevrage.Cost();
        }
        public override string GetDescription()
        {
            return $"{bevrage.GetDescription()}, Whip";
        }
    }
}
