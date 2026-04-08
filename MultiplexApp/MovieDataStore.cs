using System;

using System.Collections.Generic;




public class MovieDataStore

{

    public List<Movie> Movies = new List<Movie>();

    public List<Theatre> Theatres = new List<Theatre>();

    public List<Customer> Customers = new List<Customer>();

    public List<LoginDetails> Logins = new List<LoginDetails>();

    public List<Show> Shows = new List<Show>();

    public List<Booking> Bookings = new List<Booking>();




    public void AddMovie(Movie obj)

    {

        if (obj == null)

            throw new NullReferenceException("Movie details cannot be null");

        Movies.Add(obj);

    }




    public void AddTheatre(Theatre obj)

    {

        if (obj == null)

            throw new NullReferenceException("Theatre details cannot be null");

        Theatres.Add(obj);

    }




    public void AddCustomer(Customer obj)

    {

        if (obj == null)

            throw new NullReferenceException("Customer details cannot be null");

        Customers.Add(obj);

    }




    public void AddLogin(LoginDetails obj)

    {

        Logins.Add(obj);

    }




    public void AddShow(Show obj)

    {

        Shows.Add(obj);

    }




    public void AddBooking(Booking obj)

    {

        Bookings.Add(obj);

    }

}