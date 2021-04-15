using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._31
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.31
            Console.WriteLine("введите трёхзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k / 10;
            int b = k % 100;
            int c = k / 10 & 10;
            if ((a == b) & (b == c) & (c == a))
            {
                Console.WriteLine("Равен");
            }
            else
            {
                Console.WriteLine("Не равен");
            }
            if ((a == b) | (b == c) | (c == a))
            { Console.WriteLine("Да"); }
            else
            { Console.WriteLine("Нет"); }

            Console.ReadKey();
        }
    }
}
