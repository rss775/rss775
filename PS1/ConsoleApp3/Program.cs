using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 2 номер 5
// Харисов Раиль 11-709
/* По двум членам арифметической прогрессии и шагу прогрессии посчитать количество элементов
и сумму элементов прогрессии между данными членами.Члены прогрессии и шаг –
вещественные числа. */


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите один член арифметической прогрессии");
            double a = double.Parse (Console.ReadLine());
            Console.WriteLine("Введите другой член арифметической прогрессии");
            double b = double.Parse (Console.ReadLine());
            Console.WriteLine("Введите шаг арифметической прогрессии");
            double step = double.Parse(Console.ReadLine());
            int count = 0;
            double sum = 0;

            // если они равны сразу пишем ответ
            if (a == b)
            {
                Console.WriteLine("Количество элементов между ними 0, сумма 0.");
            }
            else
            {
                //если a больше b то меняем их местами, обнуляем сумму 
                if (a >= b)
                {
                    sum = a;
                    a = b;
                    b = sum;
                    sum = 0;
                }

                // делаем первое сложение шага к первому члену
                a = a + step;
            
                // запускаем цикл с подсчетом 
                while (a < b)
                {
                    count++; // инкремирум кол-во эл-тов
                    sum = sum + a; // складываем к суммне прошлую сумму
                    a = a + step;
                }

                Console.WriteLine("Количество элементов между ними " + count + ", сумма " + sum + ".");
            }
        }
    }
}
