using System;

namespace lab6._3
{
    class Program
    {
        static double Sum(double[] arr, int i = 0)
        {
            if (i > arr.Length)
                return 0;
            return arr[i] + Sum(arr, i + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("count of coordinats");
            int n = int.Parse(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];


            for (int i = 0; i < x.Length; i++)
            {

                Console.Write("Введіть елемент массиву x під індексом{0}:\t",i+1);

                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {

                Console.Write("Введіть елемент массиву y під індексом{0}:\t",i+1);

                y[i] = int.Parse(Console.ReadLine());


            }
            double[] z = new double[n];
            double[] g = new double[n];
            double d = 0;

            for (int i = 0; i < g.Length; i++)
            {
                g[i] = x[i] * x[i];
            }

            for (int i = 0; i < z.Length; i++)
            {
                z[i] = y[i] * y[i];
            }
            for (int i = 0; i < n; i++)
            {
                d = x[i] * y[i]+d;
            }

            double f = 0;
            f = d / (Math.Sqrt(Sum(g)) * Math.Sqrt(Sum(z)));
            Console.WriteLine("косинус кута між векторами", f);

        }
    }
}
