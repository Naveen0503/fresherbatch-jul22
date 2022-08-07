using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    class BankAccount
    {
        public double AccountNumber;
        public string Name;
        public double bankbalance;
        public void data()
        {
            Console.WriteLine("enter account number");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("bank balance");
            bankbalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Account number={0}\nname={1}\nbank balance={2}",AccountNumber,Name,bankbalance);
            string filepath = @"D:\train\c# .net Assignments\bank details.txt";
           StreamWriter sw=File.CreateText(filepath);
            sw.WriteLine("account number="+AccountNumber);
            sw.WriteLine("name="+Name);
            sw.WriteLine("bankbalance="+bankbalance);
            sw.Close();

            Console.WriteLine("---data reading---");
            using (StreamReader sr = File.OpenText(filepath))
            
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }



        }
        class filedata
        {
            public static void Main()
            {
                try
                {
                    BankAccount b = new BankAccount();
                    b.data();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                }
            }
        }
    }
}
