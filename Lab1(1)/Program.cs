using System;

namespace lab1
{
    public class Program
    {
        public static double S, V;
        static int Main()
        {
            
            Console.WriteLine("Куб з ребром:");
            Console.Write("Сторона куба (a):");
            int a = Convert.ToInt32(Console.ReadLine());
            volume(a);
            square(a);
            Console.WriteLine("Об'єм куба:" + V);
            Console.WriteLine("Площа поверхнi:" + S);//
            return 0;
        }
        static public double volume(int a)
        {
            V = a * a * a;
           return V;
        }
        static public double square(int a)
        {
            S = Math.Pow(a, 2) * 6;
            return S;
        }
    }
}
