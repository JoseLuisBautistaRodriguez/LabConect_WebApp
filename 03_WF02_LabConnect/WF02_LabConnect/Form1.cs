using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Connection whit DataBase
using System.Xml;
using System.Diagnostics;

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

        private void buttonGuardarDatos_Click(object sender, EventArgs e)
        {
            // Obtiene la ruta del archivo de entrada desde el TextBox y recorta espacios en blanco.
            string rutaEntrada = textBoxRutaEntrada.Text.Trim();

            // Obtiene el valor seleccionado en el ListBox, o null si no se selecciona nada.
            //string? poblacionInicial = listBoxUltimosDatos.SelectedItem?.ToString();
            // Obtener la línea del ListBox que contiene "Población Inicial".
            string poblacionInicial = listBoxUltimosDatos.Items
                .Cast<string>() // Convierte los elementos del ListBox a una colección de strings.
                .FirstOrDefault(item => item.StartsWith("Población Inicial:")) // Busca la línea que contiene "Población Inicial:".
                ?.Split(':') // Divide el texto por el carácter ':'.
                .LastOrDefault() // Obtiene el último segmento (el valor después de ':').
                ?.Trim(); // Elimina espacios en blanco al inicio y final.


            // Verifica si la ruta del archivo o el valor de la población inicial están vacíos.
            if (string.IsNullOrEmpty(rutaEntrada) || string.IsNullOrEmpty(poblacionInicial))
            {
                // Muestra un mensaje de advertencia indicando que faltan datos.
                MessageBox.Show("Por favor, asegúrate de seleccionar un valor y proporcionar la ruta correcta para datos.xml.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Termina la ejecución del método.
            }

            try
            {
                // Crea una nueva instancia de XmlDocument, que representa el archivo XML.
                XmlDocument doc = new XmlDocument();

                // Crea una declaración XML indicando la versión y la codificación.
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                // Crea el nodo raíz del archivo llamado <entrada>.
                XmlElement root = doc.CreateElement("entrada");

                // Crea un nodo hijo llamado <poblacion>.
                XmlElement poblacionNode = doc.CreateElement("poblacion");

                // Establece el valor de texto del nodo <poblacion> con el valor seleccionado del ListBox.
                poblacionNode.InnerText = poblacionInicial;

                // Agrega el nodo <poblacion> como hijo del nodo raíz <entrada>.
                root.AppendChild(poblacionNode);

                // Agrega la declaración XML al documento.
                doc.AppendChild(declaration);

                // Agrega el nodo raíz <entrada> al documento.
                doc.AppendChild(root);

                // Guarda el archivo XML en la ruta especificada en el TextBox.
                doc.Save(rutaEntrada);

                // Muestra un mensaje de éxito al usuario indicando que el archivo se guardó correctamente.
                MessageBox.Show($"Datos guardados correctamente en {rutaEntrada}",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, muestra un mensaje con el detalle del error.
                MessageBox.Show($"Error al guardar los datos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void listBoxUltimosDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonProcesarMatlab_Click(object sender, EventArgs e)
        {
            string rutaMatlab = textBoxRutaMatlab.Text.Trim();
            string rutaEntrada = textBoxRutaEntrada.Text.Trim();
            string rutaResultados = textBoxRutaResultados.Text.Trim();

            if (string.IsNullOrEmpty(rutaMatlab) || string.IsNullOrEmpty(rutaEntrada) || string.IsNullOrEmpty(rutaResultados))
            {
                MessageBox.Show("Por favor, proporciona las rutas correctas para los archivos de MATLAB, datos.xml y resultados.xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener la última fecha de modificación de resultados.xml
                DateTime ultimaModificacion = File.Exists(rutaResultados) ? File.GetLastWriteTime(rutaResultados) : DateTime.MinValue;

                // Configurar el proceso de MATLAB
                Process matlabProcess = new Process();
                matlabProcess.StartInfo.FileName = "matlab";
                string rutaDirectorio = Path.GetDirectoryName(rutaEntrada).Replace("\\", "/");
                string rutaArchivo = Path.GetFileName(rutaEntrada);
                matlabProcess.StartInfo.Arguments = $"-nodisplay -nosplash -nodesktop -r \"try; cd('{rutaDirectorio}'); growth_plot('{rutaArchivo}'); exit; catch; exit; end;\"";

                matlabProcess.StartInfo.UseShellExecute = false;
                matlabProcess.StartInfo.RedirectStandardOutput = true;
                matlabProcess.StartInfo.RedirectStandardError = true;
                matlabProcess.Start();

                // Leer salida y errores
                string salidaMatlab = matlabProcess.StandardOutput.ReadToEnd();
                string erroresMatlab = matlabProcess.StandardError.ReadToEnd();

                // Esperar a que MATLAB termine
                matlabProcess.WaitForExit();

                if (matlabProcess.ExitCode != 0)
                {
                    labelEstadoMatlab.Text = "Error en el proceso de MATLAB.";
                    labelEstadoMatlab.ForeColor = Color.Red;
                    MessageBox.Show($"Error en MATLAB: {erroresMatlab}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Esperar hasta que resultados.xml sea actualizado
                int intentos = 0;
                int tiempoMaximoEspera = 10; // Segundos
                while (intentos < tiempoMaximoEspera)
                {
                    if (File.GetLastWriteTime(rutaResultados) > ultimaModificacion)
                    {
                        // El archivo fue actualizado
                        labelEstadoMatlab.Text = "Proceso completado con éxito.";
                        labelEstadoMatlab.ForeColor = Color.Green;

                        // Cargar resultados actualizados
                        CargarResultados();
                        return;
                    }

                    // Esperar 1 segundo antes de verificar nuevamente
                    Thread.Sleep(1000);
                    intentos++;
                }

                // Si se alcanzó el tiempo máximo de espera
                labelEstadoMatlab.Text = "Proceso completado, pero el archivo no fue actualizado.";
                labelEstadoMatlab.ForeColor = Color.Orange;
                MessageBox.Show("El archivo resultados.xml no se actualizó en el tiempo esperado. Verifica la ejecución de MATLAB.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar MATLAB: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarResultados()
        {
            // Obtiene la ruta del archivo de resultados desde el TextBox y elimina espacios innecesarios.
            string rutaResultados = textBoxRutaResultados.Text.Trim();

            // Verifica si la ruta del archivo está vacía.
            if (string.IsNullOrEmpty(rutaResultados))
            {
                // Muestra un mensaje de advertencia si la ruta no se proporcionó.
                MessageBox.Show("Por favor, proporciona la ruta correcta para resultados.xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale de la función para evitar errores posteriores.
            }

            try
            {
                // Carga todo el contenido del archivo XML en una cadena de texto.
                string contenidoXml = System.IO.File.ReadAllText(rutaResultados);

                // Limpia el ListBox para evitar datos redundantes o acumulados.
                listBoxResultados.Items.Clear();

                // Divide el contenido del archivo XML en líneas y las agrega al ListBox.
                string[] lineasXml = contenidoXml.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string linea in lineasXml)
                {
                    listBoxResultados.Items.Add(linea);
                }
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier error que ocurra al leer el archivo XML.
                MessageBox.Show($"Error al leer resultados.xml: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void listBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarBD_Click(object sender, EventArgs e)
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
                string queryEntrada = "SELECT id FROM datos_entrada ORDER BY id DESC LIMIT 1";
                MySqlCommand cmdEntrada = new MySqlCommand(queryEntrada, conexion);
                object? result = cmdEntrada.ExecuteScalar();

                if (result == null)
                {
                    labelEstadoActualizarBD.Text = "No se encontraron registros en la tabla datos_entrada.";
                    labelEstadoActualizarBD.ForeColor = Color.DarkOrange;
                    return;
                }

                int idEntrada = Convert.ToInt32(result);

                // Verificar si ya existe una salida para el id_entrada en datos_salida
                string queryVerificarSalida = $"SELECT COUNT(*) FROM datos_salida WHERE id_entrada = {idEntrada}";
                MySqlCommand cmdVerificarSalida = new MySqlCommand(queryVerificarSalida, conexion);
                int existeEnSalida = Convert.ToInt32(cmdVerificarSalida.ExecuteScalar());

                if (existeEnSalida > 0)
                {
                    labelEstadoActualizarBD.Text = "El último registro ya tiene una salida asociada.";
                    labelEstadoActualizarBD.ForeColor = Color.DarkOrange;
                    return;
                }

                // Leer datos desde resultados.xml
                string rutaResultados = textBoxRutaResultados.Text.Trim();
                XmlDocument doc = new XmlDocument();
                doc.Load(rutaResultados);

                XmlNode? aniosNode = doc.SelectSingleNode("//anios");
                XmlNode? poblacionNode = doc.SelectSingleNode("//poblacion");

                if (aniosNode == null || poblacionNode == null)
                {
                    labelEstadoActualizarBD.Text = "El archivo resultados.xml no contiene los datos esperados.";
                    labelEstadoActualizarBD.ForeColor = Color.Red;
                    return;
                }

                // Crear el XML en el formato requerido
                XmlDocument formattedDoc = new XmlDocument();
                XmlDeclaration declaration = formattedDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                formattedDoc.AppendChild(declaration);

                XmlElement root = formattedDoc.CreateElement("resultados");
                formattedDoc.AppendChild(root);

                XmlElement aniosElement = formattedDoc.CreateElement("anios");
                aniosElement.InnerText = aniosNode.InnerText.Trim(); // Asegura que los datos estén formateados correctamente
                root.AppendChild(aniosElement);

                XmlElement poblacionElement = formattedDoc.CreateElement("poblacion");
                poblacionElement.InnerText = poblacionNode.InnerText.Trim();
                root.AppendChild(poblacionElement);

                // Convertir el XML a string
                string datosXml = "";
                using (StringWriter writer = new StringWriter())
                {
                    formattedDoc.Save(writer);
                    datosXml = writer.ToString();
                }

                // Insertar datos en la tabla datos_salida
                string queryInsertarSalida = "INSERT INTO datos_salida (id_entrada, datos_xml) VALUES (@idEntrada, @datosXml)";
                MySqlCommand cmdInsertarSalida = new MySqlCommand(queryInsertarSalida, conexion);
                cmdInsertarSalida.Parameters.AddWithValue("@idEntrada", idEntrada);
                cmdInsertarSalida.Parameters.AddWithValue("@datosXml", datosXml);

                cmdInsertarSalida.ExecuteNonQuery();

                labelEstadoActualizarBD.Text = "Datos actualizados correctamente en la base de datos.";
                labelEstadoActualizarBD.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier error
                labelEstadoActualizarBD.Text = $"Error al actualizar los datos: {ex.Message}";
                labelEstadoActualizarBD.ForeColor = Color.Red;
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


    }
}
