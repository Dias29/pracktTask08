using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask08
{
    class RangeOfArray
    {
        private readonly int minIndex;
        private readonly int maxIndex;
        private readonly int[] array;

        public RangeOfArray(int minIndex, int maxIndex)
        {
            this.minIndex = minIndex;
            this.maxIndex = maxIndex;
            array = new int[maxIndex - minIndex + 1];
        }

        public int this[int index]
        {
            get
            {
                return array[index - minIndex];
            }
            set
            {
                array[index - minIndex] = value;
            }
        }
    }
}
