using ConsoleApp1.Data;
using Morse_Translator.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Translator.Menu
{
    internal class Menu
    {
        public Morse Morse { get; set; }

        public Menu()
        {
            Morse = new Morse();
        }

        public void Inject()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Custom.Natenadze();
            while (true) {
                Custom.Line();
                try
                {
                    Console.WriteLine(" Choose option: ");
                    Say.Green("1", "Translate to Morse");
                    Say.Green("2", "Translate from Morse");
                    Say.Green("3", "Instructions");
                    Say.Red("ANY", "Exit");
                    Console.Write(" Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.Write(" Enter text to translate: ");
                        string input = Console.ReadLine();
                        var result = Morse.ToMorse(input);
                        if (result is not bool && result is string)
                        {
                            Custom.Line();
                            Console.WriteLine($" Your text: {input}");
                            Say.Blue("Result:", result.ToString(), true);
                        }
                        else
                        {
                            Say.Red("Error", "Can't translate that text!");
                        }
                    }
                    else if (option == 2)
                    {
                        Console.Write(" Enter text to translate: ");
                        string input = Console.ReadLine();
                        var result = Morse.ToHumanic(input);
                        if (result is not bool && result is string)
                        {
                            Custom.Line();
                            Console.WriteLine($" Your text: {input}");
                            Say.Blue("Result:", result.ToString(), true);
                        }
                        else
                        {
                            Say.Red("Error", "Can't translate that text!");
                        }
                    }
                    else if (option == 3) { 
                        Custom.Line();
                        Say.Red( "Instructions:", "", true);
                        Console.WriteLine(" This translator can translate A-Z and 0-9");
                        Console.WriteLine(" All another symbols are unknown for system");
                        Console.WriteLine(" You can find more info on Github: ");
                        Say.Blue("https://github.com/nikanatenaze/Morse-Code-Translator", "", true);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Say.Red("Error", "We approched some error while working.");
                    Console.WriteLine($" Message: {ex.Message}");
                }
            }
        }
    }
}
