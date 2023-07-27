using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Suma, promedio,maximo y menimo valor de un numero N carga aleatorio");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(" ++++++++++++++++++++++");
            Console.WriteLine(" While - Do While - For");
            Console.WriteLine(" ++++++++++++++++++++++");
            Console.WriteLine();
            double suma = 0;
            int contador = 0;
            double promedio = 0;
            int maximo = 0;
            int minimo = 0;
            double cantidad = 0;
            Random aleatorio = new Random();
            Console.Write(" Ingresar la cantidad de numeros que usara = ");
            cantidad = Int32.Parse(Console.ReadLine());
           // int N = aleatorio.Next(1,50); 
            minimo = int.MaxValue;
            maximo = int.MinValue;
            Console.WriteLine();
           /*for (int i = 1; i <= cantidad; i++)
            {

                int N = aleatorio.Next(1,50);
                suma += N;
                Console.WriteLine($" . N {i} = {N}");
                if (N > maximo)
                {
                    maximo = N;
                }
                if (N < minimo)
                {
                    minimo = N;
                }
            }*/

             /*while (contador < cantidad)
             {
                 contador++;
                int N = aleatorio.Next(1, 50);
                suma += N;
                Console.WriteLine($" . N {contador} = {N}");
                if (N > maximo)
                {
                    maximo = N;
                }
                if (N < minimo)
                {
                    minimo = N;
                }
            }*/
            do {
               contador++;
                int N = aleatorio.Next(1, 50);
                suma += N;
                Console.WriteLine($" . N {contador} = {N}");
                if (N > maximo)
                {
                    maximo = N;
                }
                if (N < minimo)
                {
                    minimo = N;
                }
            } while (contador < cantidad);


            promedio = suma / cantidad;
            Console.WriteLine();
            
            Console.WriteLine($" . Suma = {suma}");
            Console.WriteLine($" . Promedio = {promedio:F2}");
            Console.WriteLine($" . Maximo = {maximo}");
            Console.WriteLine($" . Minimo = {minimo}");
            Console.WriteLine();
            Console.WriteLine(" ****************");
            Console.WriteLine(" Fin  del proceso");
            Console.WriteLine(" ****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
