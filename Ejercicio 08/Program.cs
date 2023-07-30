using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;//cambia de color las letras
            Console.WriteLine(" =======================================================================================");
            Console.WriteLine(" | Generacion de 2 vectores de de tamaño tamA y tamB y 1 tercero de tamaño tamA + tamB |");
            Console.WriteLine(" =======================================================================================");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine();
            int tamA = 0;
            int tamB = 0;
            Console.Write(" Ingresar el tamaño del Vector A = ");
            tamA = Int32.Parse(Console.ReadLine());//se coloca arriba del vector ya que el mismo depende de est variable
            int[] A = new int[tamA];//vector A de tamaño tamA
            Console.WriteLine();
            Console.Write(" Ingresar el tamaño del Vector B = ");
            tamB = Int32.Parse(Console.ReadLine());//se coloca arriba del vector ya que el mismo depende de est variable
            Console.Clear();
            int[] B = new int[tamB];//vector B de tamaño tamB
            //Genera el vector C la cual tiene tamaño tamA + tamB
            int[] C = new int[tamA + tamB];
            //Genera Vector A
            Random aleatorio = new Random();//crea los elementos de los vectores aleatoriamente

            for (int i = 0; i < A.Length; i++)//crea vector A
            {
                Console.ForegroundColor = ConsoleColor.Blue;//cambia de color las letras
                A[i] = aleatorio.Next(20);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;//cambia de color las letras
            Console.WriteLine(" . Vectores desordenados ");
            Console.WriteLine("   ______________________");
            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
            Console.WriteLine();
            Console.Write("  A = [");
            Console.Write(string.Join(" , ", A));
            Console.WriteLine("] ");
            for (int i = 0; i < B.Length; i++)//crea vector B
            {
                Console.ForegroundColor = ConsoleColor.Red;//cambia de color las letras
                B[i] = aleatorio.Next(20);
            }
            Console.WriteLine();
            Console.Write("  B = [");
            Console.Write(string.Join(" , ", B));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para continar y mostrar los vectores Ordenados .....");
            Console.BackgroundColor = ConsoleColor.White;//cambia de color el fondo
            Console.ForegroundColor = ConsoleColor.Black;//cambia de color las letras
            Console.ReadKey();
            Console.Clear();//coloco este limpiador para poder habilita el nuevo color de fondo de la consola
            Console.WriteLine(" . Vectores ordenados ");
            Console.WriteLine("   ___________________");
            Console.ForegroundColor = ConsoleColor.Red;//cambia de color las letras
            Array.Sort(A);//ordena el vector A de menor a mayor
            Console.WriteLine();
            Console.Write("  A = [");
            Console.Write(string.Join(" , ", A));
            Console.WriteLine("] ");
            Array.Sort(B);//ordena vector B de menor a mayor
            Console.WriteLine();
            Console.Write("  B = [");
            Console.Write(string.Join(" , ", B));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;//cmabia de color el fondo
            Console.ForegroundColor = ConsoleColor.Black;//cambia de color la letras
            Console.WriteLine(" . Vector C [tamA + tamB] Ordenado  ");
            Console.WriteLine("   ________________________________");
            Console.WriteLine();
            Array.Sort(C);//ordena vector C de menor a mayor
            Console.Write("  C = [");
           
            for (int i = 0; i < C.Length; i++)//crea el vector C
            {
                int a = 0, b = 0;

                for (int c = 0; c < C.Length; c++)
                {
                    if (a < A.Length && (b >= B.Length || A[a] < B[b]))
                    {
                        C[c] = A[a];
                        a++;
                    }
                    else
                    {
                        C[c] = B[b];

                        b++;
                    }
                }
            }
            Console.Write(string.Join(" , ", C));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();//limpia la pantalla para indica el fin del programa
            Console.ForegroundColor = ConsoleColor.Black;//cambia de color las letras
            Console.WriteLine("     ********************");
            Console.WriteLine("     | Fin  del proceso |");
            Console.WriteLine("     ********************");
            Console.ReadKey();
        }
    }
}
