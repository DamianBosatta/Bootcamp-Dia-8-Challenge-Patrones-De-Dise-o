using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptee
{
    internal class Receptor
    {
        public void DatosRecibidos(string msj)
        {
            
            Console.WriteLine("Archivo Recibido y guardado : " + msj);
        }
    }
}