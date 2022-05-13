using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptee
{
    public class Ventas
    {
        public Ventas()
        {

        }

        public int Fecha { get;set;}
        public int IdCliente {get; set;}
        public int IdProducto {get; set;}
        public int Cantidad { get;set;}
        public double Precio { get; set;}
        public int NroRemito { get; set;}

    }
}