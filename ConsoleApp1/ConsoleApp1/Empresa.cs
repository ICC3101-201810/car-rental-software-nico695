using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa
    {
        bool autorizacion;
        public bool Autoriza()
        {
            if (autorizacion == true)
            {
                return true;

            }
            return false;
        }
    }
}
