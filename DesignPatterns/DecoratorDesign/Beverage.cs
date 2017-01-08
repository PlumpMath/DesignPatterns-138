using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesign
{
    public abstract class Beverage
    {
        protected string description = "Unknown Description";
        public abstract double Cost();
        public virtual string GetDescription()
        {
            return description;
        }
    }
}
