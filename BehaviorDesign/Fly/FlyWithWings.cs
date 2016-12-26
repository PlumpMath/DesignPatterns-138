using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.BehaviorDesign.Interfaces;

namespace ConsoleApplication1.BehaviorDesign
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
