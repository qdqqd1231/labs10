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
            bool flag1 = true;
            string selection1;
            string selection2;
            string str = "";
            while (flag1)
            {

                Console.WriteLine("введите команду <1>  --> для использования основного шифратора, <2>  --> для использования альтернативного шифратора, <0> --> для выхода ");
                selection1 = Console.ReadLine();

                Console.Clear();
                if (Equals(selection1, "1"))
                {
                    Console.Write("введите строку для шифрования  -->  ");
                    str = Console.ReadLine();
                    str = acipher.Encode(str);
                    Console.WriteLine("Зашифрованная строка --> " + str);
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
                if (Equals(selection1, "2"))
                {
                    Console.Write("введите строку для шифрования  -->  ");
                    str = Console.ReadLine();
                    str = bcipher.Encode(str);
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
                if (Equals(selection1, "0"))
                {
                    flag1 = false;
                }
            }
            Console.WriteLine("task 10.2");
            Figure point = new Point(0, 0, ConsoleColor.Red);
            string selection = "";
            bool flag = true;
            int visible;
            int color;
            while (flag1)
            {
                Console.WriteLine("выбирите бействие : <1> --> сменить позицию,<2> --> показать/скрыть,<3> --> изменить цвет, <4> --> показать инфу");
                selection1 = Console.ReadLine();
                if (Equals(selection1, "1"))
                {
                    Console.WriteLine("нажимайте стрелки на нампаде, чтобы передвинуть фигуру");
                    bool flag0 = true;
                    while (flag0)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.NumPad2)
                        {
                            point.MoveDown();
                        }
                        if (key == ConsoleKey.NumPad8)
                        {
                            point.MoveUp();
                        }
                        if (key == ConsoleKey.NumPad6)
                        {
                            point.MoveRight();
                        }
                        if (key == ConsoleKey.NumPad8)
                        {
                            point.MoveLeft();
                        }
                        if (key == ConsoleKey.Escape)
                        {
                            flag0 = false;
                            Console.Clear();
                        }
                        Console.Write(" , ");
                    }
                }
                if (selection1.Equals("2"))
                {
                    Console.WriteLine("0-показать, 1- скрыть");
                    while (!int.TryParse(Console.ReadLine(), out visible) || visible > 1 || visible < 0)
                    {
                        Console.WriteLine("повторите ввод");
                    }
                    point.switchVisibility((VisibleStatus)visible);
                }
                if (selection1.Equals("3"))
                {
                    Console.WriteLine("0-15 colors");
                    while (!int.TryParse(Console.ReadLine(), out color) || color > 15 || color < 0)
                    {
                        Console.WriteLine("повторите ввод");
                    }
                    point.switchColor((ConsoleColor)color);
                }
                if (selection1.Equals("4"))
                {
                    point.ShowInfo();
                }
            }

        }

    }
}
    

