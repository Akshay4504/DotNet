using BykeStoreDBFirst.Services;
using BykeStoresDBFirst.Models;

using System;

class Program

{

    static void Main()

    {

        BykeStoreDAL dal = new BykeStoreDAL();

        // ------------------ INSERT CUSTOMER ------------------

        Customer newCustomer = new Customer();

        Console.Write("Enter First Name: ");

        newCustomer.FirstName = Console.ReadLine()!;

        Console.Write("Enter Last Name: ");

        newCustomer.LastName = Console.ReadLine()!;

        dal.AddCustomer(newCustomer);

        Console.WriteLine("Customer added successfully!\n");

        // ------------------ DISPLAY ALL CUSTOMERS ------------------

        Console.WriteLine("List of Customers:");

        dal.DisplayCustomers();

        Console.WriteLine();

        // ------------------ UPDATE CUSTOMER ------------------

        Console.Write("Enter Customer ID to update: ");

        if (int.TryParse(Console.ReadLine(), out int updateId))

        {

            Customer existingCustomer = dal.GetCustomerById(updateId);

            if (existingCustomer != null)

            {

                Console.Write("Enter new First Name: ");

                existingCustomer.FirstName = Console.ReadLine()!;

                Console.Write("Enter new Last Name: ");

                existingCustomer.LastName = Console.ReadLine()!;

                dal.UpdateCustomer(existingCustomer);

                Console.WriteLine("Customer updated successfully!\n");

            }

            else

            {

                Console.WriteLine("Customer not found!\n");

            }

        }

        Console.Write("Enter Customer ID to delete: ");

        if (int.TryParse(Console.ReadLine(), out int deleteId))

        {

            Customer deleteCustomer = dal.GetCustomerById(deleteId);

            if (deleteCustomer != null)

            {

                dal.DeleteStudentId(deleteCustomer);

                Console.WriteLine("Customer deleted successfully!\n");

            }

            else

            {

                Console.WriteLine("Customer not found!\n");

            }

        }

        Console.WriteLine("Final list of customers:");

        dal.DisplayCustomers();

    }

}