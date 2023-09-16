using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусную меру угла");
            double degree = int.Parse(Console.ReadLine());
            double x = (degree * Math.PI) / 180; //переводит градусы в радианы
            double Y = Math.Cos(x);

            Console.WriteLine("Y=cos(" + degree + ")=" + Y);
            Console.ReadKey();

        }
    }
}
