using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syngleton
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Syngleton.Instancia();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(" ingrese el pais : " + i);
                Syngleton.CargaPaises(Console.ReadLine());
            }

            Syngleton.Instancia();
            
        }
    }
}
