using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class ACipher: ICipher
    {
        public string s;
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        string output = "";
        public string Encode(string s)
        {
            output = "";
            int index;
            foreach (var ch in s)
            {
                index = alphabet.IndexOf(ch) + 1;
                if (alphabet.IndexOf(ch) == -1)
                {
                    output += ch;
                }
                else if (ch.Equals('я'))
                {
                    output += 'а';
                }
                else if (ch.Equals('Я'))
                {
                    output += 'А';
                }
                else
                {
                    output += alphabet[index];
                }

            }
            return output;
        }
        public string Decode(string s)
        {
            output = "";
            foreach (var ch in s)
            {
                int index;
                index = alphabet.IndexOf(ch) - 1;
                if (alphabet.IndexOf(ch) == -1)
                {
                    output += ch;
                }
                else if (ch.Equals('а'))
                {
                    output += 'я';
                }
                else if (ch.Equals('А'))
                {
                    output += 'Я';
                }
                else
                {
                    output += alphabet[index];
                }

            }
            return output;
        }
    }
}
