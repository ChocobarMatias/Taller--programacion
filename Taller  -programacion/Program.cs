using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Taller_programacion
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
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;//cambia de color las letras
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Suma, promedio,maximo y minimo valor de un numero N");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine(" ++++++++++++++++++++++");
            Console.WriteLine(" While - Do While - For");
            Console.WriteLine(" ++++++++++++++++++++++");
            Console.WriteLine();
            int N = 0;
            double suma = 0;//Acumulador
            int contador = 0;//contador
            double promedio = 0;
            int maximo = 0;
            int minimo = 0;
            double cantidad = 0;
            minimo = int.MaxValue;
            maximo = int.MinValue;

            Console.Write(" Ingresar la cantidad de numeros que usara = ");
            cantidad = Int32.Parse(Console.ReadLine());

            Console.Clear();//Limpia la pantalla mostrada anterior para mostrar los de las lineas siguientes
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;//cambia de color las letras
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($" Calculo y Muestra de Resultados correspondientes al numero = {N} ");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine();
            /*for (int i = 1; i <= cantidad; i++)
              {
                Console.Write(" Ingresar un numero = ");
                N = Int32.Parse(Console.ReadLine());
               
                suma += N;
                 
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

                Console.Write(" Ingresar un numero = ");
                N = Int32.Parse(Console.ReadLine());
                contador++;
                suma += N;

                if (N > maximo)
                {
                    maximo = N;
                }
                if (N < minimo)
                {
                    minimo = N;
                }
            }*/
            do
            {
              
                Console.Write(" Ingresar un numero = ");
                N = Int32.Parse(Console.ReadLine());
                contador++;
                suma += N;
                 
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
            Console.ForegroundColor = ConsoleColor.Red;//cambia de color las letras
            Console.WriteLine($" . Suma = {suma}");
            Console.ForegroundColor = ConsoleColor.Green;//cambia de color las letras
            Console.WriteLine($" . Promedio = {promedio:F2}");
            Console.ForegroundColor = ConsoleColor.Yellow;//cambia de color las letras
            Console.WriteLine($" . Maximo = {maximo}");
            Console.ForegroundColor = ConsoleColor.Yellow;//cambia de color las letras
            Console.WriteLine($" . Minimo = {minimo}");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine();
            Console.WriteLine(" ****************");
            Console.WriteLine(" Fin  del proceso");
            Console.WriteLine(" ****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
