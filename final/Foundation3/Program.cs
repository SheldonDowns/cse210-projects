class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "New York", "NY", "10001");
        Event lecture = new Lecture("Tech Talk", "A lecture on the future of technology", DateTime.Now.AddDays(10), "10:00 AM", lectureAddress, "Dr. John Doe", 100);

        Address receptionAddress = new Address("456 Park Ave", "Los Angeles", "CA", "90001");
        Event reception = new Reception("Business Mixer", "A networking event for business professionals", DateTime.Now.AddDays(20), "6:00 PM", receptionAddress, "rsvp@businessmixer.com");

        Address outdoorAddress = new Address("789 Ocean Blvd", "Miami", "FL", "33101");
        Event outdoor = new OutdoorGathering("Beach Party", "An outdoor gathering at the beach", DateTime.Now.AddDays(30), "2:00 PM", outdoorAddress, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
