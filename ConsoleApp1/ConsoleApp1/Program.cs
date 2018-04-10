using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arriendo arrenda = new Arriendo();
            for (int i = 0; true; i++)
            {

                Console.WriteLine("Bienvenido\n1. Usuario\n2. Cliente\n3. Salir");
                string z = Console.ReadLine();
                if (z == "1")
                {
                    
                    Console.WriteLine("Ingrese los siguientes datos:");
                    Console.WriteLine("Nombre Sucursal:");
                    string nombrea = Console.ReadLine();
                    Sucursales s1 = new Sucursales(nombrea);
                    int q;
                    q = 1;
                    while (q!=0);
                    {
                        Console.WriteLine("Nombre de vehiculo a agregar");
                        string Nombrev = Console.ReadLine();
                        Console.WriteLine("Costo del vehiculo agregado:");
                        string costo = Console.ReadLine();
                        Vehiculos v1 = new Vehiculos(Nombrev,costo);
                        s1.Agregarv(v1);
                        Console.WriteLine("(1) Agregar otro vehiculo\n(2) Salir :");
                        string sa = Console.ReadLine();
                        if (sa == "2") ;
                        q = 0;


                    }

                }
                if (z == "2")
                {
                    Arriendo a1 = new Arriendo();
                    Console.WriteLine("Ingrese los siguientes datos:");
                    Console.WriteLine("(1) Persona\n(2)Empresa\n Ingrese opcion : ");
                    string qw = Console.ReadLine();
                    if (qw=="1")
                    {
                        Console.WriteLine("Nombre :");
                        string nombrecb = Console.ReadLine();
                        Persona p1 = new Persona(nombrecb);
                        a1.AgregarPersona(p1);

                    }
                    Console.WriteLine("Nombre Empresa:");
                    string nombreca = Console.ReadLine();
                    Empresa e1 = new Empresa(nombreca);
                    a1.AgregarEmpresa(e1);
                    Console.WriteLine("Nombre Sucursal:");
                    string nombreb = Console.ReadLine();
                    Console.WriteLine("Nombre del Vehiculo:");
                    string Nombrev = Console.ReadLine();
                    Console.WriteLine("Costo del Vehiculo:");
                    string costod = Console.ReadLine();
                    Console.WriteLine("Accesorios a agregar:");
                    string acc = Console.ReadLine();

                    Vehiculos nv = new Vehiculos(Nombrev, costod);
                    a1.AgregarVehiculo(nv);

                    Sucursales ss1 = new Sucursales(nombreb);
                    a1.AgregarSucursal(ss1);

                    Accesorios accs = new Accesorios(acc);
                    a1.AgregarAccesorios(accs);

                    
                }
                if (z == "3")
                {

                    break;
                }
                
            }
        }
    }
}
