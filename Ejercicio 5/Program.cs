using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        public static bool NumeroPerfecto(int numero)
        {
            bool bandera = false;
            int divisores = 0;

            for (int i = 1; i <= numero - 1; i++)
            {
                if (numero % i == 0)
                {
                    divisores += i;
                }
            }

            if (divisores == numero)
            {
                bandera = true;
            }
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
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Busqueda de numeros Perfecto con funciones");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num = 0;
            //bool bandera2 = false;

            Console.Write("Ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());

            //bandera2 = NumeroPerfecto(num);
            Console.WriteLine();
            /*if (bandera2 == true)
            {
                Console.WriteLine($" . {num} es perfecto");
            }
            else
            {
                Console.WriteLine($" . {num} no es perfecto");
            }*/
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" . Los numero perfectos entre 1 y {num} son : ");
            Console.Write("   __________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            for (int i = 1; i < num; i++)//Verifica los numeros que se encuntran entre 1 y num (es N) si son perfectos y los muestra en pantalla
            {                            //No hace la prueba en este caso sobre 1 y N, para que pruebe en N se coloca <=
                if (NumeroPerfecto(i))//Prueba iterando el valor i en la funcion, verificando si es numero perfecto en cada uno de los valores que toma i hasta N
                {
                    Console.WriteLine();

                    Console.Write($"   . {i} ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(" ****************");
            Console.WriteLine(" Fin  del proceso");
            Console.WriteLine(" ****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

