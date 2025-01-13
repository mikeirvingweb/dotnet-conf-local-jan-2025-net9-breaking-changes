namespace DotNet9BreakingChangesDemo;

public class ArrayOfTypeVoid
{
    static public void Example()
    {
        Console.WriteLine("Array Of Type Void example:\n");

        try
        {
            Console.WriteLine("Attempt to Create an Array of Type Void:");
            var ourArray = typeof(void).MakeArrayType();
            Console.WriteLine("Success!\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}\n", e.Message);
        }
    }
}
