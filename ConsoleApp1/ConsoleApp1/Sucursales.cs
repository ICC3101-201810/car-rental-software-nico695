using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursales
    {
        string nombre;
        public Sucursales(string nnombre)
        {
            nombre = nnombre;
        }
        List<Vehiculos> vehiculos = new List<Vehiculos>();

        public void Agregarv(Vehiculos vehiculo)
        {
            
            vehiculos.Add(vehiculo);

        }


    }
}
