using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using LitwareLib;

namespace CSharp_Assignment2
{
    [Serializable]
     class Program
    {
          public static void Main()
          {
            try
            {
                Console.WriteLine("enter no.of employee");
                int size = Convert.ToInt32(Console.ReadLine());
                Employee[] obj1 = new Employee[size];
                Employee obj = new Employee();
                List<string> list = new List<string>();
               
               

                Console.WriteLine("----------Accepting Employee Details----------");

                for (int i = 0; i < obj1.Length; i++)
                {
                    Console.WriteLine("Enter Employee Number:");
                    int no = int.Parse(Console.ReadLine());
                    obj.setempno(no);

                    Console.WriteLine("Enter Employee Name:");
                    string name = Console.ReadLine();
                    obj.setempname(name);
                    list.Add(name);

                    Console.WriteLine("Enter Employee Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    obj.setEmpSalary(salary);
                    //obj.sethra();
                    //obj.setta();
                    //obj.setda();
                    //obj.setgs();
                    //obj.calculatesalary();

                }

                    FileStream f = new FileStream(@"D:\train\c# .net Assignments\employee details.txt", FileMode.Open, FileAccess.Write);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(f,obj1);
                    f.Close();

                



                Console.WriteLine("----------displaying Employee Details----------");
                for (int i = 0; i < obj1.Length; i++)
                {
                    obj.getEmpNo();
                    obj.getEmpName();
                    obj.getEmpSalary();
                    obj.getgs();
                }


            Console.WriteLine("deserialization");

            FileStream fr = new FileStream(@"D:\train\c# .net Assignments\employee details.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter br = new BinaryFormatter();
            br.Deserialize(fr);
            
            
            
            


            foreach (string e in list)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("enter the employee name to search");
                string target=Console.ReadLine();
                
                bool isexist = list.Contains(target);
                if (isexist)
                {
                    Console.WriteLine("Element found in the list");
                }
                else
                {
                    Console.WriteLine("Element not found in the given list");
                }

            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.GetType().Name);
            }
          }
     }
}