using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte Psweets = 200; //P - price, фиксированная цена за кг
            byte Pcookies = 183;
            byte Papple = 49;

            Console.WriteLine("Сколько кг конфет?");
            double X = double.Parse(Console.ReadLine()); // X, Y, Z - масса 
            Console.WriteLine("Сколько кг печенья?");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок?");
            double Z = double.Parse(Console.ReadLine());

            double WeightX = Psweets * X;//вводим вес
            double WeightY = Pcookies * Y;
            double WeightZ = Papple * Z;

            double Resume = WeightX + WeightY + WeightZ;//сумма покупки
            Console.WriteLine("Стоимость покупки " + Resume);
            


        }
    }
}
