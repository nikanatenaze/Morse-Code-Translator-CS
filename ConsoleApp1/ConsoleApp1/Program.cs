// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Data;

Console.WriteLine("Hello, World!");


Morse morse = new Morse();
Console.WriteLine(morse.ToHumanic(".- ..."));
Console.WriteLine(morse.ToMorse("as"));