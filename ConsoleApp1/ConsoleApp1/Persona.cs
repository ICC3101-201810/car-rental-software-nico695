using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        string nombre;
        public Persona(string mnombre)
        {
            nombre = mnombre;
        }

        public bool licencia_para;

        public bool A(bool licencia_para)
        {
            if (licencia_para == true)
            {
                return true;

            }
            return false;
        }
    }
}
