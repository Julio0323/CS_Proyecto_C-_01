using System;
using System.Data;
using CapaDatosSQL;
using Microsoft.Data.SqlClient;


namespace CapaNegocios
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public virtual decimal CalcularBonificacion()
        {
            return 0;
        }
    }

    public class Administrativo : Empleado
    {
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.10m;
        }
    }

    public class Operativo : Empleado
    {
        public override decimal CalcularBonificacion()
        {
            return Salario * 0.05m;
        }
    }

    public class EmpleadoNegocio
    {
        private readonly Conexion conexion = new Conexion();
        
        public DataTable ObtenerEmpleados()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "SELECT * FROM EMPLEADODOS";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();

                    conn.Open();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    throw;
                }
            }

        }

        public bool InsertarEmpleado(Empleado emp)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO EMPLEADODOS (NOMBRE ,DEPARTAMENTO,CARGO,SALARIO) " +
                                   "VALUES (@Nombre, @Departamento, @Cargo, @Salario)";

                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@Nombre", emp.Nombre);
                    comando.Parameters.AddWithValue("@Departamento", emp.Departamento);
                    comando.Parameters.AddWithValue("@Cargo", emp.Cargo);
                    comando.Parameters.AddWithValue("@Salario", emp.Salario);

                    conn.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR al insertar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarEmpleado(int id)
        {
            using (SqlConnection conn = new SqlConnection("Server=.;Database=EMPLEADOSS;Integrated Security=true;TrustServerCertificate=True;"))
            {
                string query = "DELETE FROM EMPLEADODOS WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

    }
}
