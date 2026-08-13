using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TallerToluca.DAL
{
    internal class Conexion
    {
    }
}
using System.Data.SqlClient;

namespace TallerToluca.DAL
{
    public static class ConexionDAL
    {
        // Ajusta la cadena con el nombre de tu servidor SQL Server
        private static readonly string CadenaConexion = @"Data Source=.;Initial Catalog=TallerMecanicoTolucaDB;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            conn.Open();
            return conn;
        }
    }
}
