using BykeStoresConsoleApp.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BykeStoresConsoleApp.Services
{
    internal class BykeStoreDAL
    {
        public SqlConnection _Con;
        public SqlCommand _Command;
        public SqlDataReader rd;
        public string _ConStr;
        public Staff staff;

        public BykeStoreDAL(string str)
        {
            _Con = null;
            _Command = null;
            rd = null;
            _ConStr = str;
            staff = null;
        }
        public void displayStaff()
        {
            List<Staff> staffs = new List<Staff>();
            _Con = new SqlConnection(_ConStr);
            _Command = new SqlCommand("Select * from Sales.staffs", _Con);

            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                rd = _Command.ExecuteReader();
                while (rd.Read())
                {
                    Console.Write(rd["staff_id"] + "," + rd["first_name"] + "," + rd["last_name"] + "," + rd["email"] + "\n");
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Something Went Wrong-{sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something Went Wrong-{ex.Message}");
            }
            finally
            {
                if (_Con.State == System.Data.ConnectionState.Open)
                    _Con.Close();
            }
        }
        public void displayCustomersAndStaff()
        {
            List<Staff> staffs = new List<Staff>();
            _Con = new SqlConnection(_ConStr);
            _Command = new SqlCommand("Select * from Sales.staffs;Select * from Sales.Customers where city='San Jose'", _Con);

            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                rd = _Command.ExecuteReader();
                while (rd.Read())
                {
                    Console.Write(rd["staff_id"] + "," + rd["first_name"] + "," + rd["last_name"] + "," + rd["email"] + "\n");
                }
                if (rd.NextResult())
                {
                    while (rd.Read())
                    {
                        Console.Write(rd["customer_id"] + " , " + rd["first_name"] + " , " + rd["last_name"]);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Something Went Wrong-{sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something Went Wrong-{ex.Message}");
            }
            finally
            {
                if (_Con.State == System.Data.ConnectionState.Open)
                    _Con.Close();
            }
        }
        public void displayCustomerCount(int customer_id)
        {
            List<Staff> staffs = new List<Staff>();
            _Con = new SqlConnection(_ConStr);
            _Command = new SqlCommand("Select phone from sales.Customers where customer_id=" + customer_id, _Con);

            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                string phone_no = _Command.ExecuteScalar().ToString();
                while (rd.Read())
                {
                    Console.Write(rd["staff_id"] + "," + rd["first_name"] + "," + rd["last_name"] + "," + rd["email"] + "\n");
                }
                if (rd.NextResult())
                {
                    while (rd.Read())
                    {
                        Console.Write(rd["customer_id"] + " , " + rd["first_name"] + " , " + rd["last_name"]);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Something Went Wrong-{sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something Went Wrong-{ex.Message}");
            }
            finally
            {
                if (_Con.State == System.Data.ConnectionState.Open)
                    _Con.Close();
            }
        }
        public int InsertCustomer()
        {
            _Con = new SqlConnection(_ConStr);
            Console.WriteLine("Enter First name: ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string last_name = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state name: ");
            string state = Console.ReadLine();

            int i = 0;
            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                string CmdStr = "Insert into " + "sales.customers(first_name,last_name,email,city,state) " +
                    "values(@fname,@lname,@email,@city,@state) ";
                using (_Command = new SqlCommand(CmdStr, _Con))
                {
                    _Command.CommandType = CommandType.Text;
                    _Command.Parameters.AddWithValue("@fname", first_name);
                    _Command.Parameters.AddWithValue("@lname", last_name);
                    _Command.Parameters.AddWithValue("@email", email);
                    _Command.Parameters.AddWithValue("@city", city);
                    _Command.Parameters.AddWithValue("@state", state);

                    i = _Command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return i;

        }
        public int UpdatePhone()
        {
            _Con = new SqlConnection(_ConStr);
            Console.WriteLine("Enter Phone-No: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter customer id: ");
            int cust_id = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                string CmdStr = "UpdatePhone";
                using (_Command = new SqlCommand(CmdStr, _Con))
                {
                    _Command.CommandType = CommandType.StoredProcedure;
                    _Command.Parameters.AddWithValue("@Phone", phone);
                    _Command.Parameters.AddWithValue("@CustId", cust_id);

                    i = _Command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return i;

        }
        public int DeleteCustomerById()
        {
            _Con = new SqlConnection(_ConStr);
 
            Console.WriteLine("Enter customer id to delete: ");
            int cust_id = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                string CmdStr = "Delete from sales.customers where customer_id=@custId";
                using (_Command = new SqlCommand(CmdStr, _Con))
                {
                    _Command.CommandType = CommandType.Text;

                    _Command.Parameters.AddWithValue("@CustId", cust_id);

                    i = _Command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return i;

        }

        public List<Staff> GetStaff()
        {
            List<Staff> staffs = new List<Staff>();
            _Con = new SqlConnection(_ConStr);
            _Command = new SqlCommand("Select * from Sales.staffs", _Con);

            try
            {
                if (_Con.State == System.Data.ConnectionState.Closed)
                    _Con.Open();
                rd = _Command.ExecuteReader();
                while (rd.Read())
                {
                    staff = new Staff();
                    staff.staff_id = Convert.ToInt32(rd["staff_Id"]);
                    staff.first_name = rd["first_name"].ToString();
                    staff.last_name = rd["last_name"].ToString();
                    staff.phone = rd["Phone"].ToString();
                    staffs.Add(staff);
                }
            }
            catch (SqlException sqlEx)
            {
                // Console.WriteLine($"Something Went Wrong-{sqlEx.Message}");
                throw sqlEx;
            }
            catch (Exception ex)
            {
                // Console.WriteLine($"Something Went Wrong-{ex.Message}");
                throw ex;
            }
            finally
            {
                if (_Con.State == System.Data.ConnectionState.Open)
                    _Con.Close();
            }
            return staffs;
        }
    }
}
