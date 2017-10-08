using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 4 номер 15
// Харисов Раиль 11-709
/* Найти последнюю цифру A^B (1<=A,B<=10000)
 */

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine((Math.Pow((a % 10), ((b - 1) % 4 + 1))) % 10);

        }
    }
}
