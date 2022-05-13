using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño
{
    class ConecionOracle : ConectionFactory
    {
        public override void Getconnect()
        {
            Console.WriteLine("Conectando a Oracle");
        }
    }
}