using System;
using System.Linq;



namespace q2
{
    class question_2
    {
        public static void Main()
        {
            try
            {
                int[] Avgmarks = new int[5];
                Console.WriteLine("enter the Average marks of five students");
                for (int i = 0; i < Avgmarks.Length; i++)
                {
                    Avgmarks[i] = Convert.ToInt32(Console.ReadLine());
                }
                int Highestmarks = Avgmarks.Max();
                Console.WriteLine("highest marks ={0}", Highestmarks);
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}
