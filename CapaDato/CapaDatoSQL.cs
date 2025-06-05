using System;
using Microsoft.Data.SqlClient;

namespace CapaDatosSQL
{
    public class Conexion
    {
        private readonly string cadenaConexion = "Server=.;Database=EMPLEADOSS;Integrated Security=true;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
