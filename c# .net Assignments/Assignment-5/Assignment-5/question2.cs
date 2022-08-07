using System;
using System.Collections;
using LitwareLib;

namespace q2
{
    public class EmployeeManagementApplication
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.GetEmployeeData(1, "Arfin", 20000);
            emp2.GetEmployeeData(2, "Aariz", 18000);
            emp3.GetEmployeeData(3, "Zain", 15000);

            ArrayList mylist = new ArrayList();
            mylist.Add(emp1); mylist.Add(emp2); mylist.Add(emp3);
            Console.WriteLine("Displaying employee details from Employee ArrayList - \n");
            foreach (Employee employee in mylist)
            {
                Console.WriteLine($"ID: {employee._Empno} \t Name: {employee._EmpName} \t Salary: {employee._Salary}");
            }
        }
    }
}