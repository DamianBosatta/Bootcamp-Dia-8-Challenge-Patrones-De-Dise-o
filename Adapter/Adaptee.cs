using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptee
{
    internal class Adaptee : Informante
    {
        Receptor receptor = new Receptor();

        public override void GuardoArchivo(string archivoXml)
        {
            Console.WriteLine("El adapter recibe: " + archivoXml);
            archivoXml = Transformo(archivoXml);
            receptor.DatosRecibidos(Transformo(archivoXml));
        }
        private string Transformo(string archivoXml)
        {
            archivoXml = "Archivo.JSON";

            string archivoJSON = archivoXml;
            return archivoJSON;
        }
    }
}