using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KornilovKA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KornilovKA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление выражения (x + y + z) * 5");
            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            var result = DataService.Calc(x, y, z);
            Console.WriteLine("Ответ: " + result);
            Console.ReadKey();
        }
    }
}
