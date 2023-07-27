using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        public static int Menu()
        {
            int opciones = 0;
            Console.WriteLine();
            Console.WriteLine(" ---------------------------------------------------------------------");
            Console.WriteLine(" | MENU - Gestion de Matriz de Filas X Columnas elementos aleatorios |");
            Console.WriteLine(" ---------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1  - Establecer Filas y Columnas");
            Console.WriteLine(" 2  - Generar la Matriz");
            Console.WriteLine(" 3  - Generar la Matriz entre un minimo y maximo");
            Console.WriteLine(" 4  - Mostrar Matriz");
            Console.WriteLine(" 5  - Contar target y destacar con color");
            Console.WriteLine(" 6  - Sumatoria");
            Console.WriteLine(" 7  - Promedio");
            Console.WriteLine(" 8  - Porcentaje de pares e impares");
            Console.WriteLine(" 9 -  Determinacion del Maximo valor");
            Console.WriteLine(" 10 - Determinacion del Minimo valor");
            Console.WriteLine(" 11 - Fila de Sumatoria Maxima");
            Console.WriteLine(" 12 - Columna de Sumatoria Maxima");
            Console.WriteLine(" 0  - Salir");
            Console.WriteLine();
            Console.Write(" Opcion elegida : ");
            opciones = Int32.Parse(Console.ReadLine());
            return opciones;

        }

        public static void GenerarMatriz(int[,] Matriz1, int filas1, int columnas1)
        {
            int num = 0;
            Console.Write(" ");
            Random aleatorio = new Random();
            for (int f = 0; f < filas1; f++)
            {               
                Console.WriteLine();
                for (int c = 0; c < columnas1; c++)
                {
                    num = aleatorio.Next(100);
                    Matriz1[f, c] = num;
                   // Console.Write($"  {Matriz1[f,c]} ");
                }
            }
        }

        public static void GenerarMatrizAleatoria(int[,] Matriz1, int filas1, int columnas1, int minimo, int maximo)
        {
            int num = 0;
            Console.Write(" ");
            Random aleatorio = new Random();

            for (int f = 0; f < filas1; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < columnas1; c++)
                {
                    num = aleatorio.Next(minimo, maximo);
                    Matriz1[0, 0] = minimo;
                    Matriz1[filas1 -1, columnas1-1] = maximo;
                    if (Matriz1[f, c]!=minimo && Matriz1[f, c] !=maximo)
                    {
                        Matriz1[f, c] = num;
                    }
                    // Console.Write($"  {Matriz1[f,c]} ");
                }
            }
        }

         public static void MostrarMatriz(int[,] Matriz1, int filas1, int columnas1)//muestra el vector generado aleatorio
         {
            for (int f = 0; f < filas1; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < columnas1; c++)
                {
                    Console.Write($"  {Matriz1[f, c]} ");
                    // Console.Write($"  {Matriz1[f,c]} ");
                }
            }
        }

        public static int Buscartarget(int[,] Matriz, int filas, int columnas, int target)
        {
            int contador = 0;

            for (int f = 0; f < filas; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < columnas; c++)
                {
                    // Console.WriteLine();
                    if (target == Matriz[f, c])
                    {
                        contador++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        //Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"  {Matriz[f, c]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {

                        Console.Write($"  {Matriz[f, c]} ");
                    }
                }
            }
            Console.WriteLine();
            if (contador > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} se encuentra presente {contador} veces ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} No se encuntra presente");
            }
            Console.WriteLine();
            return contador;

        }
        public static int SumatoriaMatriz(int[,] Matriz, int fila, int columna)// suma los elementos del vector
        {
            int suma = 0;
            suma = 0;
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    suma += Matriz[f,c];
                }
            }
            return suma;
        }

        public static double CalcularPromedio(int[,] Matriz, int fila, int columna)//calculo del promedio de la Matriz
        {
            double promedio = 0.0;
            int sumatotal = 0;
            int contador = 0;
            sumatotal = 0;
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                  sumatotal += Matriz[f,c];
                  contador++;
                }
                
            }

            promedio = (double)sumatotal / contador;

            return promedio;
        }

        public static void PorcentajeParImpar(int[,] Matriz, int filas, int columnas)
        {

            int par = 0;
            int impar = 0;
            int sumatotal = 0;
            double porcentajePar = 0.0;
            double porcentajeImpar = 0.0;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (Matriz[f,c] % 2 == 0)
                    {
                        par++;

                    }
                    else
                    {
                        impar++;

                    }
                }
            }
            sumatotal = par + impar;
            Console.WriteLine(" . Suma Total = " + sumatotal);
            Console.WriteLine(" . Total de pares = " + par);
            Console.WriteLine(" . Total de impares = " + impar);

            porcentajePar = (par * 100) / sumatotal;

            porcentajeImpar = (impar * 100) / sumatotal;
            Console.WriteLine();
            Console.WriteLine($" . Porcentaje de Pares = {porcentajePar} %");
            Console.WriteLine();
            Console.WriteLine($" . Porcentaje de Impares = {porcentajeImpar} %");
            Console.WriteLine();
        }
       public static int Maximo(int[,] Matriz, int fila, int columna)
        {
            int maximo = 0;
            maximo = int.MinValue;
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    if (Matriz[f,c] > maximo)
                    {
                        maximo = Matriz[f,c];
                    }
                }
            }
            return maximo;
        }
        public static int Minimo(int[,] Matriz, int fila, int columna)
        {
            int minimo = 0;
            minimo = int.MaxValue;
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    if (Matriz[f,c] < minimo)
                    {
                        minimo = Matriz[f,c];
                    }
                }
            }
            return minimo;
        }

       public static void SumatoriaMaxFilas(int[,] Matriz, int filas, int columnas)
        {
            int[] vectFilas = new int[filas];
            int SumaFilasMax = 0;
            Console.WriteLine();
            MostrarMatriz(Matriz, filas, columnas);
            Console.WriteLine();
            Console.WriteLine();
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    vectFilas[f] += Matriz[f,c];//este vector guarda en cada una de sus posiciones la sumatoria de cada fila por separado
                    //Console.WriteLine($" vector {vectFilas[f]}  fila {f}  Matriz {Matriz[f,c]}");
                }
            }
            for (int f= 0; f < filas - 1; f++)
            {
                if (vectFilas[f] > vectFilas[f + 1])
                {
                    SumaFilasMax = vectFilas[f];
                    //Console.WriteLine($"{vectFilas[f]}");
                }
                else
                {
                    SumaFilasMax = vectFilas[f+1];
                    //Console.WriteLine($"{vectFilas[f+1]}");
                }
            }
            Console.WriteLine($" Fila de Sumatoria Máxima = {SumaFilasMax}");            
        }
        public static void SumatoriaMaxColumnas(int[,] Matriz, int filas, int columnas)
        {
            int[] vectColumnas = new int[columnas];
            int SumaColumnasMax = 0;
            Console.WriteLine();
            MostrarMatriz(Matriz, filas, columnas);
            Console.WriteLine();
            Console.WriteLine();
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    vectColumnas[c] += Matriz[f, c];//este vector guarda en cada una de sus posiciones la sumatoria de cada columna por separado
                    //Console.WriteLine($" vector {vectColumnas[c]}  columna {c}  Matriz {Matriz[f,c]}");
                }
            }
            for (int c = 0; c < columnas - 1; c++)
            {
                if (vectColumnas[c] > vectColumnas[c + 1])
                {
                    SumaColumnasMax = vectColumnas[c];
                    //Console.WriteLine($"{vectColumnas[c]}");
                }
                else
                {
                    SumaColumnasMax = vectColumnas[c + 1];
                    //Console.WriteLine($"{vectColumnas[c+1]}");
                }
            }
            Console.WriteLine($" Columna de Sumatoria Máxima = {SumaColumnasMax}");


        }

        static void Main(string[] args)
        {
            int opcion = 0;
            int[,] Matriz = new int[100,100];
            int filas = 0;
            int columnas = 0;
            double prom = 0.0;
            int resultadoSuma = 0;
            int max = 0;
            int min = 0;
            int minimo = 0;
            int maximo = 0;
            int target = 0;
            // Situacion inicial por defecto
            filas = 5;
            columnas = 5;
            GenerarMatriz(Matriz, filas, columnas);//esta es la funcion que genera una Matriz de Filas X Columnas o en el caso seria de 25 elementos
                                              //con esta funcion me aseguro poder navegar por todas las otra opcionescon una Matriz generada
            do
            {
                Console.Clear();
                opcion = Menu();
                Console.Clear();

                switch (opcion)
                {
                    case 1://No llama ninguna funcion, interactua con el usuario solicitando ingresar numero
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine(" |Establecer Filas y Columnas|");
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine();

                            Console.Write(" Ingrese valor de Filas = ");
                            filas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write(" Ingrese valor de Columnas = ");
                            columnas = Int32.Parse(Console.ReadLine());
                            while ((filas < 1) || (filas > 100) && (columnas < 1) || (columnas > 100))
                            {
                                Console.WriteLine(" . Error. (filas debe estar entre 1 y 100)");
                                Console.WriteLine();
                                Console.Write(" Ingrese valor de Filas = ");
                                filas = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(" . Error. (columnas debe estar entre 1 y 100)");
                                Console.WriteLine();
                                Console.Write(" Ingrese valor de Columnas = ");
                                columnas = Int32.Parse(Console.ReadLine());
                            }

                            Console.WriteLine();//cuando se ingresa valores dentro del rango solicitado
                            Console.WriteLine($" . Se establecio correctamente Filas en {filas}");
                            Console.WriteLine($" . Se establecio correctamente Columnas en {columnas}");
                            break;
                        }

                    case 2://llama a la funcion de generador de la Matriz
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -------------------");
                            Console.WriteLine(" |Generar la Matriz|");
                            Console.WriteLine(" -------------------");
                            Console.WriteLine();
                            GenerarMatriz(Matriz, filas, columnas);
                            Console.WriteLine();
                            Console.WriteLine($" . Se genero correctamente la Matriz de filas = {filas} X Columnas = {columnas} .");
                            break;
                        }

                    case 3://Genera la Matriz entre un minimo y un maximo
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ---------------------------------------------------------");
                            Console.WriteLine("Generar una Matriz aleatorio entre un valor minimo y maximo");
                            Console.WriteLine(" ---------------------------------------------------------");
                            Console.WriteLine();
                            Console.Write(" Ingresar el valor minimo que desea en la Matriz = ");
                            minimo = Int32.Parse(Console.ReadLine());
                            Console.Write(" Ingresar el valor maximo que desea en la Matriz = ");
                            maximo = Int32.Parse(Console.ReadLine());
                            GenerarMatrizAleatoria(Matriz, filas, columnas, minimo, maximo);//funcion aleatorio de la Matriz

                            Console.WriteLine();
                            Console.WriteLine($" . Se genero correctamente la Matriz que continene a sus elmentos entre {minimo} y {maximo} .");

                            break;
                        }

                    case 4://llama la funcion para mostrar la Matriz
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" --------------");
                            Console.WriteLine(" Mostrar Matriz");
                            Console.WriteLine(" --------------");
                            Console.WriteLine();

                            Console.WriteLine();
                            MostrarMatriz(Matriz, filas, columnas);
                            break;

                        }

                    case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -------------------");
                            Console.WriteLine(" Buscador del target");
                            Console.WriteLine(" -------------------");
                            Console.WriteLine();
                            Console.Write(" Ingresar valor de target que desea Buscar = ");
                            target = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Buscartarget(Matriz, filas, columnas, target);
                            //Console.WriteLine($" Aparece {} veces");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ---------------------------------------");
                            Console.WriteLine(" Sumatoria de los elementos de la Matriz");
                            Console.WriteLine(" ---------------------------------------");
                            Console.WriteLine();

                            resultadoSuma = SumatoriaMatriz(Matriz, filas, columnas);
                            Console.WriteLine();
                            Console.WriteLine($" . Suma: {resultadoSuma}");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" --------------------");
                            Console.WriteLine(" Calculo del promedio");
                            Console.WriteLine(" --------------------");
                            Console.WriteLine();

                            prom = CalcularPromedio(Matriz, filas, columnas);
                            Console.WriteLine();
                            Console.WriteLine($" . Promedio: {prom.ToString("0.00")}");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine(" Porcentaje de pares e impares");
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine();

                            PorcentajeParImpar(Matriz, filas, columnas);

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine(" Determinacion del Maximo Valor");
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine();

                            max = Maximo(Matriz, filas, columnas);
                            Console.WriteLine($" El maximo = {max}");
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine(" Determinacion del Minimo Valor");
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine();
                            min = Minimo(Matriz, filas, columnas);
                            Console.WriteLine($" El minimo = {min}");

                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ------------------------");
                            Console.WriteLine(" Fila de Sumatoria Maxima");
                            Console.WriteLine(" ------------------------");
                            Console.WriteLine();
                            SumatoriaMaxFilas(Matriz, filas, columnas);

                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ---------------------------");
                            Console.WriteLine(" Columna de Sumatoria Maxima");
                            Console.WriteLine(" ---------------------------");
                            Console.WriteLine();

                            SumatoriaMaxColumnas(Matriz, filas, columnas);

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

                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
