using System.Net.Http;
using System.Xml;
using MySql.Data.MySqlClient;

namespace LabConnect
{

    public partial class LabConnect_frm : Form
    {
        // Cadena de conexi�n a la base de datos
        private string connectionString = "Server=localhost;Database=labconnect_smc;Uid=root;Pwd=24445;";
        public LabConnect_frm()
        {
            InitializeComponent();

            /* Evento Enter
            string textoInicial = "Introduce el sitio web";
            txtURL.Enter += (sender, e) =>
            {
                TextBox txt = sender as TextBox;
                if (txt != null && txt.Text == textoInicial) // Solo eliminar si tiene el texto inicial
                {
                    txt.Text = "";
                }
            };

            groupBoxConexion.Controls.Add(txtURL); */

            txtURL.Enter += (sender, e) =>
            {
                TextBox txt = sender as TextBox;
                if (txt != null)
                {
                    txt.Text = ""; // Elimina el texto al dar clic
                }
            };
            txtVariable.Enter += (sender, e) =>
            {
                TextBox txt = sender as TextBox;
                if (txt != null)
                {
                    txt.Text = ""; // Elimina el texto al dar clic
                }
            };
            groupBoxConexion.Controls.Add(txtVariable);

        }


        private async void btnConectar_Click(object sender, EventArgs e)
            {
                string url = txtURL.Text.Trim();
                string variable = txtVariable.Text.Trim();

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(variable))
                {
                    lblEstadoConexion.Text = "Estado de la conexi�n: \n - URL o variable vac�a.";
                    lblEstadoConexion.ForeColor = Color.DarkOrange;
                    return;
                }

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Realizar la solicitud al servidor
                        HttpResponseMessage response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        string xmlContent = await response.Content.ReadAsStringAsync();

                        // Parsear el contenido del XML
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlContent);

                        // Extraer datos seg�n la variable
                        XmlNode aniosNode = xmlDoc.SelectSingleNode("//anios");
                        XmlNode poblacionNode = xmlDoc.SelectSingleNode("//poblacion");

                        if (aniosNode != null && poblacionNode != null)
                        {
                            lstDatosExtraidos.Items.Clear();
                            lstDatosExtraidos.Items.Add(new ListViewItem(new[] { "A�os", aniosNode.InnerText }));
                            lstDatosExtraidos.Items.Add(new ListViewItem(new[] { "Poblaci�n", poblacionNode.InnerText }));
                            lblEstadoConexion.Text = "Estado de la conexi�n: \n - Conexi�n exitosa.";
                            lblEstadoConexion.ForeColor = Color.DarkGreen;
                    }
                        else
                        {
                            lblEstadoConexion.Text = "Estado de la conexi�n: \n - Variable no encontrada.";
                            lblEstadoConexion.ForeColor = Color.DarkOrange;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblEstadoConexion.Text = $"Estado de la conexi�n:\n  Error - {ex.Message}";
                    lblEstadoConexion.ForeColor = Color.DarkRed;
                }
            }


    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/JoseLuisBautistaRodriguez/LabConect_WebApp",
                    UseShellExecute = true // Esto indica que debe usar el navegador predeterminado
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoConexion_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {


        }

        // Simular datos extra�dos (esto luego se reemplaza con la l�gica real)
        private void MostrarDatosExtraidos()
        {
            // Limpia el control para evitar duplicados
            lstDatosExtraidos.Items.Clear();

            // Datos simulados (reemplaza con los datos reales)
            var datos = new List<(string Variable, string Tipo)>
                    {
                        ("Variable1", "int"),
                        ("Variable2", "string"),
                        ("Variable3", "float")
                    };

            // Agregar datos al ListView
            foreach (var dato in datos)
            {
                var item = new ListViewItem(dato.Variable);
                item.SubItems.Add(dato.Tipo);
                lstDatosExtraidos.Items.Add(item);
            }
        }

       /* private void btnConectar_Click(object sender, EventArgs e)
        {
            TextBox txtURL = this.Controls.Find("txtURL", true).FirstOrDefault() as TextBox;
            TextBox txtVariable = this.Controls.Find("txtVariable", true).FirstOrDefault() as TextBox;
            Label lblEstadoConexion = this.Controls.Find("lblEstadoConexion", true).FirstOrDefault() as Label;

            if (!string.IsNullOrWhiteSpace(txtURL.Text) && !string.IsNullOrWhiteSpace(txtVariable.Text))
            {
                lblEstadoConexion.Text = "Estado de la conexi�n: Conectando...";
                lblEstadoConexion.ForeColor = Color.Orange;

                // Simula la conexi�n (puedes sustituir por l�gica real)
                Task.Run(() =>
                {
                    Thread.Sleep(2000); // Simular retraso
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblEstadoConexion.Text = "Estado de la conexi�n: Conectado";
                        lblEstadoConexion.ForeColor = Color.Green;
                    });
                });
            }
            else
            {
                lblEstadoConexion.Text = "Estado de la conexi�n: Error.";
                lblEstadoConexion.ForeColor = Color.Red;
            }
            MostrarDatosExtraidos();
        } */

        private void txtVariable_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstDatosExtraidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualiarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener el �ltimo registro de datos_entrada sin referencia en datos_salida
                    string query = @"
                SELECT de.id, de.poblacion_inicial, de.fecha_solicitud
                FROM datos_entrada de
                LEFT JOIN datos_salida ds ON de.id = ds.id_entrada
                WHERE ds.id_entrada IS NULL
                ORDER BY de.id DESC
                LIMIT 1;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los datos del registro
                            int id = reader.GetInt32("id");
                            int poblacionInicial = reader.GetInt32("poblacion_inicial");
                            DateTime fechaSolicitud = reader.GetDateTime("fecha_solicitud");

                            // Actualizar la interfaz con los datos obtenidos
                            lstDatosExtraidos.Items.Clear();
                            lstDatosExtraidos.Items.Add(new ListViewItem(new[] { "ID", id.ToString() }));
                            lstDatosExtraidos.Items.Add(new ListViewItem(new[] { "Poblaci�n Inicial", poblacionInicial.ToString() }));
                            lstDatosExtraidos.Items.Add(new ListViewItem(new[] { "Fecha de Solicitud", fechaSolicitud.ToString() }));

                            lblEstadoConexion.Text = "Datos actualizados correctamente.";
                            lblEstadoConexion.ForeColor = Color.DarkGreen;
                        }
                        else
                        {
                            lblEstadoConexion.Text = "No hay registros pendientes en datos_entrada.";
                            lblEstadoConexion.ForeColor = Color.DarkOrange;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = $"Error al actualizar los datos: {ex.Message}";
                lblEstadoConexion.ForeColor = Color.DarkRed;
            }
        }

    }
}
