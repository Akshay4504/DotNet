using System;




public class Customer

{

    public int CustomerID { get; }

    public string CustomerName { get; set; }

    public string City { get; set; }




    public Customer(int id, string name, string city)

    {

        CustomerID = id;

        CustomerName = name;

        City = city;

    }




    public void DisplayCustomerDetails()

    {
        Console.WriteLine($"{CustomerID} {CustomerName} {City}");

    }

}
