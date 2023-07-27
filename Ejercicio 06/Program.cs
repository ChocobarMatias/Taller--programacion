using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        public static int Menu()
        {
            int opciones = 0;
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------------------------");
            Console.WriteLine(" | MENU - Gestion de Vector de N elementos aleatorios |");
            Console.WriteLine(" ------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1  - Establecer N");
            Console.WriteLine(" 2  - Generacion de Vector de forma aleatoria");
            Console.WriteLine(" 3  - Generacion del vector entre un minimo y maximo");
            Console.WriteLine(" 4  - Mostrar Vector");
            Console.WriteLine(" 5  - Buscar target");
            Console.WriteLine(" 6  - Contar target");
            Console.WriteLine(" 7  - Sumatoria");
            Console.WriteLine(" 8  - Promedio");
            Console.WriteLine(" 9  - Porcentaje de pares e impares");
            Console.WriteLine(" 10 - Determinacion del Maximo valor");
            Console.WriteLine(" 11 - Determinacion del Minimo valor");
            Console.WriteLine(" 12 - Ordenar");
            Console.WriteLine(" 13 - Mezclar");
            Console.WriteLine(" 0  - Salir");
            Console.WriteLine();
            Console.Write(" Opcion elegida : ");
            opciones = Int32.Parse(Console.ReadLine());
            return opciones;

        }
       

        public static void GenerarVector(int[] vectornuevo, int num)
        {
            Random elemento = new Random();
            for (int i = 0; i < num; i++)
            {
                vectornuevo[i] = elemento.Next(100);
                
            }

        }

        public static void GenerarVectorAleatorio(int[] vector1, int num1, int minimo,int maximo)//genera el vector de forma aleatoria para no estar solicitando ingreso de valores 
        {
            Random aleatorio = new Random();

            vector1[0] = minimo;
            vector1[num1-1] = maximo;
            for (int i = 0; i < num1; i++)
            {
                          
                if (i > 0 && i < num1-1)
                {
                  vector1[i] = aleatorio.Next(minimo,maximo);
                }
               
            } Console.Write($" {vector1[num1-1]}, ");
        }

        public static void MostrarVector(int[] vector2, int num2)//muestra el vector generado aleatorio
        {

            Console.Write(" Vector = [");
            for (int i = 0; i < num2; i++)
            {

                if (i < num2 - 1)
                {
                    Console.Write($" {vector2[i]}, ");
                }
                else
                {
                    Console.Write($" {vector2[i]}");
                }
            }
            Console.WriteLine(" ] ");
        }

        public static double CalcularPromedioVector(int[] vector3, int num3)//calculo del promedio del vector
        {
            double promedio = 0.0;
            int sumatotal = 0;

            sumatotal = 0;
            for (int i = 0; i < num3; i++)
            {
                sumatotal = sumatotal + vector3[i];
            }

            promedio = (double)sumatotal / num3;

            return promedio;
        }


        public static int SumarVector(int[] vector4, int num4)// suma los elementos del vector
        {
            int suma = 0;

            suma = 0;
            for (int i = 0; i < num4; i++)
            {
                suma = suma + vector4[i];
            }

            return suma;
        }

        public static int Buscartarget(int[] vector5, int num5, int target)
        {
            
            int contador = 0;

            for (int i = 0; i < num5; i++)
            {

                if (target == vector5[i])
                {
                    contador++;
                }

            }
            Console.WriteLine();
            if (contador > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} se encuentra presente");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} No se encuntra presente");
            }
            Console.WriteLine();
            return target;

        }

        public static void ContarTarget(int[] vector5, int num5, int target)
        {
            int contador = 0;
       
            for (int i = 0; i < num5; i++)
            {
                if (target == vector5[i])
                {
                    contador++;
                }
            }
            Console.WriteLine();
            if (contador > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} se encuentra presente {contador} veces");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" El target = {target} No se encuntra presente y aparece {contador} veces");
            }
            Console.WriteLine();
          
        }

        public static void PorcentajeParImpar(int[] vector6, int num6)
        {

            int par = 0;
            int impar = 0;
            int sumatotal = 0;
            double porcentajePar = 0.0;
            double porcentajeImpar = 0.0;


            for (int i = 0; i < num6; i++)
            {
                if (vector6[i] % 2 == 0)
                {
                    par++;

                }
                else
                {
                    impar++;

                }
            }

            sumatotal = par + impar;
            Console.WriteLine(" . Total de elementos = " + sumatotal);
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
        public static int Maximo(int[] vector7, int num7)
        {
            int maximo = 0;
            maximo = int.MinValue;
            for (int i = 0; i < num7; i++)
            {
                if (vector7[i] > maximo)
                {
                    maximo = vector7[i];
                }
            }

            return maximo;
        }
        public static int Minimo(int[] vector8, int num8)
        {
            int minimo = 0;
            minimo = int.MaxValue;
            for (int i = 0; i < num8; i++)
            {
                if (vector8[i] < minimo)
                {
                    minimo = vector8[i];
                }
            }

            return minimo;
        }

        public static void Ordenar(int[] vector9, int num9)
        {
            int aux = 0;

            Console.Write(" Vector = [");
            for (int i = 0; i < num9; i++)
            {
                for (int j = 0; j < num9 - 1; j++)
                {
                    if (vector9[j] > vector9[j + 1])
                    {
                        aux = vector9[j];
                        vector9[j] = vector9[j + 1];
                        vector9[j + 1] = aux;
                    }
                }
                if (i < num9 - 1)
                {
                    Console.Write($" {vector9[i]}, ");
                }
                else
                {
                    Console.Write($" {vector9[i]}");
                }
            }
            Console.WriteLine(" ] ");
        }
        public static void Mezclar(int[] vector10, int num10)
        {
            int j = 0;
            int h = 0;
           // int contador = 0;
            int aux = 0;
            Console.Write(" Vector = [");
            Random aleatorio = new Random();
            for (int i = 0; i < num10; i++)
            {
                j = aleatorio.Next(num10);
                h = aleatorio.Next(num10);
    
                for (int k = 0; k < (num10 - 1); k++)
                {
                    //uso los terminos de j y h para realizar los cambio de posisicones del vector reemplazndo esto
                    if (vector10[j] > vector10[h])
                    {
                        aux = vector10[j];
                        vector10[j] = vector10[h];
                        vector10[h] = aux;
                    }
                }
                    if (i < num10 - 1)
                    {
                        Console.Write($" {vector10[i]}, ");
                    }
                    else
                    {
                        Console.Write($" ,{vector10[i]}");
                    }

            }
            Console.WriteLine(" ] ");
        }

        static void Main(string[] args)
            {
                int opcion = 0;
                int[] vector = new int[20];
                int N = 0;
                double prom = 0.0;
                int resultadoSuma = 0;
                int max = 0;
                int min = 0;
                int target = 0;
                int minimo = 0;
                int maximo = 0;
                // Situacion inicial por defecto
                N = 10;//colocando este valor a N antes de entrar a switch  aseguro poder naver por todas la opciones inclusin pasar por la primera (opcion 1)
                GenerarVector(vector, N);//esta es la funcion que genera un vector de n elementos o en el caso seria de 10 elementos
            //con esta funcion me aseguro poder navegar por todas las otra opcionescon una vector generado
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
                            Console.WriteLine(" --------------");
                            Console.WriteLine(" |Establecer N|");
                            Console.WriteLine(" --------------");
                            Console.WriteLine();


                            //Console.WriteLine($" valor de N = {N}");

                            Console.Write(" Ingrese valor N = ");
                                N = Int32.Parse(Console.ReadLine());

                                while ((N < 1) || (N > 100))//para los valores que esten fuera del rango del vector lanza mensaje de error y solicta ingresar de nuevo
                                {
                                    Console.WriteLine(" . Error. (N debe estar entre 1 y 100)");
                                    Console.WriteLine();
                                    Console.Write(" Ingrese valor N = ");
                                    N = Int32.Parse(Console.ReadLine());
                                }

                                Console.WriteLine();//cuando se ingresa valores dentro del rango solicitado
                                Console.WriteLine($" . Se establecio correctamente N en {N}");
                                break;
                            }

                        case 2://llama a la funcion de generador del vector
                            {
                                Console.WriteLine();
                            Console.WriteLine(" -------------------------");
                            Console.WriteLine(" |Generacion de un Vector|");
                            Console.WriteLine(" -------------------------");
                            Console.WriteLine();

                            //Console.WriteLine($" valor de N = {N}");

                            GenerarVector(vector, N);//funcion aleatorio de vectores

                                Console.WriteLine();
                                Console.WriteLine($" . Se genero correctamente el vector con {N} elementos.");
                                break;
                            }

                        case 3://Genera el vector entre un minimo y un maximo
                            {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(" ---------------------------------------------------------");
                            Console.WriteLine("Generar un Vector aleatorio entre un valor minimo y maximo");
                            Console.WriteLine(" ---------------------------------------------------------");
                            Console.WriteLine();

                            //Console.WriteLine($" valor de N = {N}");
                            Console.Write(" Ingresar el valor minimo que desea el vector = ");
                            minimo = Int32.Parse(Console.ReadLine());
                            Console.Write(" Ingresar el valor maximo que desea el vector = ");
                            maximo = Int32.Parse(Console.ReadLine());
                            GenerarVectorAleatorio(vector, N, minimo, maximo);//funcion aleatorio de vectores

                            Console.WriteLine();
                            Console.WriteLine($" . Se genero correctamente el vector con {N} elementos.");

                            break;
                            }

                        case 4://llama la funcion para mostrar al vector
                        {
                            Console.WriteLine();
                            Console.WriteLine($" . Mostrar Vector ({N} elementos)");

                            Console.WriteLine();
                            MostrarVector(vector, N);
                            break;
                            
                        }

                        case 5://llama la funcion busqueda de target
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ---------------------");
                            Console.WriteLine(" Busqueda de un target");
                            Console.WriteLine(" ---------------------");
                            Console.WriteLine();
                            Console.Write(" Ingrese el Target que desea buscar = ");
                            target = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Buscartarget(vector,N, target);
                            Console.WriteLine();

                            break;
                        }
                        case 6:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -------------------");
                            Console.WriteLine(" Contador del target");
                            Console.WriteLine(" -------------------");
                            Console.WriteLine();
                            
                            Console.WriteLine();
                            // Buscartarget(vector, N);
                            ContarTarget(vector, N,target);
                            
                            //Console.WriteLine($" Aparece {} veces");
                            break;
                        }
                       case 7:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -------------------------------------");
                            Console.WriteLine(" Sumatoria de los elementos del vector");
                            Console.WriteLine(" -------------------------------------");
                            Console.WriteLine();

                            resultadoSuma = SumarVector(vector, N);
                            Console.WriteLine();
                            Console.WriteLine($" . Suma: {resultadoSuma}");
                            break;
                        }
                       case 8:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" --------------------");
                            Console.WriteLine(" Calculo del promedio");
                            Console.WriteLine(" --------------------");
                            Console.WriteLine();

                            prom = CalcularPromedioVector(vector, N);
                            Console.WriteLine();
                            Console.WriteLine($" . Promedio: {prom.ToString("0.00")}");
                            break;
                        }
                       case 9:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine(" Porcentaje de pares e impares");
                            Console.WriteLine(" -----------------------------");
                            Console.WriteLine();

                            PorcentajeParImpar(vector, N);

                            break;
                        }
                       case 10:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine(" Determinacion del Maximo Valor");
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine();
                            
                            max = Maximo(vector,N);
                            Console.WriteLine($" El maximo = {max}");
                            break;
                        }
                      case 11:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine(" Determinacion del Minimo Valor");
                            Console.WriteLine(" ------------------------------");
                            Console.WriteLine();
                            min = Minimo(vector, N);
                            Console.WriteLine($" El minimo = {min}");

                            break;
                        }
                      case 12:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" --------------------------------------------");
                            Console.WriteLine(" Odenar de menor a mayor elementos del Vector");
                            Console.WriteLine(" --------------------------------------------");
                            Console.WriteLine();
                            Ordenar(vector, N);

                            break;
                        }
                      case 13:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" -------------------------------");
                            Console.WriteLine(" Mezcla los elementos del Vector");
                            Console.WriteLine(" -------------------------------");
                            Console.WriteLine();

                            Mezclar(vector, N);

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
            