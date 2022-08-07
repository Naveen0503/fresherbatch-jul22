using System;
using System.Collections.Generic;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                EmpID = 1,
                EmpName = "Sourabh",
                EmpSalary = 50000
            };
                            
            List<Employee> employees = new List<Employee>(1);
            employees.Add(employee1);
                                  
            foreach (Employee c in employees)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", c.EmpID, c.EmpName, c.EmpSalary);
            }
            again:
            Console.WriteLine("do you want to add emoployee---yes or no");
            string choice =Convert.ToString(Console.ReadLine());

            if(choice.ToUpper() == "YES")
            {
                Employee employeen = new Employee();
                Console.WriteLine("enter your employee id");
                employeen.EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name");
                employeen.EmpName = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                employeen.EmpSalary= Convert.ToInt32(Console.ReadLine());   

                employees.Add(employeen);
                goto again;
            }
            else
            {
                Console.WriteLine("total no.of employees =" + employees.Count);
            }
            Console.WriteLine("total no.of employees ="+employees.Count);

            foreach (Employee c in employees)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", c.EmpID, c.EmpName, c.EmpSalary);
            }
        }
    }
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
}