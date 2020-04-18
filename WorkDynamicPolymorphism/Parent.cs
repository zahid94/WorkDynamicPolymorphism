using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDynamicPolymorphism
{
    public class Parent
    {
        public void OwnShow()
        {
            Console.WriteLine("I am from parent.");
        }
        public virtual void Show()
        {
            Console.WriteLine("I am checking for show from parent.");
        }
    }
}
