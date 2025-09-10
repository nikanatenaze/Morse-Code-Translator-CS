using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class KeysData
    {
        public List<KeyModel> MorseDigits { get; set; }
        public KeysData()
        {
            MorseDigits = new List<KeyModel>
{
new KeyModel { _id = 1,  _value = 'A', _morse = ".-" },
    new KeyModel { _id = 2,  _value = 'B', _morse = "-..." },
    new KeyModel { _id = 3,  _value = 'C', _morse = "-.-." },
    new KeyModel { _id = 4,  _value = 'D', _morse = "-.." },
    new KeyModel { _id = 5,  _value = 'E', _morse = "." },
    new KeyModel { _id = 6,  _value = 'F', _morse = "..-." },
    new KeyModel { _id = 7,  _value = 'G', _morse = "--." },
    new KeyModel { _id = 8,  _value = 'H', _morse = "...." },
    new KeyModel { _id = 9,  _value = 'I', _morse = ".." },
    new KeyModel { _id = 10, _value = 'J', _morse = ".---" },
    new KeyModel { _id = 11, _value = 'K', _morse = "-.-" },
    new KeyModel { _id = 12, _value = 'L', _morse = ".-.." },
    new KeyModel { _id = 13, _value = 'M', _morse = "--" },
    new KeyModel { _id = 14, _value = 'N', _morse = "-." },
    new KeyModel { _id = 15, _value = 'O', _morse = "---" },
    new KeyModel { _id = 16, _value = 'P', _morse = ".--." },
    new KeyModel { _id = 17, _value = 'Q', _morse = "--.-" },
    new KeyModel { _id = 18, _value = 'R', _morse = ".-." },
    new KeyModel { _id = 19, _value = 'S', _morse = "..." },
    new KeyModel { _id = 20, _value = 'T', _morse = "-" },
    new KeyModel { _id = 21, _value = 'U', _morse = "..-" },
    new KeyModel { _id = 22, _value = 'V', _morse = "...-" },
    new KeyModel { _id = 23, _value = 'W', _morse = ".--" },
    new KeyModel { _id = 24, _value = 'X', _morse = "-..-" },
    new KeyModel { _id = 25, _value = 'Y', _morse = "-.--" },
    new KeyModel { _id = 26, _value = 'Z', _morse = "--.." },

    // Numbers
    new KeyModel { _id = 27, _value = '0', _morse = "-----" },
    new KeyModel { _id = 28, _value = '1', _morse = ".----" },
    new KeyModel { _id = 29, _value = '2', _morse = "..---" },
    new KeyModel { _id = 30, _value = '3', _morse = "...--" },
    new KeyModel { _id = 31, _value = '4', _morse = "....-" },
    new KeyModel { _id = 32, _value = '5', _morse = "....." },
    new KeyModel { _id = 33, _value = '6', _morse = "-...." },
    new KeyModel { _id = 34, _value = '7', _morse = "--..." },
    new KeyModel { _id = 35, _value = '8', _morse = "---.." },
    new KeyModel { _id = 36, _value = '9', _morse = "----." },

    // Space
    new KeyModel { _id = 37, _value = ' ', _morse = "/" }
};
        }

    }
}
