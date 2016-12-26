using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.BehaviorDesign
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}
