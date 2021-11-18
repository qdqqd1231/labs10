using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class Program
    {
        static void Main(string[] args)
        {
            ACipher acipher = new ACipher();
            BCipher bcipher = new BCipher();
            bool flag = true;
            string selection;
            string selection2;
            string str = "";
            while (flag)
            {

                Console.WriteLine("введите команду <1>  --> для использования основного шифратора, <2>  --> для использования альтернативного шифратора, <0> --> для выхода ");
                selection = Console.ReadLine();

                Console.Clear();
                if (Equals(selection, "1"))
                {
                    Console.Write("введите строку для шифрования  -->  ");
                    str = Console.ReadLine();
                    str = acipher.Encode(str);
                    Console.WriteLine("Зашифрованная строка --> "+str);
                    Console.WriteLine("дешифровать эту стоку <0> ?");
                    selection2 = Console.ReadLine();
                    if (selection2.Equals("0"))
                    {
                        str = acipher.Decode(str);
                        Console.WriteLine("дешифрованная строка --> " + str);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Equals(selection, "2"))
                {
                    Console.Write("введите строку для шифрования  -->  ");
                    str = Console.ReadLine();
                    str= bcipher.Encode(str);
                    Console.WriteLine("Зашифрованная строка -->  " + str);
                    Console.WriteLine("дешифровать эту стоку <0> ?");
                    selection2 = Console.ReadLine();
                    if (selection2.Equals("0"))
                    {
                        str = bcipher.Decode(str);
                        Console.WriteLine("дешифрованная строка --> " + str);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Equals(selection, "0"))
                {
                    flag = false;
                }
            }
        }
    }
}
