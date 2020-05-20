using System;

namespace tp6
{
    class tp6_2
    {
        public static void Main()
        {
            int seguir;
            do {
                int opcion, num1, num2, resultado;
                do {
                    Console.Clear();
                    Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n\nElija una opcion:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion > 4 || opcion < 1);
                Console.Clear();
                Console.WriteLine("Valor para numero 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nValor para numero 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("\nLa Suma entre " + num1 + " y de " + num2 + " es igual a: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("\nLa Resta entre " + num1 + " y de " + num2 + " es igual a: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("\nLa Multiplicacion entre " + num1 + " y de " + num2 + " es igual a: " + resultado);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("\nLa Division entre " + num1 + " y de " + num2 + " es igual a: " + resultado);
                        }
                        else 
                        {
                            Console.WriteLine("\nNo se puede dividir entre 0");
                        }
                        break;
                }
                do
                {
                    Console.WriteLine("\nDeseas realizar otro calculo? 1/0 (Si/No): ");
                    seguir = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                } while (seguir < 0 | seguir > 1);
            } while(seguir == 1);
        }
    }
}
