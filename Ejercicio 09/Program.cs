using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {

        public static int Menu()
        {
            int opciones = 0;
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine(" | MENU - Banco - Validacion de Cliente |");
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1  - DEPOSITO");
            Console.WriteLine(" 2  - EXTRACCION");
            Console.WriteLine(" 3  - SALDO");
            Console.WriteLine(" 4  - TRANSFERENCIA");
            Console.WriteLine(" 0  - Salir");
            Console.WriteLine();
            Console.Write(" Opcion elegida : ");
            opciones = Int32.Parse(Console.ReadLine());
            return opciones;

        }
        
        static void Main(string[] args)
        {
            //Numero de cliente son las columnas de la matriz
            //Fila 0 es la Clave numerica
            //Fila 1 es el Saldo
            int opcion = 0;
            int[,] Matriz = { { 4587, 3157, 5968, 3485, 1687 }, { 12000, 3500, 0, 14000, 15750 } };
            int[,] MatrizBanco = new int[2,5];
            int Cliente = 0;
            int Clave = 0;
            int intentos = 1;
            bool ingreso = false;
            int numeroCliente = 0;
            int claveCliente = 0;
            int saldo = 0;
            int intentoClave = 1;
            int deposito = 0;
            int extraccion = 0;
            int nuevoCliente = 0;
            int transferencia = 0;
            int nuevoSaldo = 0;
            Console.WriteLine();
            Console.WriteLine(" --------------");
            Console.WriteLine(" | Bienvenido |");
            Console.WriteLine(" --------------");
            Console.WriteLine();

            while (intentos < 3 && ingreso == false)
            {
                Console.Write(" Ingresar numero de Cliente : ");
                Cliente = Int32.Parse(Console.ReadLine());


                for (int f = 0; f < 2; f++)
                {
                    //Console.WriteLine();
                    for (int c = 0; c < 5; c++)
                    {
                        MatrizBanco[f,c] = Matriz[f,c];
                        if (Cliente == c)
                        {
                            numeroCliente = c;//auxiliar para comparar con numero de cliente
                            claveCliente = Matriz[0, c];//auxiliar para comparar con clave numerica
                            saldo = Matriz[1, c];//auxiliar con el saldo inicial
                        }
                       // Console.Write($" {Banco[f,c]} ");
                    }
                }
                              
                if (Cliente == numeroCliente)
                {
                    Console.Write(" Ingresar Clave Numerica : ");
                    Clave = Int32.Parse(Console.ReadLine());

                    if (Clave == claveCliente)
                    {
                        ingreso = true;
                    }
                    else
                    {
                        intentos++;//cuenta los intentos fallidos
                        intentoClave++;//comienzo a contar los errores en clave

                        if (intentoClave > 0 && intentos < 3)//es para solcitar clave cada vez
                        {                                         //que se la coloca mal 
                            Console.Clear();                 //limpio pantalla          
                            Console.WriteLine();
                            Console.WriteLine("  Datos incorrectos intente de nuevo");
                            Console.WriteLine("  ----------------------------------");
                            Console.WriteLine();
                            Console.Write("  Ingresar Clave : ");
                            Clave = Int32.Parse(Console.ReadLine());

                            if (Clave == claveCliente)
                            {
                                ingreso = true;
                            }
                            else
                            {

                                intentos++;//cuenta los intentos fallidos
                                intentoClave++;
                                if (intentoClave > 0 && intentos < 3)
                                {
                                    Console.Clear();                 //limpio pantalla          
                                    Console.WriteLine();
                                    Console.WriteLine("  Datos incorrectos intente de nuevo");
                                    Console.WriteLine("  ----------------------------------");
                                    Console.WriteLine();
                                    Console.Write("  Ingresar Clave : ");
                                    Clave = Int32.Parse(Console.ReadLine());
                                }
                            }
                        }
                        else//si detecta que los intentos son >= 3 sale del while
                        {
                            ingreso = true;
                        }

                    }
                }
                else//esto es para los intentos errados del numero de cliente
                {
                    intentos++;//cuanta los intentos fallidos

                    if (intentos < 3)//para los menos a 3 solicita ingresar nuevamente numero de cliente
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("  Datos incorrectos intente de nuevo");
                        Console.WriteLine("  ----------------------------------");
                        Console.WriteLine();
                        Console.Write("  Ingresar Numero de Cliente : ");
                        Cliente = Int32.Parse(Console.ReadLine());
                    }
                    else//Sale del while cuando coloca 3 veces mal el numero del cliente
                    {
                        ingreso = true;
                    }
                }
            }
                        if (intentos == 3)//Para 3 intentos fallidos muestra este mensaje
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("  Demasiados intentos fallidos");
                            Console.WriteLine();
                            Console.WriteLine("  Cuenta Bloqueda"); 
                        }

                if ((ingreso == true) && (Cliente == numeroCliente) && (Clave == claveCliente))
                {
                                do
                                {
                                    Console.Clear();
                                    opcion = Menu();
                                    Console.Clear();

                                    switch (opcion)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" ----------");
                                                Console.WriteLine(" |Deposito|");
                                                Console.WriteLine(" ----------");
                                                Console.WriteLine();
                                                Console.Write(" Ingrese el monto que depositara = $");
                                                deposito = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                MatrizBanco[1,numeroCliente] += deposito;
                                                Console.WriteLine($" El deposito de ${deposito} fue acreditado con exito en la cuenta del cliente {numeroCliente}");
                                                Console.WriteLine();
                                                Console.ReadKey();


                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" ------------");
                                                Console.WriteLine(" |Extraccion|");
                                                Console.WriteLine(" ------------");
                                                Console.WriteLine();
                                                Console.Write(" Ingrese el monto que extraera = $");
                                                extraccion = Int32.Parse(Console.ReadLine());
                                                MatrizBanco[1,numeroCliente] -= extraccion;
                                                //Extraccion(Nueva, numeroCliente, saldo, extraccion);
                                                Console.WriteLine();
                                                Console.WriteLine($" Extrajo ${extraccion} con exito de la cuenta del cliente {numeroCliente}");
                                                Console.WriteLine();
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" -------------------");
                                                Console.WriteLine(" |Consulta de Saldo|");
                                                Console.WriteLine(" -------------------");
                                                Console.WriteLine();
                                                
                                                saldo = MatrizBanco[1,numeroCliente];
                                                Console.WriteLine();
                                                Console.WriteLine($"Cliente {numeroCliente}, Su saldo es = ${saldo}");
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" ---------------");
                                                Console.WriteLine(" |Transferencia|");
                                                Console.WriteLine(" ---------------");
                                                Console.WriteLine();
                                                Console.Write(" Ingresar el Numero del Cliente aquien transferir = ");
                                                nuevoCliente = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.Write(" ¿Cuanto dinero quieres transferir? = $");
                                                transferencia = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                MatrizBanco[1,numeroCliente] -= transferencia;
                                                if (MatrizBanco[1, numeroCliente] < 0)
                                                 {
                                                Console.WriteLine(" Saldo Insuficiente");
                                                
                                                 }
                                                else
                                                {
                                                MatrizBanco[1, nuevoCliente] += transferencia;
                                                nuevoSaldo = MatrizBanco[1, nuevoCliente];
                                                Console.WriteLine();
                                                Console.WriteLine($" Cliente {numeroCliente} realizo Transferencia de ${transferencia} al cliente {nuevoCliente}");
                                                Console.WriteLine();
                                                Console.WriteLine($" Saldo del Cliente {numeroCliente} - ${saldo}");
                                                Console.WriteLine();
                                                Console.WriteLine($" Cliente {nuevoCliente} recibio una Transferencia de ${transferencia}");
                                                Console.WriteLine();
                                                Console.WriteLine($" Nuevo saldo ${nuevoSaldo} del cliente {nuevoCliente}");
                                                }
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 0:
                                            {

                                                Console.WriteLine();
                                                Console.WriteLine("***************");
                                                Console.WriteLine("Fin del proceso");
                                                Console.WriteLine("***************");
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Opcion incorrecta...");
                                                break;
                                            }

                                    } // switch

                                    

                                } while (opcion != 0);
                            }
            Console.ReadKey();
        }
                    }
                }
            
        
    


