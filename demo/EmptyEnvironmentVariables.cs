namespace DotNet9BreakingChangesDemo;

public class EmptyEnvironmentVariables
{
    static public void Example()
    {
        Console.WriteLine("Empty Environment Variables example:\n");

        string myVar1 = String.Empty, myVar2 = null;

        Console.WriteLine("Set variables:\n");

        Console.WriteLine("Set MYVAR1 to String.Empty");
        Environment.SetEnvironmentVariable("MYVAR1", myVar1);

        Console.WriteLine("Set MYVAR2 to null\n");        
        Environment.SetEnvironmentVariable("MYVAR2", myVar2);

        Console.WriteLine("Check variables:\n");

        string check1 = Environment.GetEnvironmentVariable("MYVAR1");

        string check2 = Environment.GetEnvironmentVariable("MYVAR2");

        Console.WriteLine("MYVAR1: {0}", check1 == String.Empty? "\"\"" : "null / undefined");
        Console.WriteLine("MYVAR2: {0}\n", check2 != null? check2 : "null / undefined");

        Console.WriteLine("MYVAR1 is Empty String: {0}\n", myVar1 == check1);
    }
}
