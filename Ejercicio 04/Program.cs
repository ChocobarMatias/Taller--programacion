using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{

    /*
                 Grupo - Integrantes

            *  Arias Olaiz Marcos	50665
            *  Chocobar Matías		59234
            *  Esper Rodrigo		59423
            *  Gatti Luciano		59130

    */
    class Program
    {
        public static bool NumeroPrimo(int numero)
        {
            bool bandera = false;
            int contador = 0;

            for (int i = 1; i <= numero; i++)//Verifica los divisores de un numero realizando recorrido de 1 a numero (N)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)//Condicion para ver si un numero es primo 
            {
                bandera = true;//cuando detecta que el numero verificado tiene 2 divisories gracias al contador
            }                  // la bandera cambia de false a true
            else
            {
                bandera = false;
            }

            return bandera;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;//cambia de color las letras
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Busqueda de numeros Primo con funciones");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine();
            int num = 0;

            Console.Write(" Ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());
            Console.Write("-----------------------");
            Console.Clear();
            Console.WriteLine();
            NumeroPrimo(num);//Funcion de verificacion de numero primo
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" . Los numero primos entre 1 y {num} son : ");
            Console.Write("   __________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            for (int i = 1; i < num; i++)//Verifica los numeros que se encuntran entre 1 y num (es N) si son primos y los muestra en pantalla
            {                            //No hace la prueba en este caso sobre 1 y N, para que pruebe en N se coloca <=
                if (NumeroPrimo(i))//Prueba iterando el valor i en la funcion, verificando si es numero primo en cada uno de los valores que toma i hasta N
                {
                    Console.WriteLine();

                    Console.Write($"   . {i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ********************");
            Console.WriteLine("       | Fin  del proceso |");
            Console.WriteLine("       ********************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
