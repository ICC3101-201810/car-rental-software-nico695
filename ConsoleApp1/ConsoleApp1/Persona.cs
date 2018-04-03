using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        bool licencia_para;

        public bool A()
        {
            if (licencia_para == true)
            {
                return true;

            }
            return false;
        }
    }
}
