using System;

// Address class to encapsulate address details
class Address
{
    private string street;
    private string city;
    private string state;
    private string zipCode;

    // Constructor for Address class
    public Address(string street, string city, string state, string zipCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }
}

// Base Event class
class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    // Constructor for Event class
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Method to generate standard details message
    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

    // Method to generate full details message
    public virtual string GetFullDetails()
    {
        return GetStandardDetails(); // Base class full details only contain standard details
    }

    // Method to generate short description message
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

// Lecture class, derived from Event
class Lecture : Event
{
    private string speaker;
    private int capacity;

    // Constructor for Lecture class
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Method to generate full details message for Lecture
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

// Reception class, derived from Event
class Reception : Event
{
    private string rsvpEmail;

    // Constructor for Reception class
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Method to generate full details message for Reception
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

// OutdoorGathering class, derived from Event
class OutdoorGathering : Event
{
    private string weatherForecast;

    // Constructor for OutdoorGathering class
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    // Method to generate full details message for OutdoorGathering
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an Address
        Address address = new Address("123 Main St", "Idaho", "ID", "83440");

        // Creating instances of different types of events
        Event event1 = new Lecture("Tech Talk", "Exploring the latest technology trends", DateTime.Parse("2023-12-15"), "10:00 AM", address, "Jack Jones", 50);
        Event event2 = new Reception("Networking", "Networking event for college graduates", DateTime.Parse("2023-12-20"), "6:00 PM", address, "myemail@email.com");
        Event event3 = new OutdoorGathering("Sports Day", "Enjoy the sunny weather with games and food", DateTime.Parse("2023-12-25"), "12:00 PM", address, "Sunny with a high of 80°F");

        // Generating and displaying messages for each event
        Console.WriteLine("Event 1 - Standard Details:\n" + event1.GetStandardDetails() + "\n");
        Console.WriteLine("Event 1 - Full Details:\n" + event1.GetFullDetails() + "\n");
        Console.WriteLine("Event 1 - Short Description:\n" + event1.GetShortDescription() + "\n");

        Console.WriteLine("Event 2 - Standard Details:\n" + event2.GetStandardDetails() + "\n");
        Console.WriteLine("Event 2 - Full Details:\n" + event2.GetFullDetails() + "\n");
        Console.WriteLine("Event 2 - Short Description:\n" + event2.GetShortDescription() + "\n");

        Console.WriteLine("Event 3 - Standard Details:\n" + event3.GetStandardDetails() + "\n");
        Console.WriteLine("Event 3 - Full Details:\n" + event3.GetFullDetails() + "\n");
        Console.WriteLine("Event 3 - Short Description:\n" + event3.GetShortDescription() + "\n");

        Console.ReadLine();
    }
}
