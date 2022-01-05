using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            Circle.r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - найти длину окружности");
            Console.WriteLine("2 - найти площадь круга");
            Console.WriteLine("3 - узнать, попадают ли введенные координаты в пределы круга");
            int v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    {
                        Circle.Length();
                        Console.WriteLine("Длина окружности равна {0:f3}", Circle.L);
                        break;
                    }
                case 2:
                    {
                        Circle.Square();
                        Console.WriteLine("Площадь круга равна {0:f3}", Circle.S);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите координату х центра круга:");
                        Circle.x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату y центра круга:");
                        Circle.y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату х:");
                        Circle.X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату y:");
                        Circle.Y = Convert.ToDouble(Console.ReadLine());
                        Circle.Find();
                        Console.WriteLine(Circle.Result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Надо выбрать число от 1 до 3!");
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
    static class Circle
    {
        public static double r;
        public static double L;
        public static double S;
        public static double x;
        public static double y;
        public static double X;
        public static double Y;
        public static double c;
        public static string Result;


        public static void Length()
        {
            L = 2 * Math.PI * r;
        }
        public static void Square()
        {
            S = Math.PI * r * r;
        }
        public static void Find()
        {
            c = Math.Sqrt(Math.Abs(x - X) * Math.Abs(x - X) + Math.Abs(y - Y) * Math.Abs(y - Y));
            if (c <= r)
            {
                Result = "Введенные координаты находятся внутри круга!";
            }
            else
            {
                Result = "Введенные координаты находятся за пределами круга!";
            }
        }
    }
}
