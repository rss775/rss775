using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// семестровая задача часть 1 номер 1
// Харисов Раиль 11-709

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты клетки в фотмате, подобном 'a1'");
            // считываем два символа координат
            string coord = Console.ReadLine();
            
            // преобразуем в координаты поля от 1 до 8
            int horisontalPos = (byte)coord[0] - 96;
            int verticalPos = (byte)coord[1] - 48;

            //если сумма этих координат без остатка делится на два то поле черное
            if (((horisontalPos + verticalPos) % 2) == 0) Console.WriteLine("BLACK");
            else Console.WriteLine("WHITE");                       
        }
    }
}
