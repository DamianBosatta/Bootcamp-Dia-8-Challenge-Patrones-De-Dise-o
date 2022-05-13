using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptee
{
    public abstract class Informante
    {
        public List<Ventas> ventas = new List<Ventas>();


        public abstract void GuardoArchivo(string archivoXml);
    }
}