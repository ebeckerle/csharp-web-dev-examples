// See https://aka.ms/new-console-template for more information
using TemperatureExample;

Console.WriteLine("Hello, World!");
// If the static field is public, we can do this
Console.WriteLine("Absolute zero in F is: " + Temperature.absoluteZeroFahrenheit);

// If we have an object named "temp" of type Temperature, we cannot do this.
//Console.WriteLine("Absolute zero in F is: " + temp.absoluteZeroFahrenheit);