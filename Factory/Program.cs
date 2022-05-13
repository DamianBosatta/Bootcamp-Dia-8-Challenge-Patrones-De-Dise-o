using System;

namespace PatronDeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            ConectionFactory coneccionOracle = Conexion.conectar(Conexion.ORACLE);
            ConectionFactory coneccionSQL = Conexion.conectar(Conexion.SQL);
            ConectionFactory coneccionMySQL = Conexion.conectar(Conexion.MySQL);

            coneccionOracle.Getconnect();
            coneccionSQL.Getconnect();
            coneccionMySQL.Getconnect();
        }
    }
}
