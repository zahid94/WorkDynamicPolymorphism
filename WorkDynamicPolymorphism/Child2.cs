using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDynamicPolymorphism
{
    public class Child2:Parent
    {
        public override void Show()
        {
            Console.WriteLine("I am from child2");
        }
    }
}
