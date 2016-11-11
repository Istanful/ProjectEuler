using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _1Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1000;

            Stopwatch timer = new Stopwatch();
            long time = 0;
            int result = Istanful.Sum(total);

            timer.Reset();
            timer.Start();

            for (int i = 0; i <= 500000; i++)
                Istanful.Sum(total);

            timer.Stop();
            time = timer.ElapsedMilliseconds;

            Console.WriteLine(  "Time elapsed:  {0, 10} \n" +
                                "Result:        {1, 10}", time, result);
            Console.ReadKey();
        }
    }
}
