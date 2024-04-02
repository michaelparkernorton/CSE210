using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create three addresses with dummy data
        Address address1 = new ("123 Main St", "New York", "NY", "US");
        Address address2 = new ("456 Elm St", "Los Angeles", "CA", "US");
        Address address3 = new ("789 Oak St", "Chicago", "IL", "US");

        // Create instances of each type of event using constructor shorthand and fill them with dummy data
        Lecture lecture = new ("Tech Talk: AI and Future Technologies", "Join us for an exciting discussion on the latest advancements in AI.", new DateOnly(2024, 4, 2), new TimeOnly(9, 0), address1, "Dr. John Smith", 100);
        OutdoorGathering outdoorGathering = new ("Annual Picnic", "Join us for our annual company picnic!", new DateOnly(2024, 4, 3), new TimeOnly(12, 0), address2, "Sunny");
        Reception reception = new ("Networking Mixer", "Come network with professionals in your industry.", new DateOnly(2024, 4, 4), new TimeOnly(18, 0), address3, "example@example.com");

        // Call FullDetails, StandardDetails, and ShortDescription for each event
        Console.WriteLine("Lecture Full Details:");
        lecture.FullDetails();
        Console.WriteLine();

        Console.WriteLine("Lecture Standard Details:");
        lecture.StandardDetails();
        Console.WriteLine();

        Console.WriteLine("Lecture Short Description:");
        lecture.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Full Details:");
        outdoorGathering.FullDetails();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Standard Details:");
        outdoorGathering.StandardDetails();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Short Description:");
        outdoorGathering.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Reception Full Details:");
        reception.FullDetails();
        Console.WriteLine();

        Console.WriteLine("Reception Standard Details:");
        reception.StandardDetails();
        Console.WriteLine();

        Console.WriteLine("Reception Short Description:");
        reception.ShortDescription();
        Console.WriteLine();
    }
}
