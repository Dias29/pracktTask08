using System;

namespace PracktTask08
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_NUM = -100;
            const int MAX_NUM = 200;

            int minIndex;
            Console.WriteLine("Введите минимальный диапазон массив: ");
            bool isParcedmin = int.TryParse(Console.ReadLine(), out minIndex);
            if (!isParcedmin)
            {
                Console.Write("Ошибка!");
            }

            int maxIndex;
            Console.WriteLine("Введите максимальный диапазон массива: ");
            bool isParcedmax = int.TryParse(Console.ReadLine(), out maxIndex);
            if(!isParcedmax)
            {
                Console.Write("Ошибка!");
            }

            RangeOfArray array = new RangeOfArray(minIndex, maxIndex);

            Random rnd = new Random();

            if(minIndex < maxIndex)
            {
                Console.WriteLine("\n");
                for (int i = minIndex; i < maxIndex; i++)
                    {
                        array[i] = rnd.Next(MIN_NUM, MAX_NUM);
                        Console.WriteLine("{0} - {1}", i, array[i]);
                    }
            }
            else
            {
                    for (int i = maxIndex; i < minIndex; i++)
                    {
                        array[i] = rnd.Next(MIN_NUM, MAX_NUM);
                        Console.WriteLine("{0} - {1}", i, array[i]);
                    }
            }
            Console.WriteLine();

            int index;
            while(true)
            {
                try
                {
                    Console.WriteLine("Введите индекс элемента массива: ");
                    bool isParcedIndex = int.TryParse(Console.ReadLine(), out index);
                    if(!isParcedIndex)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        if(minIndex <maxIndex)
                        {
                            for (int j = minIndex; j < maxIndex; j++)
                            {
                                for (int i = minIndex; i < maxIndex; i++)
                                {
                                   // Console.WriteLine("{0} - {1}", j ,array[i]);
                                }
                            }
                        }
                        else
                        {
                            for (int j = minIndex; j < maxIndex; j++)
                            {
                                for (int i = maxIndex; i < minIndex; i++)
                                {
                                   // Console.Write("{0} - {1}", j,  array[i]);
                                }
                            }
                        }
                        Console.WriteLine();

                        Console.WriteLine("Элемент с индексом {0} = {1}", index, array[index]);
                    }
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
