using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculos
    {
        string tipo;
        string costo;
        int stock;
        public Vehiculos(string tipoveh, string mcosto,int stocks)
        {
            tipo = tipoveh;
            costo = mcosto;
            stock = stocks;
        }



        public void StockArriendo(Vehiculos vehiculoas,int t)
        {
            vehiculoas.stock=vehiculoas.stock - t;
        }
        public void Stockdevolucion(Vehiculos vehiculoas, int t)
        {
            vehiculoas.stock = vehiculoas.stock + t;
        }

    }
    public class Auto:Vehiculos
    {
        string tipoa;
        string bd;
        public Auto(string tipoveh, string mcosto, int stocks,string tipoaa,string bdd):base(tipoveh,mcosto,stocks)
        {
            tipoa = tipoaa;
            bd = bdd;
        }
    }
    

    
}
