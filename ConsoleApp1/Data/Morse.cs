using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class Morse
    {
        public KeysData Keys { get; set; }

        public Morse() { 
            Keys = new KeysData();
        }
        private bool checkInput(string input)
        {
            if (input.Any()) {
                var validValues = Keys.MorseDigits.Select(x => x._value);
                foreach (var i in input)
                {
                    if (!validValues.Contains(i))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        private bool checkMorse(string input)
        {
            if (input.Any()){
                var validMorseChars = Keys.MorseDigits.Select(x => x._morse);
                var morseChars = input.Split(' ').ToList();
                foreach(var i in morseChars)
                {
                    if(!validMorseChars.Contains(i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public object ToMorse(string input)
        {
            input = input.ToUpper();
            if(checkInput(input))
            {
                var result = "";
                foreach (var i in input)
                {
                    foreach (var j in Keys.MorseDigits)
                    {
                        if (j._value.ToString() == i.ToString())
                        {
                            result += " " + j._morse;
                        }
                    }
                }
                return result.Trim(' ');
            }
            return false;
        }
        public object ToHumanic(string input)
        {
            if(checkMorse(input))
            {
                var result = "";
                var MorseChars = input.Trim(' ').Split(' ').ToList();
                foreach (var i in MorseChars)
                {
                    foreach(var j in Keys.MorseDigits)
                    {
                        if(i == j._morse)
                        {
                            result += j._value;
                        }
                    }
                }
                return result.Trim(' ');
            }
            return false;
        }
    }
}
