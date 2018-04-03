using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursales
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();

        public void Agregarv(string vehicls)
        {
            string vh;
            vh = vehicls;
            vehiculos.Add(vh);

        }


    }
}
