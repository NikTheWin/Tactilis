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

            int[] outBuf = new int[44100];

            ButterworthLowPassFilter lpf = new ButterworthLowPassFilter();
            
            sw.Start();

            for (int i = 0; i < 44100; i++)
            {
                double yValue = Math.Sin(i * 2 * Math.PI);

                lpf.Filter(yValue);

                outBuf[i] = (int)Math.Round(yValue * 44100);
            }

            sw.Stop();

            Console.WriteLine("Synth for-loop took: " + sw.ElapsedMilliseconds.ToString());
            Console.WriteLine("You could have " + (800 / sw.ElapsedMilliseconds).ToString() + " voices of this synth with 20% margin");
            Console.ReadLine();
        }
    }
}
