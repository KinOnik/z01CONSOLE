using System;

namespace _1_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool errors = false;
            try
            {
                int num;
                Console.Write("\n\tВведите двухзначное число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 10 || num > 99)
                {
                    errors = true;
                    throw new Exception("\n\t\t****Число не двухнзначное!****\n\n");
                }
                if (((num % 10) + (num / 10)) % 2 == 0)
                {
                    Console.Write("\n\tСумма цифр числа четная\n\n");
                }
                else
                {
                    errors = true;
                    throw new Exception("\n\t\t****Число нечетное!****\n\n");
                }
            }
            catch (Exception ex) when (errors)
            {
                Console.Write(ex);
            }
            catch (Exception)
            {
                throw new Exception("\n\t\t****Введено не число****\n\n");
            }
        }
    }
}
