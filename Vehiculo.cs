using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgramacion
{
    class Vehiculo
    {
        string marca = "Honda";
        string modelo = "Civic";

        public void SetVehiculo(string marc, string model)
        {
            this.marca = marc;
            this.modelo = model;

        }
        public void VerVehiculo()
        {
            Console.WriteLine("El vehiculo es: " +marca+ " " +modelo);
            Console.ReadLine();
        }
    }
    
}
