using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_1.a
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Random rand = new Random();
                double[] dub1 = new double[1000];
                Console.WriteLine("******** Random Doubles 0 - 10 1000 numbers ********");
                for (int i = 0; i < dub1.Length; i++)
                {
                    dub1[i] = Math.Round((rand.NextDouble() * 10), 3);
                    Console.Write("{0,0:N4}\t", dub1[i]);
                    Formatting(i);
                }
            Console.ReadKey();
            double[] dub2 = new double[dub1.Length];
            Array.Copy(dub1, dub2, 1000);
            var greaterthan2 = from number in dub2
                               where (number > 2)
                               select number;

            foreach(double x  in greaterthan2)
                {
                Console.WriteLine(x);
                }

            }
            static void Formatting(int i)
            {
                int rowCount = 10;
                if ((i + 1) % rowCount == 0)
                    Console.WriteLine();
            }

        
        
    }
}
