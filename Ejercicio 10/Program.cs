using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ============================");
            Console.WriteLine(" |Generacion de Plan de Pago| ");
            Console.WriteLine(" ============================");
            Console.WriteLine();
            int valorVenta = 0;
            int cantCuotas = 0;
            double interes = 0;
            int decreciente = 0;
            int contador = 1;
            Console.WriteLine();
            Console.WriteLine(" Opciones en Cuotas");
            Console.WriteLine(" ------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" . 1 Cuota - Son 10% de Descuento");
            Console.WriteLine(" . 3 Cuota - No se aplica interes");
            Console.WriteLine(" . 6 Cuotas - Se aplica un interés del 17%");
            Console.WriteLine(" . 12 Cuotas -  Se aplica un interés del 25%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.Write(" Ingresar de Ventas = $");
            valorVenta = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Ingresar Cantidad de Cuotas = ");
            cantCuotas = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            if (cantCuotas == 1)
            {
                interes = 90 / 100;
            }
            if (cantCuotas == 3)
            {
                interes = 1;
            }
            if (cantCuotas == 6)
            {
                interes = 117 / 100;
            }
            if (cantCuotas == 12)
            {
                interes = 125 / 100;
            }
            decreciente = cantCuotas;
            double[,] PlanPago = new double[cantCuotas, 4];
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   ________________________________________________________");
            Console.WriteLine("  | N° Cuota |  Valor Cuota  |    Pagado     |    Saldo   |");
            Console.WriteLine("   ________________________________________________________");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int f = 0; f < cantCuotas; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < 4; c++)
                {
 
                    if (c == 0)
                    {
                       PlanPago[f,0] = contador;
                    }
                    if (c == 1)
                    {
                        PlanPago[f, 1] = (valorVenta * interes) / cantCuotas;
                    }
                    if (c == 2)
                    {
                        PlanPago[f, 2] = ((valorVenta * interes) / cantCuotas) * contador;
                    }
                    if (c == 3)
                    {
                        PlanPago[f, 3] = valorVenta - ((valorVenta * interes) / cantCuotas) * contador;

                    }
                    if (c == 0)
                    {
                       
                        Console.Write($"  |    {PlanPago[f, c]}  ");
                        
                    }
                    else
                    {
                        if (c == 3)
                        {
                            if (f == cantCuotas -1)
                            {
                                Console.Write($"  |    ${PlanPago[cantCuotas - 1, 3]:F2}   |");
                            }
                            else
                            {
                                Console.Write($"   |  ${PlanPago[f, 3]:F2}  |");
                            }

                        }
                        else
                        {
                            Console.Write($"   |  ${PlanPago[f, c]:F2}  ");
                        }
                    
                    }
                   
                }
                contador++;
                decreciente--;
            }
            Console.WriteLine();
            Console.WriteLine("   ________________________________________________________");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ===================");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ===================");
            Console.ReadKey();
            }
        }
    }

