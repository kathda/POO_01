using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgramacion
{
    class MostrarVehiculo
    {
        static void Main(string[] args)
        {
            Vehiculo MiVehiculo = new Vehiculo();
            MiVehiculo.SetVehiculo("Hundai", "Sonata");
            MiVehiculo.VerVehiculo();
            Console.WriteLine();

            Vehiculo Vehiculo2 = new Vehiculo();
            Vehiculo2.SetVehiculo("Jeep", "Grand Cherokee");
            Vehiculo2.VerVehiculo();


            Console.ReadKey();
        }
    }
}
