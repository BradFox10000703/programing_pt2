using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Question1(int a, int b)
        {
            return a + b;
        }
        static double Question2(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            
            int a = 74;
            int b = 36;
            double c = 50;
            double d = 3;
            Console.WriteLine("hi");
            Console.WriteLine("Hamiora taurima");
            Console.ReadLine();
            Console.WriteLine(Question1(a, b));
            Console.WriteLine(Question2(c, d));





        }
        static void Second()
        {
            int size = 1000;
            int[] nums = new int[size];

            Random rand = new Random();

            for (int i =0; i < nums.Length; i++ )
            {
                nums[1] = rand.Next(1000, 10000);

            }
            for (int i =0;i<nums.Length;i++)
            {
                Console.Write($"{nums[i]} ");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
        }


    }
}
