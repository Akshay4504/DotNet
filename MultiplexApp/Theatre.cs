using System;




public class Theatre

{

    private static int counter = 1000;

    public int TheatreID { get; }

    public int NumberOfSeats { get; set; }

    public string TheatreName { get; set; }




    public Theatre(int seats, string name)

    {

        TheatreID = counter++;

        NumberOfSeats = seats;

        TheatreName = name;

    }




    public void DisplayTheatreDetails()

    {

        Console.WriteLine($"{TheatreID} {TheatreName} {NumberOfSeats}");

    }

}
