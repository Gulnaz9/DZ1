using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности"); //радиус только целое число
            int R = int.Parse(Console.ReadLine());
            double l = 2 * Math.PI * R; //Math.PI константа
            Console.WriteLine("Длина окружности равна " + l);
            double S = Math.PI * R * R;
            Console.WriteLine("Площадь круга равна " + S);
            Console.ReadKey();

            /* второй вариант
             * int stepen = 2;
             * double S = Math.PI * Math.Pow(R, stepen); 
             * Console.WriteLine("Площадь круга равна " + S);
             */
        }
    }
}
