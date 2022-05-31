using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
  
        public void multi()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(i);
            }
        }
        public void multi2()
        {
            for(int i =0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(i);
            }
        }
        public void paral(string item)
        {
            Console.WriteLine(item);
        }
      
        
        
        public void parall()
        {
            List<string> detaillist = new List<string>()
            {
                "apple","car","time","date"
            };

            /* for (int i = 0; i < detaillist.Count; i++)
             {
                 Console.WriteLine(i);
             }*/
            Parallel.ForEach(detaillist, item => paral(item));
             
        }
        public void multi3()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }

    }

}
