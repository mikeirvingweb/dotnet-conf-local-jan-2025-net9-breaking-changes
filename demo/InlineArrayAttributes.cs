using System.Globalization;
using System.Runtime.CompilerServices;

namespace DotNet9BreakingChangesDemo;

public class InlineArrayAttributes
{
    [InlineArray(12)]
    struct MonthNames
    {
        public string _value;
    }

    static public void Example()
    {
        Console.WriteLine("Inline Array Attributes example:\n");

        var myMonthNameSet = new MonthNames();
        var myMonthAdditionalNameSet = new MonthNames();

        for (int i = 0; i < 12; i++)
        {
            myMonthNameSet[i] = new DateTime(DateTime.Now.Year, (i + 1), 1).ToString("MMM", CultureInfo.InvariantCulture);
            myMonthAdditionalNameSet[i] = new DateTime(DateTime.Now.Year, (i + 1), 1).ToString("MMM", CultureInfo.InvariantCulture);
        }

        // Output to Console.
        Console.WriteLine("Contents of myMonthNameSet:");
        foreach (var monthName in myMonthNameSet)
        {
            Console.Write(monthName + " ");
        }
        Console.WriteLine(Environment.NewLine);

        // Output to Console.
        Console.WriteLine("Contents of myMonthAdditionalNameSet:");
        foreach (var monthName in myMonthAdditionalNameSet)
        {
            Console.Write(monthName + " ");
        }
        Console.WriteLine(Environment.NewLine);

        try
        {
            Console.WriteLine("myMonthNameSet equals myMonthAdditionalNameSet: {0}\n", myMonthNameSet.Equals(myMonthAdditionalNameSet));
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}\n", e.Message);
        }

        try
        {
            Console.WriteLine("Hash Code for myMonthNameSet: {0}\n", myMonthNameSet.GetHashCode());
            Console.WriteLine("Hash Code for myMonthAdditionalNameSet: {0}\n", myMonthAdditionalNameSet.GetHashCode());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}\n", e.Message);
        }
    }
}
