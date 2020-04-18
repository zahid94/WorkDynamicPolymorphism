using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p;
            Console.WriteLine("Enter the choose: ");
            int ch = Int32.Parse(Console.ReadLine());
            if (ch==1)
            {
                p = new Child1();
            }
            else
            {
                p = new Child2();
            }
            p.OwnShow();
            p.Show();
        }
    }
}
