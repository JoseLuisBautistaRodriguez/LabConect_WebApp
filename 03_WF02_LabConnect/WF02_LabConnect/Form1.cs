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
            string contraseña = textBoxContraseña.Text;
            string baseDatos = textBoxBaseDatos.Text;

            // Crear la cadena de conexión
            string cadenaConexion = $"Server={host};Database={baseDatos};User Id={usuario};Password={contraseña};";

            // Intentar conectar a la base de datos
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open(); // Abrir la conexión
                    labelEstadoConexion.Text = "Conexión exitosa!";
                    labelEstadoConexion.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                // Mostrar el error en la etiqueta de estado
                labelEstadoConexion.Text = "Error: " + ex.Message;
                labelEstadoConexion.ForeColor = Color.Red;
            }
        }
    }
}
