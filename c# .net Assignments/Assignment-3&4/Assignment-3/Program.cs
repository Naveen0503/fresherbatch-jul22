using System;
using LitwareLib;

namespace assignment3
{
    class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private new double GrossSalary;
        private new double PF;
        private new double TDS;
        private new double NetSalary;

        public double setPa()
        {
            double pa;
            pa = (8 * slry() )/ 100;
            PetrolAllowance = pa;
            return PetrolAllowance;
        }
        public void getpa()
        {
            Console.WriteLine("petrol allowance ="+PetrolAllowance);
        }
        public double setfa()
        {
            double fa;
            fa = (13 * slry()) / 100;
            PetrolAllowance = fa;
            return FoodAllowance;
        }
        public void getfa()
        {
            Console.WriteLine("food allowance = "+FoodAllowance);
        }
        public double setoa()
        {
            double OA;
            OA=(3*slry())/100;
            OtherAllowance = OA;
            return OtherAllowance;
        }
        public void getoa()
        {
            Console.WriteLine("Other Allowance ="+OtherAllowance);
        }
        public new void  setgs()
        {
            double grosssalary;
             grosssalary = PetrolAllowance + FoodAllowance + OtherAllowance+setda()+setta()+sethra()+slry();
            this.GrossSalary = grosssalary;
        }
        public new void  calculatesalary()
        {
            double pf, tds, ns;
            
            pf = (10 * GrossSalary) / 100 ;
            this.PF = pf;
            

            tds = (18 * GrossSalary) / 100;
            this.TDS = tds; 
           

            ns = GrossSalary - (pf + tds);
            this.NetSalary = ns;
        }
    }
    class MarketingExecutive : Manager
    {
        private double kilometertravel;
        private double TourAllowance;
        private double TelephoneAllowance = 1000;
        private new double GrossSalary;
        private new  double PF;
        private new double TDS;
        private new  double NetSalary;

        public void setkm()
        {
            Console.WriteLine("enter no.of kilometers");
            double km=Convert.ToDouble(Console.ReadLine());
            this.kilometertravel = km;
        }
        public void getkm()
        {
            Console.WriteLine("total no.of kilometers travelled"+kilometertravel);
        }
        public void settour()
        {
            double t;
            t = 5 * kilometertravel;
            TourAllowance = t;
        }
        public void gett()
        {
            Console.WriteLine("tour allowane="+TourAllowance);
        }
        public new void setgs()
        {
            double grosssalary;
            grosssalary = setPa() + setoa()+ setfa() + setda() + setta() + sethra() + slry()+TourAllowance+TelephoneAllowance;
            this.GrossSalary = grosssalary;
        }
        public new void calculatesalary()
        {
            double pf, tds, ns;

            pf = (10 * GrossSalary) / 100;
            this.PF = pf;


            tds = (18 * GrossSalary) / 100;
            this.TDS = tds;


            ns = GrossSalary - (pf + tds);
            this.NetSalary = ns;
        }
    }
    interface Empdetails
    {
        void print();
    }
    class printdetails : Empdetails
    {
        public void print()
        {
            Console.WriteLine("enter no.of employee");
            int size = Convert.ToInt32(Console.ReadLine());
            Employee[] obj1 = new Employee[size];
            Employee obj = new Employee();

            Console.WriteLine("----------Accepting Employee Details----------");

            for (int i = 0; i < obj1.Length; i++)
            {
                Console.WriteLine("Enter Employee Number:");
                int no = int.Parse(Console.ReadLine());
                obj.setempno(no);

                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                obj.setempname(name);

                Console.WriteLine("Enter Employee Salary:");
                double salary = double.Parse(Console.ReadLine());
                obj.setEmpSalary(salary);
                obj.sethra();
                obj.setta();
                obj.setda();
                obj.setgs();
                obj.calculatesalary();
            }
            Console.WriteLine("----------displaying Employee Details----------");
            for (int i = 0; i < obj1.Length; i++)
            {
                obj.getEmpNo();
                obj.getEmpName();
                obj.getEmpSalary();
                obj.getgs();
            }
        }
    }
    class program
    {
        public static void Main()
        {
            Empdetails p = new printdetails();
            Employee m = new Manager();
            m.setgs();

            try
            {
                p.print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name); 
            }
        }
    }
}