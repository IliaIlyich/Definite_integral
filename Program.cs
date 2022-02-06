using System;

namespace Delegat
{
    public delegate double MathF(double x);
    
    class Program
    {   
        static void Main(string[] args)
        {   double a, b;
            

            Console.WriteLine("Вычисление определенного интеграла методом трапеции");
            if (args.Length!=2)
            {
                Console.WriteLine("Введите координату х начала отрезка интерирования");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату х конца отрезка интерирования");
                b = int.Parse(Console.ReadLine()); 
            }
            else
            { 
                a = double.Parse(args[0]);
                b = double.Parse(args[1]);
            }
            Console.WriteLine($"Интеграл определен на отрезке [{a}, {b}]");

            Console.WriteLine("Введите число разбиения отрезка");
            int n = int.Parse(Console.ReadLine());
            
            MathF f = Math.Sqrt;
            Console.WriteLine($"Определенный интеграл от x2 = {Integral(a, b, n, f)}");
            f= Math.Sin;
            Console.WriteLine($"Определенный интеграл от sin(x) = {Integral(a, b, n, f)}");
            f=Math.Cos;
            Console.WriteLine($"Определенный интеграл от cos(x) = {Integral(a, b, n, f)}");

            
            static double Integral(double a, double b, int n, MathF f)
            {
                double h = (b-a)/n; 
                double I = 0;
                double step  = a;
                for (double i = 1; i<n; i++)
                {
                    step+=h;
                    I+= f(step);
                } 
                return h*(((f(a)+f(step+=h))/2)+I); 
            } 
            


            
            
            
        }
    }
}

