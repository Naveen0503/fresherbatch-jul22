using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class swapping
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter the value of a");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the value of b");
                int sn = Convert.ToInt32(Console.ReadLine());

                Swap(fn, sn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }

        public static void Swap(int a, int b)
        {
            Console.WriteLine("before swapping a={0} b={1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swapping a={0} b={1}", a, b);

        }
    }
}
