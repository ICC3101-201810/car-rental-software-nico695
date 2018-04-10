using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cliente
    {

        public string Tipo;

        public Cliente(string Eltipo)
        {

            Tipo = Eltipo;
        }

        public bool checkearcliente(string tipo)
        {
            if (tipo == "Empresa") ;
            {
                return true;

            }
            return false;
        }


    }
}
