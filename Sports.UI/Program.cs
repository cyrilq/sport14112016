using Sports.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context c = new Context()) {
                foreach (var item in c.Teams)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadKey();
            }
 
        }
    }
    
}
