// See https://aka.ms/new-console-template for more information
using BykeStoresConsoleApp.Models;
using BykeStoresConsoleApp.Services;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
string str = System.Configuration.ConfigurationManager.ConnectionStrings["BykeCon"].ConnectionString;

BykeStoreDAL bykeDAL = new BykeStoreDAL(str);
//bykeDAL.displayStaff();
//bykeDAL.displayCustomersAndStaff();
//bykeDAL.displayCustomerCount();

int result = bykeDAL.DeleteCustomerById();
/*if (result > 0)
    Console.WriteLine("Record Inserted Successfully");
else
{
    Console.WriteLine("Record Not inserted,please check");
}
if (result > 0)
    Console.WriteLine("Record Updated Successfully");
else
{
    Console.WriteLine("Record Not updated,please check");
}*/
if (result > 0)
    Console.WriteLine("Record deleted Successfully");
else
{
    Console.WriteLine("Record Not deleted,please check");
}

static void DisplayStaffs(BykeStoreDAL bd)
{
    List<Staff> AllStaffs = bd.GetStaff();
    try
    {
        if (AllStaffs != null)
        {
            foreach (Staff stf in AllStaffs)
            {
                Console.Write(stf.staff_id + "," + stf.first_name + "," + stf.last_name + "," + stf.email + "\n");
            }
        }
    }
    catch (Exception ex)
    {

    }

}
{

}
