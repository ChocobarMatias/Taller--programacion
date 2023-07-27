using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
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
        public static int Menu()
        {
            int opciones = 0;
            Console.WriteLine();
            Console.WriteLine(" =========================================");
            Console.WriteLine(" | Bienvenido al Menu de la Sangucheria  |");
            Console.WriteLine(" =========================================");
            Console.WriteLine();
            Console.WriteLine(" 1 - Milanesa");
            Console.WriteLine(" 2 - Hamburguesa");
            Console.WriteLine(" 3 - Lomito");
            Console.WriteLine(" 0 - Salir");
            Console.WriteLine();

            Console.Write(" Opcion elegida : ");
            opciones = Int32.Parse(Console.ReadLine());
            return opciones;// retorna el numero que se ingreso por teclado
        }
            static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ===========================================");
            Console.WriteLine(" Sangucheria : Milanesa, Hamburguesa, Lomito");
            Console.WriteLine(" ===========================================");
            Console.WriteLine();
            string[] sangu = { "Milanesa", "Hamburguesa", "Lomito" };
            double[] precio = {1000, 900, 1100};
            double[] recaudacion = new double[3];
            double[] porcentaje = new double[3];
            double[] cantidad = new double[3];
            double recaudaciontotal = 0;
            int opcion = 0;
            int milaVenta = 0;//ventas que se realiza en la opcion de milanesas
            int milatotal = 0;//acumulador de ventas milanesa 
            int hamburVenta = 0;
            int hamburtotal = 0;
            int lomitoVenta = 0;
            int lomitototal = 0;

            do {
                Console.Clear();
                opcion = Menu();
                Console.Clear();

                switch (opcion)
            {
                case 1: {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;//cambia de color las letras
                            Console.WriteLine(" ==============================");
                            Console.WriteLine(" Ventas de Sanguche de Milanesa");
                            Console.WriteLine(" ==============================");
                            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
                            Console.WriteLine();
                            Console.Write(" Cuantos Sanguches de Milanesa vendio = ");
                            milaVenta = Int32.Parse(Console.ReadLine());
                            milatotal += milaVenta;
                            
                            break;
                        }
                case 2: {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;//cambia de color las letras
                            Console.WriteLine(" =================================");
                            Console.WriteLine(" Ventas de Sanguche de Hamburguesa");
                            Console.WriteLine(" =================================");
                            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
                            Console.WriteLine();
                            Console.Write(" Cuantos Sanguches de Hamburguesa vendio = ");
                            hamburVenta = Int32.Parse(Console.ReadLine());
                            hamburtotal += hamburVenta;
                            break;
                        }
                case 3: {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;//cambia de color las letras
                            Console.WriteLine(" ==============================");
                            Console.WriteLine(" Ventas de Sanguche de Lomito");
                            Console.WriteLine(" ==============================");
                            Console.ForegroundColor = ConsoleColor.White;//cambia de color las letras
                            Console.WriteLine();
                            Console.Write(" Cuantos Sanguches de Lomito vendio = ");
                            lomitoVenta = Int32.Parse(Console.ReadLine());
                            lomitototal += lomitoVenta;
                            break;
                        }
                case 0: {
                            Console.WriteLine(" Fin de la carga, hasta luego....");
                            
                            break;
                            
                        }
                    default:
                        {
                            Console.BackgroundColor = ConsoleColor.White;//cmabia de color el fondo
                            Console.ForegroundColor = ConsoleColor.Black;//cambia de color las letras
                            Console.WriteLine(" Opcion incorrecta...");
                            break;
                        }
                }
            } while (opcion != 0);

            //Console.Clear();

            for (int i = 0; i < cantidad.Length; i++)//llena el vector cantidad de sanguches posicion 1 mila, posicion 2 hamburguesa, posicion 3 lomito
            {
                Console.Write($" Ingresar cantidad de {sangu[i]} vendidos = ");
                if (i == 0 )
                {
                    cantidad[i] = milatotal;
                }
                if (i == 1)
                {
                    cantidad[i] = hamburtotal;
                }
                if (i == 2)
                {
                    cantidad[i] = lomitototal;
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < recaudacion.Length; i++)
            {
                recaudacion[i] = precio[i] * cantidad[i];
                recaudaciontotal += recaudacion[i]; 
            }
            Console.WriteLine();
            for (int i = 0; i < porcentaje.Length; i++)
            {
                porcentaje[i] = (recaudacion[i] * 100) / recaudaciontotal;
               
            }
           
            Console.BackgroundColor = ConsoleColor.White;//cmabia de color el fondo
            Console.ForegroundColor = ConsoleColor.Black;//cambia de color las letras
            Console.Clear();
            Console.WriteLine();
            Console.Write(" Sanguches = [");
            Console.Write(string.Join(" , ", sangu));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.Write(" Precios = [$");
            Console.Write(string.Join(" , $", precio));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.Write(" Cantidad Vendida = [");
            Console.Write(string.Join(" , ", cantidad));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.Write(" Recaudacion = [$");
            Console.Write(string.Join(" , $", recaudacion));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.Write(" Porcentaje = [");
            for (int i = 0; i < porcentaje.Length; i++)
            {
                Console.Write($"{porcentaje[i]:F2} %"); // Redondear a 2 decimales
                if (i < porcentaje.Length - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine($" La recaudacion total fue : ${recaudaciontotal}");
            Console.BackgroundColor = ConsoleColor.White;//cmabia de color el fondo
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();//limpia la pantalla para indica el fin del programa
            Console.ForegroundColor = ConsoleColor.Black;//cambia de color las letras
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     ********************");
            Console.WriteLine("     | Fin  del proceso |");
            Console.WriteLine("     ********************");
            Console.ReadKey();
        }
    }
}
