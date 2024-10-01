using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.Знаки препинания не используются. Найти самое длинное слово в строке.
            Console.WriteLine("Введите строку:");
            string newString = Console.ReadLine();
            string[] wordsString = newString.Split();
            string longestWord = wordsString[0];

            foreach (string word in wordsString)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("Самое длинное слово в строке - {0}", longestWord);
            Console.ReadKey();
        }
    }
}
