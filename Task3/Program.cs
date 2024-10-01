using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
            //В строке может быть несколько фрагментов, заключённых в фигурные скобки.
            //Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
            Console.WriteLine("Введите строку с фигурными скобками: ");
            string s = Console.ReadLine();

            while (s.IndexOf("{") != -1 & s.IndexOf("}") != -1)
            {
                //на случай, если останется закрывающая скобка от вложенности, её нужно удалить
                if (s.IndexOf("{") > s.IndexOf("}"))
                {
                    s = s.Remove(s.IndexOf("}"), 1);
                }

                s = s.Remove(s.IndexOf("{"), s.IndexOf("}") - s.IndexOf("{") + 1);
            }

            Console.WriteLine(s);
            Console.ReadKey();
            //строка, на которой проверяла решение
            //текст {текст {текст}} текст {текст}
        }
    }
}
