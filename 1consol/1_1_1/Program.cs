using System;

namespace _1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите площадь полной поверхности куба: ");
                double cubeArea = Convert.ToDouble(Console.ReadLine());
                double edge = Math.Sqrt(cubeArea / 6);
                Console.Write($"\n\tДлина ребра = {edge}\n\n");
            }
            catch (Exception)
            {
                Console.Write("\n\t\t****Введено не верное значение (НЕ ЧИСЛО)***\n\n");
            }
        }
    }
}
