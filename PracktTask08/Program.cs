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
            RangeOfArray tempArr = new RangeOfArray(2, 11);

            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine("Element #{0} = {1}", i, tempArr[5]);
            //}

            Console.WriteLine(tempArr[10]);

            Console.ReadLine();
        }
    }
}
