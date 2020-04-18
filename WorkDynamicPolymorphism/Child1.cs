using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDynamicPolymorphism
{
    public class Child1:Parent
    {
        public override void Show()
        {
            Console.WriteLine("I am from child1");
            //check base class
            base.Show();
        }
    }
}
