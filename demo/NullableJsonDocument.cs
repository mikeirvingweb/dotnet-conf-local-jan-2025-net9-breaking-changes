using System.Text.Json;

namespace DotNet9BreakingChangesDemo;

public class NullableJsonDocument
{
    static public void Example()
    {
        Console.WriteLine("Nullable JsonDocument example:\n");

        string jsonString = "";

        using (StreamReader sr = File.OpenText("data/NullableJsonDocument.json"))
        {
            jsonString = sr.ReadToEnd();
        }

        Console.WriteLine("JSON: {0}\n", jsonString);

        bool isNull = JsonSerializer.Deserialize<JsonDocument>(jsonString) is null;

        bool isJsonValueKindNull =
            JsonSerializer.Deserialize<JsonDocument>(jsonString) is { RootElement.ValueKind: JsonValueKind.Null };

        Console.WriteLine("isNull: {0} - isJsonValueKindNull: {1}", isNull, isJsonValueKindNull);
    }
}