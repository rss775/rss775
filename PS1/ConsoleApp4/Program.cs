using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 2 номер 15
// Харисов Раиль 11-709
/* Найти самую часто повторяющуюся цифру в k-ичной системе счисления (k от 2 до 5)
десятичного натурального числа n (n<=10^9)*/ 

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число равное желаемой степени счисления");
            var baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число в десятичной системе");
            var number = int.Parse(Console.ReadLine());
            var ost = 0;

            var a0 = 0;
            var a1 = 0;
            var a2 = 0;
            var a3 = 0;
            var a4 = 0;



            while (number != 0)
            {
                ost = number % baseNum;
                number = number / baseNum;
                if (ost == 0) a0++;
                else if (ost == 1) a1++;
                else if (ost == 2) a2++;
                else if (ost == 3) a3++;
                else if (ost == 4) a4++;
            }

            var max = a0;
            if (a1 > max) max = a1;
            if (a2 > max) max = a2;
            if (a3 > max) max = a3;
            if (a4 > max) max = a4;

            if (a0 == max) Console.WriteLine("Самая повторяющаяся цифра 0");
            if (a1 == max) Console.WriteLine("Самая повторяющаяся цифра 1");
            if (a2 == max) Console.WriteLine("Самая повторяющаяся цифра 2");
            if (a3 == max) Console.WriteLine("Самая повторяющаяся цифра 3");
            if (a4 == max) Console.WriteLine("Самая повторяющаяся цифра 4");

        }
    }
}
