using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
     class program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter array size");
                int size = Convert.ToInt32(Console.ReadLine());
                program.Sum(new int[size]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }

        }
        public static void  Sum(params int[] values)
        {
            Console.WriteLine("enter array values");
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            int totalsum = values.Sum();
            Console.WriteLine("totalsum ={0}", totalsum);
        }
    }
}
