using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Connection whit DataBase

namespace WF02_LabConnect
{
    public partial class LabConnect : Form
    {
        public LabConnect()
        {
            InitializeComponent();
        }

        private void labelEstadoConexion_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            try
            {
                var pso = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "http://labremotomd.fi-p.unam.mx:8090/",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(pso);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir el enlace. Error.{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            try
            {
                var pso = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/JoseLuisBautistaRodriguez/LabConect_WebApp",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(pso);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir el enlace. Error.{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonValidarConexion_Click(object sender, EventArgs e)
        {
            // Obtener los datos de conexión desde los cuadros de texto
            string host = textBoxHost.Text;
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;
            string baseDatos = textBoxBaseDatos.Text;

            // Crear la cadena de conexión
            string cadenaConexion = $"Server={host};Port=3306;Database={baseDatos};User Id={usuario};Password={contrasena};";

            MySqlConnection? conexion = null;
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open(); // Abrir la conexión
                labelEstadoConexion.Text = "Conexión exitosa!";
                labelEstadoConexion.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                // Mostrar el error en la etiqueta de estado
                labelEstadoConexion.Text = "Error: " + ex.Message;
                labelEstadoConexion.ForeColor = Color.Red;

                // Mostrar detalles adicionales en la consola (para depuración)
                Console.WriteLine("Error completo: " + ex.ToString());
                MessageBox.Show("Error completo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            // Obtener los datos de conexión desde los TextBox del grupo de conexión
            string host = textBoxHost.Text.Trim();
            string usuario = textBoxUsuario.Text.Trim();
            string contrasena = textBoxContrasena.Text.Trim();
            string baseDatos = textBoxBaseDatos.Text.Trim();

            // Crear la cadena de conexión
            string cadenaConexion = $"Server={host};Port=3306;Database={baseDatos};User Id={usuario};Password={contrasena};";

            MySqlConnection? conexion = null;
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                // Consultar el último elemento de datos_entrada
                string queryEntrada = "SELECT id, fecha_solicitud, poblacion_inicial FROM datos_entrada ORDER BY id DESC LIMIT 1";
                MySqlCommand cmdEntrada = new MySqlCommand(queryEntrada, conexion);
                var readerEntrada = cmdEntrada.ExecuteReader();

                if (readerEntrada.Read())
                {
                    int idEntrada = readerEntrada.GetInt32("id");
                    string fechaSolicitud = readerEntrada.GetString("fecha_solicitud");
                    int poblacionInicial = readerEntrada.GetInt32("poblacion_inicial");
                    readerEntrada.Close();

                    // Consultar si el id de datos_entrada no está en datos_salida
                    string querySalida = $"SELECT COUNT(*) FROM datos_salida WHERE id_entrada = {idEntrada}";
                    MySqlCommand cmdSalida = new MySqlCommand(querySalida, conexion);
                    int existeEnSalida = Convert.ToInt32(cmdSalida.ExecuteScalar());

                    if (existeEnSalida == 0)
                    {
                        // Mostrar los datos en el TextBox o ListBox
                        string datos = $"ID: {idEntrada}\nFecha: {fechaSolicitud}\nPoblación Inicial: {poblacionInicial}";
                        listBoxUltimosDatos.Text = datos;

                        // Si usas ListBox, también puedes mostrarlo así:
                        listBoxUltimosDatos.Items.Clear();
                        listBoxUltimosDatos.Items.Add($"ID: {idEntrada}");
                        listBoxUltimosDatos.Items.Add($"Fecha: {fechaSolicitud}");
                        listBoxUltimosDatos.Items.Add($"Población Inicial: {poblacionInicial}");
                    }
                    else
                    {
                        listBoxUltimosDatos.Text = "El último elemento ya tiene una salida registrada.";
                    }
                }
                else
                {
                    listBoxUltimosDatos.Text = "No se encontraron registros en la tabla datos_entrada.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
