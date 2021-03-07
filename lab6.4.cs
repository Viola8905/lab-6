using System;

namespace lab6._4
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Console.WriteLine("введіть а ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введіть b ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("введіть к-ть елементів ");
            int n = int.Parse(Console.ReadLine());
            int[] k = new int[n];
           

            for (int i = 0; i < k.Length; i++)
            {

                Console.Write("Введіть елемент массиву x під індексом{0}:\t", i + 1);

                k[i] = int.Parse(Console.ReadLine());
            }

            int[] m = new int[k.Length];
            int n1 = 0;

            for (int i = 0; i < k.Length; i++)
            {
                if(k[i]<a|| k[i] > b)
            {
                m[n1] = k[i];
                n1++;
            }

  
            }
            for (int i = n1; i < m.Length; i++)
            {
                m[i] = 0;
            }

            Console.WriteLine("вивід масиву:");

            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            

            Console.ReadLine();

          
        }
    }
}
