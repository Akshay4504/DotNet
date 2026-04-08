using System;

public class Movie

{

    private static int counter = 1000;

    public int MovieID { get; }

    public string MovieName { get; set; }

    public string DirectorName { get; set; }

    public string ProducerName { get; set; }

    public string Story { get; set; }

    public string Genre { get; set; }

    public double Duration { get; set; }




    public Movie(string name, string director, string producer, string story, string genre, double duration)

    {

        if (duration <= 0)

            throw new InvalidDurationException("The mentioned duration is invalid. Pls ensure to enter a valid duration");




        MovieID = counter++;

        MovieName = name;

        DirectorName = director;

        ProducerName = producer;

        Story = story;

        Genre = genre;

        Duration = duration;

    }




    public void DisplayMovieDetails()

    {

        Console.WriteLine($"{MovieID} {MovieName} {DirectorName} {ProducerName} {Genre} {Duration}");

    }

}