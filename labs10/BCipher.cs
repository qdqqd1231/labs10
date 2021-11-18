using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class BCipher: ICipher
    {
        public string s;
        string alphabetUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        string alphabetLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string output = "";
        public string Encode(string s)
        {
            int index;
            foreach (var ch in s)
            {

                if (char.IsUpper(ch))
                {
                    index = alphabetUpper.Length - alphabetUpper.IndexOf(ch) - 1;
                    if (alphabetUpper.IndexOf(ch) == -1)
                    {
                        output += ch;
                    }
                    else
                    {
                        output += alphabetUpper[index];
                    }
                }
                if (char.IsLower(ch))
                {
                    index = alphabetLower.Length - alphabetLower.IndexOf(ch) - 1;
                    if (alphabetLower.IndexOf(ch) == -1)
                    {
                        output += ch;
                    }
                    else
                    {
                        output += alphabetLower[index];
                    }
                }
            }
            return output;
        }
        public string Decode(string s)
        {
            output = "";
            return Encode(s);

        }
        }
}
