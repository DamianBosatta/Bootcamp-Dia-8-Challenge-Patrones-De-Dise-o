using System;

namespace Adaptee
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee Prueba = new Adaptee();

            string Archxml = "archivoXML";
            Prueba.GuardoArchivo(Archxml);
        }
    }
}
