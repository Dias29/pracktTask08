using System;

namespace PracktTask08
{
    class RangeOfArray
    {
        private int minIndex;
        private int maxIndex;
        private int[] array;

        public RangeOfArray(int minIndex, int maxIndex)
        {
            this.minIndex = minIndex;
            this.maxIndex = maxIndex;
            if (minIndex > maxIndex)
                array = new int[minIndex - maxIndex];
            else
                array = new int[maxIndex - minIndex];
        }

        public int this[int index]
        {
            set
            {
                if (minIndex < maxIndex)
                {
                    if (index < minIndex || index > maxIndex)
                        throw new IndexOutOfRangeException("Индекс вне границ массива!");
                    array[index - minIndex] = value;
                }
                else
                {
                    if (index > minIndex || index < maxIndex)
                        throw new IndexOutOfRangeException("Индекс вне границ массива!");
                    array[index - maxIndex] = value;
                }
            }
            get
            {
                if (minIndex < maxIndex)
                {
                    if (index < minIndex || index > maxIndex)
                        throw new IndexOutOfRangeException("Индекс вне границ массива!");
                    return array[index - minIndex];
                }
                else
                {
                    if (index > minIndex || index < maxIndex)
                        throw new IndexOutOfRangeException("Индекс вне границ массива!");
                    return array[index - maxIndex];
                }

            }


        }
    }
}
