using System;
using System.Collections.Generic;
using System.Text;

namespace tp6
{
    class tp6_4
    {
        public static void Main()
        {
            string cadena, cadena2;
            string[] string_aux;
            float resultado;

            Console.WriteLine("Ingrese una cadena mayor o igual a 6 caracteres: ");
            cadena = (Console.ReadLine());

            Console.WriteLine("\nAlgunas letras: " + cadena[0] + " " + cadena[2] + " " + cadena[4]);
            Console.WriteLine("Longitud de la cadena: " + cadena.Length);

            //Concatenar

            Console.WriteLine("\nIngrese una segunda cadena: ");
            cadena2 = (Console.ReadLine());
            cadena = String.Concat(cadena, cadena2);
            Console.WriteLine("Cadenas concatenadas: " + cadena);

            Console.WriteLine("Subcadena: " + cadena.Substring(0, 3));

            //Calculadora 

            Calculadora();

            //Foreach

            foreach (char caracter in cadena)
            {
                Console.Write(caracter + " ");
            }

            //Busqueda

            Console.WriteLine("\n\nIngrese una cadena para buscar: ");
            cadena2 = (Console.ReadLine());

            if (cadena.Contains(cadena2))
            {
                Console.WriteLine("Busqueda exitosa");
            }
            else
            {
                Console.WriteLine("Busqueda fallida");
            }

            //Mayusculas y Minusculas

            Console.WriteLine("\nCadena convertida en Mayusculas: " + cadena.ToUpper());
            Console.WriteLine("Cadena convertida en Minusculas: " + cadena.ToLower());

            //Comparar

            Console.WriteLine("\nCadena para comparar: ");
            cadena2 = (Console.ReadLine());

            if (cadena.CompareTo(cadena2) == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas");
            }

            //Separar la cadena

            Console.Write("\nIngrese un caracter para separar la cadena: ");
            char car = Convert.ToChar(Console.ReadLine());
            string_aux = cadena.Split(car.ToString());
            foreach (string arreglo in string_aux)
            {
                Console.WriteLine(arreglo);
            }

            //Expresiones con operadores integrados

            Console.WriteLine("\nIngrese una expresion para operar con (+, -, *, /), por ejemplo 5+6: ");
            cadena2 = (Console.ReadLine());

            if (cadena2.Contains('+'))
            {
                string[] numero = cadena2.Split('+');
                resultado = Convert.ToSingle(numero[0]) + Convert.ToSingle(numero[1]);
                Console.WriteLine("La suma de " + numero[0] + " y de " + numero[1] + " es igual a: " + resultado);
            }
            if (cadena2.Contains('-'))
            {
                string[] numero = cadena2.Split('-');
                resultado = Convert.ToSingle(numero[0]) - Convert.ToSingle(numero[1]);
                Console.WriteLine("La resta de " + numero[0] + " y de " + numero[1] + " es igual a: " + resultado);
            }
            if (cadena2.Contains('*'))
            {
                string[] numero = cadena2.Split('*');
                resultado = Convert.ToSingle(numero[0]) * Convert.ToSingle(numero[1]);
                Console.WriteLine("La multiplicacion de " + numero[0] + " y de " + numero[1] + " es igual a: " + resultado);
            }
            if (cadena2.Contains('/'))
            {
                string[] numero = cadena2.Split('/');
                if ((Convert.ToDouble(numero[1]) != 0))
                {
                    resultado = Convert.ToSingle(numero[0]) / Convert.ToSingle(numero[1]);
                    Console.WriteLine("La division de " + numero[0] + " y de " + numero[1] + " es igual a: " + resultado);
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir en 0");
                }
            }

        }

        public static void Calculadora()
        {
            int opcion, num1, num2, resultado;
            do
            {
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n\nElija una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion > 4 || opcion < 1);
            Console.WriteLine("\nValor para numero 1: ");
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
        }
    }
}