using System;

using System.Collections.Generic;




public class Booking

{

    private static int counter = 1000;

    public int BookingID { get; }

    public int ShowID { get; set; }

    public int NumberOfSeats { get; set; }

    public DateTime BookingDate { get; set; }

    public string CustomerName { get; set; }

    public string SeatType { get; set; }

    public string BookingStatus { get; set; }

    public string Email { get; set; }

    public decimal Amount { get; set; }

    public List<int> SeatNumbers { get; set; }




    public Booking(int showId, string name, int seats, string seatType, string email, decimal rate)

    {

        if (seats <= 0 || seats > 4)

            throw new Exception("Invalid number of seats");




        BookingID = counter++;

        ShowID = showId;

        CustomerName = name;

        NumberOfSeats = seats;

        SeatType = seatType;

        Email = email;

        BookingDate = DateTime.Now;

        BookingStatus = "Reserved";

        SeatNumbers = new List<int>();




        for (int i = 1; i <= seats; i++)

            SeatNumbers.Add(i);




        Amount = seats * rate;

    }

}
