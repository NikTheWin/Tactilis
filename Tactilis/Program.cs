using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tactilis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            int[] outBuf = new int[44100];

            for (int i = 0; i < 44100; i++)
            {
                double yValue = Math.Sin(i * 2 * Math.PI);

                outBuf[i] = (int)Math.Round(yValue * 44100);
            }

            sw.Stop();

            Console.WriteLine("Sine for-loop took: " + sw.ElapsedMilliseconds.ToString());
            Console.ReadLine();
        }
    }
}
