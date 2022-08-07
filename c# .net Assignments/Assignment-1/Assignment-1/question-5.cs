using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    class Circle
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter the radius of the circle");
                double radius = Convert.ToDouble(Console.ReadLine());
                double areaofcircle, circumferenceofcircle;
                cal(radius, out areaofcircle, out circumferenceofcircle);
                Console.WriteLine("area of circle = {0}\ncircumference of cicrle ={1}", areaofcircle, circumferenceofcircle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }

        public static void cal(double r ,out double area,out double circumference, double pi = 3.142)
        {
            area = pi * (r * r);
            circumference = 2 * pi * r;
        }
    }
}
