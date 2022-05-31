using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class mainClass2
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.parall();

            Thread a = new Thread(obj.multi);
            Thread b = new Thread(obj.multi2);
            Thread c = new Thread(obj.parall);
            Thread d = new Thread(obj.multi3);
            Thread e = new Thread(obj.multi3);
            c.Start();
            //a.Start();
            //b.Start();
        }
    }
}
