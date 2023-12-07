using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIa.Sprint1.Task7.V16.Lib;

namespace Tyuiu.DreminIa.Sprint1.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x;


            Console.Title = "Спринт #1 | Выполнил: Дремин ИА | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Добовление решений к итоговым проектам по спринту                 *");
            Console.WriteLine("* Задание #7" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 16" + String.Concat(Enumerable.Repeat(" ", 61)) + "*");
            Console.WriteLine("* Выполнил: Дремин ИА | | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет значение выражения по формуле и печатает его на экран         *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));


            Console.WriteLine("Введите значение переменной X");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Результат" + String.Concat(Enumerable.Repeat(" ", 65)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));


            if (ds.Calculate(x) != 444)
            {
                Console.WriteLine($"Значение выражения равно {ds.Calculate(x)}");
            }
            else
            {
                Console.WriteLine("Выражение не определенно");
            }

            Console.ReadKey();
        }
    }
}