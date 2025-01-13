using DotNet9BreakingChangesDemo;

Console.WriteLine("Mike Irving - .NET 9 Breaking Changes demo app.\n");

Console.WriteLine("Running on .NET {0}\n", Environment.Version);


/* Demos - turn on or off to showcase - run as .NET 8 vs .NET 9 */

/* Core .NET libraries */
//BigIntegerMaximumLength.Example();
//EmptyEnvironmentVariables.Example();
//InlineArrayAttributes.Example();
//ArrayOfTypeVoid.Example();

/* Serialization */
//BinaryFormatterThrows.Example();
//NullableJsonDocument.Example();

Console.ReadLine();