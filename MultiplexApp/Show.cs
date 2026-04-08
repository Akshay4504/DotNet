using System;




public class Show

{

    private static int counter = 1000;

    public int ShowID { get; }

    public int MovieID { get; set; }

    public int TheatreID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal PlatinumSeatRate { get; set; }

    public decimal GoldSeatRate { get; set; }

    public decimal SilverSeatRate { get; set; }




    public Show(int movieId, int theatreId, DateTime start, DateTime end, decimal p, decimal g, decimal s)

    {

        ShowID = counter++;

        MovieID = movieId;

        TheatreID = theatreId;

        StartDate = start;

        EndDate = end;

        PlatinumSeatRate = p;

        GoldSeatRate = g;

        SilverSeatRate = s;

    }




    public void DisplayShowDetails()

    {

        Console.WriteLine($"{ShowID} {MovieID} {TheatreID} {StartDate} {EndDate}");

    }

}