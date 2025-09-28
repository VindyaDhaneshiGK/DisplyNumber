using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplyNumber
{
    public class NumberDisplay
    {
        
      public void DisplayNumbers()
        {
            Console.WriteLine("Pring Numbers 1 to 10, Starting!");
            for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Number is:"+i);
            }
            Console.WriteLine("Printing Done!");
        }
    }
}
