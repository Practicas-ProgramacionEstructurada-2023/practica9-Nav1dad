using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;

            do
            {
                Console.WriteLine("\nMenu de opciones");
                Console.WriteLine("1. Multiplicar numeros");
                Console.WriteLine("2. Restar numeros");
                Console.WriteLine("3. Concatenar cadenas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese una opcion");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:

                            Console.WriteLine("\nIngrese dos numeros enteros que desea multiplicar");

                            Console.WriteLine("\nNumero 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nNumero 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicacion (enteros): " + Multiplicar(num1, num2));

                            Console.WriteLine("\nIngrese numeros decimales para multiplicar");

                            Console.WriteLine("\nNumero 1: ");
                            double num1Double = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nNumero 2");
                            double num2Double = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicacion (decimal): " + Multiplicar(num1Double, num2Double));
                            break;

                        case 2:

                            Console.WriteLine("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));

                            break;

                        case 3:

                            Console.WriteLine("\nIngrese su primer nombre: ");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("\nIngrese su apellido");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("\nIngrese el separador");
                            string? separador1 = Convert.ToString(Console.ReadLine());

                            string resultadoCadena = ConcatenarCadenas(cadena1, cadena2, separador1);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoCadena}");

                            Console.WriteLine("\nIngrese su segundo nombre: ");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("\nIngrese su segundo apellido");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("\nIngrese el separador");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("\nIngrese su tercer apellido");
                            string? cadena5 = Convert.ToString(Console.ReadLine());

                            string resultadoCadena2 = ConcatenarCadenas(cadena3, cadena4, cadena5, separador2);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoCadena2}");

                            break;
                        case 4:

                            Console.WriteLine("\nSaliendo del programa");
                            break;

                        default:
                            Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                }
            } while (opciones != 4);
        }
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0]; // INICALIZAMOS EL RESULTADO CON EL PRIMER NUMERO

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i]; // RESTAMOS LOS NUMEROS UNO POR UNO
            }

            return resultado;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador1)
        {
            return cadena1 + separador1 + cadena2;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? cadena3, string? separador1)
        {
            return cadena1 + separador1 + cadena2 + separador1 + cadena3;
        }
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNADEZ
// CODIGO: U20230697