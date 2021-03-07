using System;

namespace lab_6._111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("count of elements");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {

                Console.Write("Введіть елемент массиву під індексом{i}:\t");

                a[i] = int.Parse(Console.ReadLine());
            }

            /* Console.WriteLine("вивід масиву:");       *вивід масиву а
             for (int i = 0; i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }
             Console.ReadLine();
            */

            int maxValue=a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if(a[i]<maxValue && a[i] < 0)
                {
                    maxValue = a[i];

                }

            }
            Console.WriteLine(maxValue);
            Console.ReadLine();

        }
    }
}
