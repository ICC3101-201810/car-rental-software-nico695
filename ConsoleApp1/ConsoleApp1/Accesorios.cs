using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum accesorios { radios_bluetooth, GPS, ruedas, extra_repuesto, cortinas_ventanas, sillas_nfante, nada }
    class Accesorios
    {
        public virtual accesorios accesorio()
        {
            return accesorios.nada;
        }


    }
}
