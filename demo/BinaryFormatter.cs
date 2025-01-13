using System.Runtime.Serialization.Formatters.Binary;

namespace DotNet9BreakingChangesDemo;

public class Attendee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> PizzaSlices { get; set; } = [];
}

public class BinaryFormatterThrows
{
    static public void Example()
    {
        Console.WriteLine("BinaryFormatter Throws example:\n");

        List<Attendee> attendees = new List<Attendee>();
        attendees.Add(new Attendee { Name = "John", Age = 30, PizzaSlices = ["Pepperoni", "Margherita"] });
        attendees.Add(new Attendee { Name = "Jane", Age = 25, PizzaSlices = ["Hawaiian", "Margherita"] });

        // Throws Exception
        /*var formatter = new BinaryFormatter();
        using var stream = new MemoryStream();
        formatter.Serialize(stream, attendees);

        stream.Position = 0;
        attendees = (List<Attendee>)formatter.Deserialize(stream);*/
    }
}
