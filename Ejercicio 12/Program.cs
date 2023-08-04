using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" =========================================");
            Console.WriteLine(" Puesto de peaje registro de los vehículos");
            Console.WriteLine(" =========================================");
            Console.WriteLine();
            Console.WriteLine(" . Los valores que se cobran a cada vehículo son: ");
            Console.WriteLine(" -------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" . Código 1: Autos: $150");
            Console.WriteLine(" . Código 2: Camionetas: $200");
            Console.WriteLine(" . Código 3: Camiones: $320");
            //● Código 1: Autos: $150
            //● Código 2: Camionetas: $200
            //● Código 3: Camiones: $320
            int vehiculo = 0;
            const int auto = 150;
            const int camioneta = 200;
            const int camion = 320;
            int cantAuto = 0;
            int cantCamioneta = 0;
            int cantCamion = 0;
            double TotalVehiculo = 0;
            double TotalRecaudado = 0;
            int recAuto = 0;
            int recCamioneta = 0;
            int recCamion = 0;
            double porcAuto = 0;
            double porcCamioneta = 0;
            double porcCamion = 0;
            double porcRecAuto = 0;
            double porcRecCamioneta = 0;
            double porcRecCamion = 0;
            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para Continuar ...");
            Console.ReadKey();
            Console.Clear();
            do
            {
                
                Console.WriteLine();
                Console.Write(" . Ingresar Tipo de Vehiculo = ");
                vehiculo = Int32.Parse(Console.ReadLine());

                if (vehiculo == 1)
                {
                    cantAuto++;
                }
                if (vehiculo == 2)
                {
                    cantCamioneta++;
                }
                if (vehiculo == 3)
                {
                    cantCamion++;
                }

            } while (vehiculo !=0);

            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para Continuar ...");
            Console.ReadKey();
            Console.Clear();
            TotalVehiculo = cantAuto + cantCamioneta + cantCamion;
            recAuto = auto * cantAuto;
            recCamioneta = camioneta * cantCamioneta;
            recCamion = camion * cantCamion;
            TotalRecaudado = recAuto + recCamioneta + recCamion;
            porcAuto = (cantAuto * 100) / TotalVehiculo;
            porcCamioneta = (cantCamioneta * 100) / TotalVehiculo;
            porcCamion = (cantCamion * 100) / TotalVehiculo;
            porcRecAuto = (recAuto * 100) / TotalRecaudado;
            porcRecCamioneta = (recCamioneta * 100) / TotalRecaudado;
            porcRecCamion = (recCamion * 100) / TotalRecaudado;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($" . Pasaron por el Peaje {cantAuto} Autos");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron por el Peaje {cantCamioneta} Camionetas");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron por el Peaje {cantCamion} Camiones");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron un total de {TotalVehiculo} Vehiculos");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron un porcentaje de {porcAuto:F2} % de Autos");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron un porcentaje de {porcCamioneta:F2} % de Camionetas");
            Console.WriteLine();
            Console.WriteLine($" . Pasaron un porcentaje de {porcCamion:F2} % de Camiones");
            Console.WriteLine();
            Console.WriteLine($" . Lo recaudado por Autos es ${recAuto}");
            Console.WriteLine();
            Console.WriteLine($" . Lo recaudado por Camionetas es ${recCamioneta}");
            Console.WriteLine();
            Console.WriteLine($" . Lo recaudado por Camiones es ${recCamion}");
            Console.WriteLine();
            Console.WriteLine($" . El porcentaje recaudado por Autos es {porcRecAuto:F2}% ");
            Console.WriteLine();
            Console.WriteLine($" . El porcentaje recaudado por Camionetas es {porcRecCamioneta:F2}% ");
            Console.WriteLine();
            Console.WriteLine($" . El porcentaje recaudado por Camiones es {porcRecCamion:F2}% ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine();
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
