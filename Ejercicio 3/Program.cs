using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Constante minimo y maximo con carga de numero N");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(" +++++");
            Console.WriteLine(" While");
            Console.WriteLine(" +++++");
            Console.WriteLine();
            int N = 0;
            int valorPar = 0;
            int valorImpar = 0;
            int porcentajePar = 0;
            int porcentajeImPar = 0;
            int centinela = 0;
            int suma = 0;
            const int maximo = 10;
            const int minimo = 1;
            centinela = 1;
            while (centinela != 0)
            {
                Console.Write(" Ingresar un numero = ");
                N = Int32.Parse(Console.ReadLine());
                
                if (N > minimo && N < maximo)
                {
                 
                    if (N % 2 == 0)
                    {
                        valorPar++;
                        
                    }
                    
                        if (N % 2 == 1)
                        {
                            valorImpar++;
                        
                        }
                   
                }
                if (N == 0)
                {
                    centinela = 0;
                }
            }
            suma = valorPar + valorImpar;
            porcentajeImPar = (valorImpar * 100 )/ suma;
            porcentajePar = (valorPar * 100) / suma; 
            Console.WriteLine();
            Console.WriteLine($" . Cantidad de valores Pares = {valorPar}");
            Console.WriteLine($" . Cantidad de valores ImPares = {valorImpar}");
            Console.WriteLine($" . Porcentaje de numeros pares = {porcentajePar} %");
            Console.WriteLine($" . Porcentaje de numeros impares = {porcentajeImPar} %");
            Console.WriteLine();
            Console.WriteLine(" ****************");
            Console.WriteLine(" Fin  del proceso");
            Console.WriteLine(" ****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
