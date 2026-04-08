using System;




public class LoginDetails

{

    private static int counter = 1000;

    public string LoginID { get; }

    public string Password { get; set; }

    public string LoginType { get; set; }




    public LoginDetails(string type)

    {

        if (type == "Admin")

            LoginID = "MOVIEADMIN";

        else

            LoginID = (counter++).ToString();




        Password = LoginID;

        LoginType = type;

    }




    public void DisplayLoginDetails()

    {

        Console.WriteLine($"{LoginID} {Password} {LoginType}");

    }

}