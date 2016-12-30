using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.BehaviorDesign.Interfaces;

namespace DesignPatterns.BehaviorDesign
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly.");
        }
    }
}
