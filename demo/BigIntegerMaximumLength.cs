using System.Numerics;

namespace DotNet9BreakingChangesDemo;

public class BigIntegerMaximumLength
{
    static public void Example()
    {
        Console.WriteLine("BigInteger Maximum Length example:\n");

        try
        {
            BigInteger bigInt = new BigInteger(-1) << int.MaxValue;
            Console.WriteLine("BigInteger assignment accepted.\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }
}