using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 4 номер 5
// Харисов Раиль 11-709
/*Посчитать, сколько совершенных чисел от 0 до 1000000. Число n - совершенное, если сумма его
делителей равна 2n.

Задание видимо имеет опечатку, согласно Википедии "Число n - совершенное, если сумма его
делителей равна n."
 */

namespace ConsoleApp7
{
    class Program
    {
        public static bool CheckNumber(int num)
        {
            int sum = 1; 
            for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;  
            return (sum  == num);                                             

        }

        static void Main(string[] args)
        {
            int N = 8129;
            int count = 0;
            for (int i = 1; i < N; i++)
                if (CheckNumber(i))
                {
                    count++;
                    Console.WriteLine(i);
                }
            Console.WriteLine(count);

            Console.ReadKey();
        }

    }
}
