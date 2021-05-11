using System;
using System.Collections.Generic;


namespace Lab2_16_2
{
    class Program
    {
        static void Main()
        {
            GetFunction();
        }
        private static void GetFunction()
        {
            Console.Write("Введите X: ");
            double argX = double.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            double argY = double.Parse(Console.ReadLine());

            if ((argX <= 0 && argY <= 0 && argY >= argX) || (argX >= 0 && argY >= 0 && argY <= argX) && argY <= (2.0 - (argX * argX)))
            {
                Console.WriteLine("Точка попадает в область");
            }
            else
                Console.WriteLine("Выкуси кукиша не попал");
            
        }
    }
}
