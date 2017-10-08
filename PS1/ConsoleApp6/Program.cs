using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 3 номер 16
// Харисов Раиль 11-709
/*Считывая числа пока не встретится 0, для каждого положительного числа (строго >0) записать в
выходной поток символ + соответствующее число раз и ограничитель
 */

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int count = 0;
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0) break;
                else
                {
                    if (number > 0)
                    {
                        for (int i = 0; i < (number - 1); i++)
                        {
                            Console.Write("+,");
                        }
                        Console.WriteLine("+");
                    }
                }
            }


        }
    }
}
