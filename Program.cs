using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember e1 = new Ember();
            Ember e2 = new Ember("Jani", 25, "Férfi");
            Tanulo t1;
            t1 = new Tanulo();

            e1.Bemutatkozik();
            e2.Bemutatkozik();
            t1.Bemutatkozik();
            Console.ReadKey();
               
        }
    }
}
