using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        List<Sucursales> sucursales = new List<Sucursales>();
        List<Persona> persona = new List<Persona>();
        List<Empresa> empresa = new List<Empresa>();
        List<Accesorios> accesorio = new List<Accesorios>();
        List<Vehiculos> vehiculoa = new List<Vehiculos>();
        List<Auto> vehiculoauto = new List<Auto>();

        public Arriendo()
        {
        }

        public void AgregarSucursal(Sucursales sucursal)
        {
            sucursales.Add(sucursal);
        }

        public void AgregarPersona(Persona ppersona)
        {
            persona.Add(ppersona);
        }

        public void AgregarEmpresa(Empresa empresaa)
        {
            empresa.Add(empresaa);
        }

        public void AgregarAccesorios(Accesorios acc)
        {
            accesorio.Add(acc);
        }

        public void AgregarVehiculo(Vehiculos vehiculoas)
        {
            vehiculoa.Add(vehiculoas);
            
        }

        public void AgregarAuto(Auto aas)
        {
            vehiculoauto.Add(aas);

        }


    }
}
