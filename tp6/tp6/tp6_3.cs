using System;

namespace tp6
{
    class tp6_3
    {
        public static void Main()
        {
            float a, b;

            Console.WriteLine("Ingresar un numero: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nValor Absoluto: " + Math.Abs(a));
            Console.WriteLine("Cuadrado: " + Math.Pow(a, 2));
            Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(a));
            Console.WriteLine("Seno: " + Math.Sin(a));
            Console.WriteLine("Coseno: " + Math.Cos(a));
            Console.WriteLine("Entero de float: " + Math.Truncate(a));

            Console.WriteLine("\nIngresar un numero A: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nIngresar un numero B: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nMaximo: " + Math.Max(a, b));
            Console.WriteLine("Minimo: " + Math.Min(a, b));
        }
    }
}
