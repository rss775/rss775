using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 3 номер 6
// Харисов Раиль 11-709
/*На вход подаётся последовательность из n целых чисел (по модулю <=10^9). Определить
является ли последовательность строго возрастающей (каждый элемент > предыдущего)*/

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int temp = 0;
            bool answer = true;
            Console.WriteLine("Сколько будете вводить целых чисел?");
            int n = int.Parse(Console.ReadLine());
            temp = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n - 1); i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number <= temp) answer = false;
                temp = number;
            }

            Console.WriteLine(answer);

        }
    }
}
