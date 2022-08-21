using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.MobileControls;
//using Customer_Management_System;

namespace Customer_Management_System
{
    public class CustomerDB
    {

        public bool Addcustomer(Customer c)
        {
            string cs = "data source=.;database=ASP.NET Assignments;integrated security=SSPI";

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insertcustomerdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", c.CustomerId);
                cmd.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                cmd.Parameters.AddWithValue("@City", c.City);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Phone", Convert.ToDecimal(c.PhoneNumber));
                cmd.Parameters.AddWithValue("@Pincode", c.Pincode);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                    return true;
                else
                    return false;
            }
        }

        public List<Customer> GetCustomers()
        {
            string cs = ConfigurationManager.ConnectionStrings["CustomerDB"].ConnectionString;
            List<Customer> Customerlist = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getcustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Customerlist.Add(new Customer
                    {
                        CustomerId = Convert.ToInt32(dr["CustomerId"]),
                        CustomerName = Convert.ToString(dr["CustomerName"]),
                        City = Convert.ToString(dr["City"]),
                        Age = Convert.ToInt32(dr["Age"]),
                        PhoneNumber = Convert.ToDouble(dr["Phone"]),
                        Pincode = Convert.ToInt32(dr["Pincode"]),
                    });
                }
                return Customerlist;
            }
            
        }
        public bool Modifycustomer(Customer c)
        {
            string cs = "data source=.;database=ASP.NET Assignments;integrated security=SSPI";

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insertcustomerdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", c.CustomerId);
                cmd.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                cmd.Parameters.AddWithValue("@City", c.City);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Phone", Convert.ToDecimal(c.PhoneNumber));
                cmd.Parameters.AddWithValue("@Pincode", c.Pincode);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                    return true;
                else
                    return false;
            }
        }
        public bool Removecustomer(int id)
        {
            string cs = "data source=.;database=ASP.NET Assignments;integrated security=SSPI";

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("deletecustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", id);
               

                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                    return true;
                else
                    return false;
            }
        }
     

        
    }
    
}
