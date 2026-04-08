using System;

using System.Linq;




class Program

{

    static MovieDataStore db = new MovieDataStore();

    static LoginDetails currentUser = null;




    static void Main(string[] args)

    {

        while (true)

        {

            Console.WriteLine("\n----- Multiplex Management System -----");

            Console.WriteLine("1. Create Login");

            Console.WriteLine("2. Sign In");

            Console.WriteLine("3. Exit");




            int choice = int.Parse(Console.ReadLine());




            switch (choice)

            {

                case 1:

                    CreateLogin();

                    break;

                case 2:

                    SignIn();

                    break;

                case 3:

                    return;

            }

        }

    }




    static void CreateLogin()

    {

        Console.WriteLine("1. Customer\n2. Admin");

        int type = int.Parse(Console.ReadLine());




        if (type == 1)

        {

            Console.Write("Name: ");

            string name = Console.ReadLine();

            Console.Write("City: ");

            string city = Console.ReadLine();




            LoginDetails login = new LoginDetails("Customer");

            db.AddLogin(login);




            Customer customer = new Customer(int.Parse(login.LoginID), name, city);

            db.AddCustomer(customer);




            Console.WriteLine($"Login Created: {login.LoginID}");

        }

        else

        {

            LoginDetails login = new LoginDetails("Admin");

            db.AddLogin(login);

            Console.WriteLine("Admin Login Created: MOVIEADMIN");

        }

    }




    static void SignIn()

    {

        Console.Write("Login ID: ");

        string id = Console.ReadLine();




        Console.Write("Password: ");

        string pass = Console.ReadLine();




        var user = db.Logins.FirstOrDefault(x => x.LoginID == id && x.Password == pass);




        if (user == null)

        {

            Console.WriteLine("Invalid Credentials");

            return;

        }




        currentUser = user;




        if (user.LoginType == "Admin")

            AdminMenu();

        else

            CustomerMenu();

    }




    static void AdminMenu()

    {

        while (true)

        {

            Console.WriteLine("\n--- ADMIN MENU ---");

            Console.WriteLine("1. Add Theatre");

            Console.WriteLine("2. Add Movie");

            Console.WriteLine("3. Add Show");

            Console.WriteLine("4. View Theatres");

            Console.WriteLine("5. View Movies");

            Console.WriteLine("6. View Shows");

            Console.WriteLine("7. Logout");




            int choice = int.Parse(Console.ReadLine());




            switch (choice)

            {

                case 1:

                    AddTheatre();

                    break;

                case 2:

                    AddMovie();

                    break;

                case 3:

                    AddShow();

                    break;

                case 4:

                    db.Theatres.ForEach(t => t.DisplayTheatreDetails());

                    break;

                case 5:

                    db.Movies.ForEach(m => m.DisplayMovieDetails());

                    break;

                case 6:

                    db.Shows.ForEach(s => s.DisplayShowDetails());

                    break;

                case 7:

                    return;

            }

        }

    }




    static void CustomerMenu()

    {

        while (true)

        {

            Console.WriteLine("\n--- CUSTOMER MENU ---");

            Console.WriteLine("1. View Shows");

            Console.WriteLine("2. Book Ticket");

            Console.WriteLine("3. View My Bookings");

            Console.WriteLine("4. Logout");




            int choice = int.Parse(Console.ReadLine());




            switch (choice)

            {

                case 1:

                    db.Shows.ForEach(s => s.DisplayShowDetails());

                    break;

                case 2:

                    BookTicket();

                    break;

                case 3:

                    db.Bookings

                        .Where(b => b.CustomerName == currentUser.LoginID)

                        .ToList()

                        .ForEach(b => Console.WriteLine($"{b.BookingID} {b.ShowID} {b.Amount}"));

                    break;

                case 4:

                    return;

            }

        }

    }




    static void AddTheatre()

    {

        Console.Write("Theatre Name: ");

        string name = Console.ReadLine();




        if (db.Theatres.Any(t => t.TheatreName == name))

        {

            Console.WriteLine("Duplicate Theatre Name");

            return;

        }




        Console.Write("Seats: ");

        int seats = int.Parse(Console.ReadLine());




        db.AddTheatre(new Theatre(seats, name));

    }




    static void AddMovie()

    {

        try

        {

            Console.Write("Movie Name: ");

            string name = Console.ReadLine();




            if (db.Movies.Any(m => m.MovieName == name))

            {

                Console.WriteLine("Duplicate Movie Name");

                return;

            }




            Console.Write("Director: ");

            string director = Console.ReadLine();




            Console.Write("Producer: ");

            string producer = Console.ReadLine();




            Console.Write("Story: ");

            string story = Console.ReadLine();




            Console.Write("Genre: ");

            string genre = Console.ReadLine();




            Console.Write("Duration: ");

            double duration = double.Parse(Console.ReadLine());




            db.AddMovie(new Movie(name, director, producer, story, genre, duration));

        }

        catch (Exception ex)

        {

            Console.WriteLine(ex.Message);

        }

    }




    static void AddShow()

    {

        Console.WriteLine("Available Theatres:");

        db.Theatres.ForEach(t => t.DisplayTheatreDetails());




        Console.Write("Enter TheatreID: ");

        int theatreId = int.Parse(Console.ReadLine());




        Console.WriteLine("Available Movies:");

        db.Movies.ForEach(m => m.DisplayMovieDetails());




        Console.Write("Enter MovieID: ");

        int movieId = int.Parse(Console.ReadLine());




        if (db.Shows.Count(s => s.MovieID == movieId && s.TheatreID == theatreId) >= 4)

        {

            Console.WriteLine("Max 4 shows allowed");

            return;

        }




        Console.Write("Start Date: ");

        DateTime start = DateTime.Parse(Console.ReadLine());




        Console.Write("End Date: ");

        DateTime end = DateTime.Parse(Console.ReadLine());




        Console.Write("Platinum Rate: ");

        decimal p = decimal.Parse(Console.ReadLine());




        Console.Write("Gold Rate: ");

        decimal g = decimal.Parse(Console.ReadLine());




        Console.Write("Silver Rate: ");

        decimal s = decimal.Parse(Console.ReadLine());




        db.AddShow(new Show(movieId, theatreId, start, end, p, g, s));

    }




    static void BookTicket()

    {

        Console.WriteLine("Shows:");

        db.Shows.ForEach(s => s.DisplayShowDetails());




        Console.Write("Enter ShowID: ");

        int showId = int.Parse(Console.ReadLine());




        Console.Write("Seats (1-4): ");

        int seats = int.Parse(Console.ReadLine());




        Console.Write("Seat Type (Platinum/Gold/Silver): ");

        string type = Console.ReadLine();




        var show = db.Shows.FirstOrDefault(s => s.ShowID == showId);




        decimal rate = 0;




        if (type == "Platinum") rate = show.PlatinumSeatRate;

        else if (type == "Gold") rate = show.GoldSeatRate;

        else rate = show.SilverSeatRate;




        Booking booking = new Booking(showId, currentUser.LoginID, seats, type, "mail@test.com", rate);

        db.AddBooking(booking);




        Console.WriteLine($"Booked! Amount: {booking.Amount}");

    }

}