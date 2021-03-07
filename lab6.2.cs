using System;

namespace lab6._2
{
    class Program
    {
        static int Factorial(int k)
        {
            if (k == 0)
                return 1;
            else
                return k * Factorial(k - 1);
        }

            static void Main(string[] args)
            {
            Console.Write("count of elements");
            int n = int.Parse(Console.ReadLine());
            double [] a = new double[n];
            Console.Write("введіть число менше по типу 0.0а");
            double  x = Convert.ToDouble(Console.ReadLine());
            double y;
            double z;
            double r;


            
            for (int  i = 1; i < a.Length; i++)
            {

                 y = i * x;
                 z = Math.Sin(y);
                 r = Factorial(i) * z;



                a[i] = Math.Pow(i - 1, 2)/(2*Math.Pow(i,2)-1)+r;
            }


            /*Console.WriteLine("вивід масиву:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine(); */

            double[] b = new double[n];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    b[i] = b[i - 1] * a[i];
                    Console.WriteLine(b[i]);
                }
                else
                {
                    b[i] = b[i - 1] + i*Math.Abs(a[i]);
                    Console.WriteLine(b[i]);
                }
            }

            

        }
    }
}
