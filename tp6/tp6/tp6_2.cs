using System;

namespace tp6
{
    class tp6_2
    {
        public static void Main()
        {
            int seguir;
            do {
                int opcion, a, b, total;
                do {
                    Console.Clear();
                    Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n\nElija una opcion:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion > 4 || opcion < 1);
                Console.Clear();
                Console.WriteLine("Valor para numero a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nValor para numero b: ");
                b = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        total = a + b;
                        Console.WriteLine("\nSuma: " + total);
                        break;
                    case 2:
                        total = a - b;
                        Console.WriteLine("\nResta: " + total);
                        break;
                    case 3:
                        total = a * b;
                        Console.WriteLine("\nMultiplicacion: " + total);
                        break;
                    case 4:
                        total = a / b;
                        Console.WriteLine("\nDivision: " + total);
                        break;
                }
                Console.WriteLine("\nDeseas realizar otro calculo? 1/0 (Si/No): ");
                seguir = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while(seguir == 1);
        }
    }
}
