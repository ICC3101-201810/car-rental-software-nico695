using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa
    {
        string nombre;
        public Empresa(string nonombre)
        {
            nombre = nonombre;
        }
        bool autorizacion;
        public bool Autoriza(bool autorizacion)
        {
            if (autorizacion == true)
            {
                return true;

            }
            return false;
        }
    }
}
