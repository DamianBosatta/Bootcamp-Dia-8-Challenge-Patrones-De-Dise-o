using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syngleton
{
    public class Syngleton
    {
        private static Syngleton instancia = null;


        protected static List<string> ListPaises;
        
        protected Syngleton(List<string> l) 
        {
            ListPaises = l;
        
        
        
        }

        protected Syngleton() { }
       

        public static void Instancia()
        {
            if (instancia == null)
            {
               instancia = new Syngleton(new List<string>());
            }
            
              for(int i=0;i<= ListPaises.Count;i++)
            {
                Console.WriteLine(ListPaises[i]);

            }
        }

        public static void CargaPaises(string nomPais)
        {
            if (instancia == null)
            {
                instancia = new Syngleton(new List<string>());
            }

            ListPaises.Add(nomPais);


        }






    }
}
