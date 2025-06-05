using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocios; // Importa tu capa de negocio
using System.Globalization;



namespace CapaPresentacionCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatos(); // Llama al cargar el formulario
        }

        private Empleado CrearEmpleadoDesdeFila(DataRow fila)
        {
            string cargo = fila["DEPARTAMENTO"]?.ToString().Trim().ToUpper() ?? "";
            Empleado emp;

            if (cargo == "ADM")
                emp = new Administrativo();
            else if (cargo == "OP")
                emp = new Operativo();
            else
                emp = new Empleado(); // Si no se reconoce el cargo

            emp.Id = Convert.ToInt32(fila["ID"]);
            emp.Nombre = fila["NOMBRE"].ToString();
            emp.Departamento = fila["DEPARTAMENTO"].ToString();
            emp.Cargo = cargo;
            emp.Salario = Convert.ToDecimal(fila["SALARIO"]);

            return emp;
        }


        private void CargarDatos()
        {
            try
            {
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                DataTable empleados = negocio.ObtenerEmpleados();


                if (!empleados.Columns.Contains("Bonificacion"))
                    empleados.Columns.Add("Bonificacion", typeof(string));

                foreach (DataRow fila in empleados.Rows)
                {
                    Empleado emp = CrearEmpleadoDesdeFila(fila);
                    decimal bonif = emp.CalcularBonificacion();
                    fila["Bonificacion"] = $"{bonif:N2}"; // Lo muestra como $xxx.xx
                }

                dataGridView1.DataSource = empleados;



                dataGridView1.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes poner lógica adicional si necesitas responder a clics en celdas.
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal salario;
            if (!decimal.TryParse(Salario_Dime.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out salario))
            {
                MessageBox.Show("El salario ingresado no es válido.");
                return;
            }

            // Crear el objeto Empleado con los datos del formulario
            Empleado nuevoEmpleado = new Administrativo // O "Operativo" si aplica
            {
                Nombre = Nombre_Dime.Text,
                Departamento = Departamento_Dime.Text,
                Cargo = Cargo_Dime.Text,
                Salario = salario
            };

            // Instanciar la capa de negocio
            EmpleadoNegocio negocio = new EmpleadoNegocio();

            // Insertar en la base de datos
            bool exito = negocio.InsertarEmpleado(nuevoEmpleado);

            // Mostrar resultado
            if (exito)
            {
                MessageBox.Show(" Empleado insertado correctamente.");
                CargarDatos();


                Nombre_Dime.Text = "";
                Departamento_Dime.Text = "";
                Cargo_Dime.Text = "";
                Salario_Dime.Text = "";
            }

            else
            {
                MessageBox.Show(" Error al insertar el empleado.");
            }
        }


        private void btnFiltrarAdministrativos_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                DataTable empleados = negocio.ObtenerEmpleados();

                // Usamos el método Select para filtrar las filas donde Cargo = 'Administrativo'
                DataRow[] administrativos = empleados.Select("DEPARTAMENTO = 'OP'");

                // Crear una nueva tabla con las filas filtradas
                if (administrativos.Length > 0)
                {
                    DataTable tablaFiltrada = administrativos.CopyToDataTable();

                    // Aseguramos que la columna Bonificación exista
                    if (!tablaFiltrada.Columns.Contains("Bonificacion"))
                        tablaFiltrada.Columns.Add("Bonificacion", typeof(string));

                    // Calculamos la bonificación por cada fila
                    foreach (DataRow fila in tablaFiltrada.Rows)
                    {
                        Empleado emp = CrearEmpleadoDesdeFila(fila);
                        fila["Bonificacion"] = $"{emp.CalcularBonificacion():N2}"; // Ej: $150.00
                    }

                    dataGridView1.DataSource = tablaFiltrada;
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados administrativos.");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar empleados: " + ex.Message);
            }
        }



        private void FiltrarPorDepartamento(object sender, EventArgs e)
        {
            try
            {
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                DataTable empleados = negocio.ObtenerEmpleados();

                // Usamos el método Select para filtrar las filas donde Cargo = 'Administrativo'
                DataRow[] administrativos = empleados.Select("DEPARTAMENTO = 'ADM'");

                // Crear una nueva tabla con las filas filtradas
                if (administrativos.Length > 0)
                {
                    DataTable tablaFiltrada = administrativos.CopyToDataTable();

                    if (!tablaFiltrada.Columns.Contains("Bonificacion"))
                        tablaFiltrada.Columns.Add("Bonificacion", typeof(string));

                    // Calculamos la bonificación por cada fila
                    foreach (DataRow fila in tablaFiltrada.Rows)
                    {
                        Empleado emp = CrearEmpleadoDesdeFila(fila);
                        fila["Bonificacion"] = $"{emp.CalcularBonificacion():N2}"; // Ej: $150.00
                    }

                    dataGridView1.DataSource = tablaFiltrada;
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados administrativos.");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar empleados: " + ex.Message);
            }

        }

        private void FiltrarPorDepartamento(string departamento)
        {

        }


        private void btnMostrarTodos_Click_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                var valor = dataGridView1.Rows[rowIndex].Cells["ID"].Value;
               // MessageBox.Show("Valor del ID: " + valor?.ToString());

                if (valor != null)
                {
                    int idEmpleado = Convert.ToInt32(valor);

                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        EmpleadoNegocio negocio = new EmpleadoNegocio();
                        bool exito = negocio.EliminarEmpleado(idEmpleado);

                        if (exito)
                        {
                            MessageBox.Show("Empleado eliminado correctamente.");
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el empleado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del empleado.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
            }
        }


    }

}
