using System;

namespace Q1
{
    class ArithmeticOperations
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter A value");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter B value");
                int B = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                Console.WriteLine("select your choice");
                Console.WriteLine("1.Addition\n2.subtraction\n3.Multiplication\n4.division");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        result = A + B;
                        Console.WriteLine("addition ");
                        break;
                    case 2:
                        result = A - B;
                        Console.WriteLine("substraction");
                        break;
                    case 3:
                        result = A * B;
                        Console.WriteLine("multiplication");
                        break;
                    case 4:
                        result = A / B;
                        Console.WriteLine("division");
                        break;
                    default:
                        Console.WriteLine("enter a correct choice");
                        break;
                }
                Console.WriteLine("result={0}", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}
