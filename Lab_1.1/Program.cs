using System;

namespace Lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2; // переменная типа int
            Console.WriteLine(a);
            bool b; //Переменная типа bool
            b = true;
            Console.WriteLine(b);
            float c = 3.2f; //Переменная типа Float
            Console.WriteLine(c);
            char d = 't'; //Переменная типа Char
            Console.WriteLine(d);

            const double PI = 3.14;
            double g = 34.7;
            g = PI;
            // PI = g; Ошибка компиляции
            Console.WriteLine(g);
            int a1 = 40;
            short b1 = 11;
            a1 = b1; //неявное преобразование,так как int большого размера
            //z = e; ошибка компиляции
            Console.WriteLine(a1);
            int a2 = 30000;
            short b2 = 20;
            a2 = (short)b2; // ошибки нет,просто утеря данных
            Console.WriteLine(a2);
        }
    }
}
