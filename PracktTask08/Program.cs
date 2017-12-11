using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask08
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray tempArr = new RangeOfArray(2, 5);

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("Element #{0} = {1}", i, tempArr[i]);
            }
        }
    }
}
