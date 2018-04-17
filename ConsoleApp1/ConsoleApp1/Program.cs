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

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Bienvenido\n(1) Usuario\n(2) Cliente\n(3) Salir");
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
                        Console.WriteLine("Cantidad de vehiculos disponibles:");
                        string stocks = Console.ReadLine();
                        int stock = Int32.Parse(stocks);
                        Vehiculos v1 = new Vehiculos(Nombrev,costo,stock);
                        s1.Agregarv(v1);

                        v1.StockArriendo(v1, stock);
                        Console.WriteLine("(1) Agregar otro vehiculo\n(2) Salir :");
                        string sa = Console.ReadLine();
                        if (sa == "2") ;
                        q = 0;


                    }

                }
                if (z == "2")
                {
                    Arriendo a1 = new Arriendo();
                    Console.WriteLine("Bienvenido");
                    Console.WriteLine("(1) Arrendar vehiculo\n(2) Devolver vehiculo\n(3) Salir");
                    string qa = Console.ReadLine();
                    if (qa=="1")
                    {
                        Console.WriteLine("Tipo de cliente:");
                        Console.WriteLine("(1) Persona\n(2) Empresa\n Ingrese opcion");
                        string qw = Console.ReadLine();
                        if (qw == "1")
                        {
                            Console.WriteLine("Nombre :");
                            string nombrecb = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Nombre agregado correctamente");
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Persona p1 = new Persona(nombrecb);
                            a1.AgregarPersona(p1);

                        }
                        else
                        {
                            Console.WriteLine("Nombre Empresa:");
                            string nombreca = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Nombre agregado correctamente");
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Empresa e1 = new Empresa(nombreca);
                            a1.AgregarEmpresa(e1);

                        }

                        Console.WriteLine("Nombre de la Sucursal en la que esta realizando el arriendo :");
                        string nombreb = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Sucursal agregada correctamente");
                        Console.Beep();

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Tipo de Vehiculo a arrendar :");
                        string Nombrev = Console.ReadLine(); 
                        Console.WriteLine("Costo del Vehiculo a arrendar :");
                        string costod = Console.ReadLine();
                        Console.WriteLine("Cantidad de vehiculos a arrendar :");
                        string stocks = Console.ReadLine();
                        int stock = Int32.Parse(stocks);

                        if (Nombrev == "Auto" | Nombrev == "auto")
                        {
                            Console.WriteLine("Desea un auto con \n(1) Corrida de asientos extra\n(2) Maletero mas grande\n(3)No agregar nada\nIngrese opcion :");
                            string tipoas = Console.ReadLine();
                            Console.WriteLine("Desea un auto con \n(1) Electrico\n(2) Bencinero\nIngrese opcion :");
                            string bd = Console.ReadLine();
                            Auto au1 = new Auto(Nombrev, costod, stock, tipoas,bd);
                            a1.AgregarAuto(au1);
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Vehiculo agregado correctamente");
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Vehiculos nv = new Vehiculos(Nombrev, costod, stock);
                        a1.AgregarVehiculo(nv);

                        Console.WriteLine("Accesorios a agregar:");
                        string acc = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Accesorios agregado correctamente");
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Black;



                        nv.StockArriendo(nv, stock);

                        Sucursales ss1 = new Sucursales(nombreb);
                        a1.AgregarSucursal(ss1);

                        Accesorios accs = new Accesorios(acc);
                        a1.AgregarAccesorios(accs);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Arriendo realizado de manera exitosa");
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("(1) Desea realizar otra operacion\n(2) Salir");
                        string awq = Console.ReadLine();
                        if (awq == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Presione tecla enter para salir");
                            Console.ReadKey();
                            Console.Beep();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }

                    }

                    else if (qa=="2")
                    {
                        Console.WriteLine("Ingrese los siguientes datos:");
                        Console.WriteLine("(1) Persona\n(2) Empresa\n Ingrese opcion : ");
                        string qw = Console.ReadLine();
                        if (qw == "1")
                        {
                            Console.WriteLine("Nombre :");
                            string nombrecb = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Nombre ingresado correctamente");
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Persona p1 = new Persona(nombrecb);
                            a1.AgregarPersona(p1);

                        }
                        else
                        {
                            Console.WriteLine("Nombre Empresa:");
                            string nombreca = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Nombre ingresado correctamente");
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Empresa e1 = new Empresa(nombreca);
                            a1.AgregarEmpresa(e1);

                        }

                        Console.WriteLine("Nombre de la Sucursal en la que se esta devolviendo el vehiculo :");
                        string nombreb = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Sucursal ingresada correctamente");
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Tipo de Vehiculo a devolver :");
                        string Nombrev = Console.ReadLine();
                        Console.WriteLine("Costo del Vehiculo a devolver :");
                        string costod = Console.ReadLine();
                        Console.WriteLine("Cantidad de vehiculos a devolver :");
                        string stocks = Console.ReadLine();
                        int stock = Int32.Parse(stocks);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Vehiculo ingresado correctamente");
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Accesorios a devolver:");
                        string acc = Console.ReadLine();

                        Vehiculos nv = new Vehiculos(Nombrev, costod, stock);
                        nv.Stockdevolucion(nv, stock);

                        Accesorios accs = new Accesorios(acc);
                        a1.AgregarAccesorios(accs);

                        Console.WriteLine("(1) Desea realizar otra operacion\n(2) Salir");
                        string awq = Console.ReadLine();
                        if (awq=="2")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Presione tecla enter para salir");
                            Console.ReadKey();
                            Console.Beep();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }

                    }
                    

                    
                }
                if (z == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Presione tecla enter para salir");
                    Console.ReadKey();
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }
                
            }
        }
    }
}
