using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 1 номер 6
// Харисов Раиль 11-709

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год в формате YYYY");
            // считываем год
            string input = Console.ReadLine();

            // переводим год в число и записываем в переменную
            int year = Int32.Parse(input);

            // проверяем високостность года
            // В невисокосный год данный праздник выпадает на 13 сентября, в високосный — на 12 сентября. 
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) Console.WriteLine("12/09/" + year);
            else Console.WriteLine("13/09/" + year);
            
        }
    }
}
