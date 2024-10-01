using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.Знаки препинания не используются. 
            //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра(пример палиндрома – «А роза упала на лапу Азора»).
            Console.WriteLine("Введите строку для проверки:"); 
            string newString = Console.ReadLine();
            string strBackwords = "";
            //удаляем пробелы
            newString = newString.Replace(" ", "");
            //приводим в верхний регистр все символы
            newString = newString.ToUpper();
            //формируем новую строку в обратном порядке
            foreach (char c in newString)
            {
                strBackwords = c + strBackwords;
            }
            //приводим к верхнему регистру для сравнения
            strBackwords = strBackwords.ToUpper();
            if (newString == strBackwords)
            {
                Console.WriteLine("Строка является палиндромом!");
            } 
            else
            {
                Console.WriteLine("Строка не является палиндромом!");
            }
            Console.ReadKey();
        }
    }
}
