using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesign
{
    public class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            description = "Houseblend";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
