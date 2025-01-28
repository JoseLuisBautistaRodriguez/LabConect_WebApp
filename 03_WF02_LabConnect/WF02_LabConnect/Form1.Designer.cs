namespace WF02_LabConnect
{
    partial class LabConnect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabConnect));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            labelEstadoConexion = new Label();
            buttonValidarConexion = new Button();
            textBoxBaseDatos = new TextBox();
            textBoxContrasena = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxHost = new TextBox();
            labelBaseDatos = new Label();
            labelContrasena = new Label();
            labelUsuario = new Label();
            labelhost = new Label();
            label2 = new Label();
            groupBoxUltimosDatos = new GroupBox();
            btnActualizarDatos = new Button();
            listBoxUltimosDatos = new ListBox();
            labelG2Texto = new Label();
            groupBox2 = new GroupBox();
            listBoxResultados = new ListView();
            label7 = new Label();
            labelEstadoMatlab = new Label();
            buttonProcesarMatlab = new Button();
            buttonGuardarDatos = new Button();
            textBoxRutaResultados = new TextBox();
            textBoxRutaMatlab = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxRutaEntrada = new TextBox();
            groupBoxActualizarBD = new GroupBox();
            labelEstadoActualizarBD = new Label();
            btnActualizarBD = new Button();
            groupBox1.SuspendLayout();
            groupBoxUltimosDatos.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxActualizarBD.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(360, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Repositorio";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(309, 17);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(39, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sitio";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 2;
            label1.Text = "Proyecto PAPIME PE115224";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelEstadoConexion);
            groupBox1.Controls.Add(buttonValidarConexion);
            groupBox1.Controls.Add(textBoxBaseDatos);
            groupBox1.Controls.Add(textBoxContrasena);
            groupBox1.Controls.Add(textBoxUsuario);
            groupBox1.Controls.Add(textBoxHost);
            groupBox1.Controls.Add(labelBaseDatos);
            groupBox1.Controls.Add(labelContrasena);
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(labelhost);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 266);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conexión con la base de Datos";
            // 
            // labelEstadoConexion
            // 
            labelEstadoConexion.AutoSize = true;
            labelEstadoConexion.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEstadoConexion.Location = new Point(14, 222);
            labelEstadoConexion.Name = "labelEstadoConexion";
            labelEstadoConexion.Size = new Size(238, 15);
            labelEstadoConexion.TabIndex = 10;
            labelEstadoConexion.Text = "Estado de Conexión:  Desconectado\r\n";
            labelEstadoConexion.Click += labelEstadoConexion_Click;
            // 
            // buttonValidarConexion
            // 
            buttonValidarConexion.Location = new Point(254, 181);
            buttonValidarConexion.Name = "buttonValidarConexion";
            buttonValidarConexion.Size = new Size(179, 38);
            buttonValidarConexion.TabIndex = 9;
            buttonValidarConexion.Text = "Conectar";
            buttonValidarConexion.UseVisualStyleBackColor = true;
            buttonValidarConexion.Click += buttonValidarConexion_Click;
            // 
            // textBoxBaseDatos
            // 
            textBoxBaseDatos.ForeColor = SystemColors.WindowFrame;
            textBoxBaseDatos.Location = new Point(132, 148);
            textBoxBaseDatos.Name = "textBoxBaseDatos";
            textBoxBaseDatos.Size = new Size(301, 27);
            textBoxBaseDatos.TabIndex = 8;
            textBoxBaseDatos.Text = "labconnect_smc";
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.ForeColor = SystemColors.WindowFrame;
            textBoxContrasena.Location = new Point(132, 112);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(301, 27);
            textBoxContrasena.TabIndex = 7;
            textBoxContrasena.Text = "24445";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.ForeColor = SystemColors.WindowFrame;
            textBoxUsuario.Location = new Point(132, 79);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(301, 27);
            textBoxUsuario.TabIndex = 6;
            textBoxUsuario.Text = "root";
            // 
            // textBoxHost
            // 
            textBoxHost.ForeColor = SystemColors.WindowFrame;
            textBoxHost.Location = new Point(132, 46);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.Size = new Size(301, 27);
            textBoxHost.TabIndex = 5;
            textBoxHost.Text = "localhost";
            // 
            // labelBaseDatos
            // 
            labelBaseDatos.AutoSize = true;
            labelBaseDatos.Location = new Point(14, 151);
            labelBaseDatos.Name = "labelBaseDatos";
            labelBaseDatos.Size = new Size(108, 20);
            labelBaseDatos.TabIndex = 4;
            labelBaseDatos.Text = "Base de Datos:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Location = new Point(32, 115);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(90, 20);
            labelContrasena.TabIndex = 3;
            labelContrasena.Text = "Contraseña:";
            labelContrasena.TextAlign = ContentAlignment.TopRight;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(56, 82);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 20);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario:";
            // 
            // labelhost
            // 
            labelhost.AutoSize = true;
            labelhost.Location = new Point(78, 49);
            labelhost.Name = "labelhost";
            labelhost.Size = new Size(44, 20);
            labelhost.TabIndex = 1;
            labelhost.Text = "Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 0;
            label2.Text = "Ingresa los datos de conexión con la base de datos:";
            // 
            // groupBoxUltimosDatos
            // 
            groupBoxUltimosDatos.Controls.Add(btnActualizarDatos);
            groupBoxUltimosDatos.Controls.Add(listBoxUltimosDatos);
            groupBoxUltimosDatos.Controls.Add(labelG2Texto);
            groupBoxUltimosDatos.Location = new Point(12, 322);
            groupBoxUltimosDatos.Name = "groupBoxUltimosDatos";
            groupBoxUltimosDatos.Size = new Size(449, 187);
            groupBoxUltimosDatos.TabIndex = 4;
            groupBoxUltimosDatos.TabStop = false;
            groupBoxUltimosDatos.Text = "Datos de Entrada";
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.Location = new Point(256, 136);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(179, 38);
            btnActualizarDatos.TabIndex = 11;
            btnActualizarDatos.Text = "Actualizar";
            btnActualizarDatos.UseVisualStyleBackColor = true;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // listBoxUltimosDatos
            // 
            listBoxUltimosDatos.FormattingEnabled = true;
            listBoxUltimosDatos.Location = new Point(8, 46);
            listBoxUltimosDatos.Name = "listBoxUltimosDatos";
            listBoxUltimosDatos.Size = new Size(427, 84);
            listBoxUltimosDatos.TabIndex = 1;
            listBoxUltimosDatos.SelectedIndexChanged += listBoxUltimosDatos_SelectedIndexChanged;
            // 
            // labelG2Texto
            // 
            labelG2Texto.AutoSize = true;
            labelG2Texto.Location = new Point(8, 23);
            labelG2Texto.Name = "labelG2Texto";
            labelG2Texto.Size = new Size(184, 20);
            labelG2Texto.TabIndex = 0;
            labelG2Texto.Text = "Últimos datos de entrada:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxResultados);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(labelEstadoMatlab);
            groupBox2.Controls.Add(buttonProcesarMatlab);
            groupBox2.Controls.Add(buttonGuardarDatos);
            groupBox2.Controls.Add(textBoxRutaResultados);
            groupBox2.Controls.Add(textBoxRutaMatlab);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxRutaEntrada);
            groupBox2.Location = new Point(467, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 409);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Matlab";
            // 
            // listBoxResultados
            // 
            listBoxResultados.ImeMode = ImeMode.NoControl;
            listBoxResultados.Location = new Point(6, 280);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(557, 107);
            listBoxResultados.TabIndex = 10;
            listBoxResultados.UseCompatibleStateImageBehavior = false;
            listBoxResultados.View = View.List;
            listBoxResultados.SelectedIndexChanged += listBoxResultados_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 255);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 9;
            label7.Text = "Datos Procesados:";
            // 
            // labelEstadoMatlab
            // 
            labelEstadoMatlab.AutoSize = true;
            labelEstadoMatlab.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEstadoMatlab.Location = new Point(6, 239);
            labelEstadoMatlab.Name = "labelEstadoMatlab";
            labelEstadoMatlab.Size = new Size(203, 15);
            labelEstadoMatlab.TabIndex = 8;
            labelEstadoMatlab.Text = "Estado del proceso de Matlab";
            // 
            // buttonProcesarMatlab
            // 
            buttonProcesarMatlab.Location = new Point(384, 198);
            buttonProcesarMatlab.Name = "buttonProcesarMatlab";
            buttonProcesarMatlab.Size = new Size(179, 38);
            buttonProcesarMatlab.TabIndex = 7;
            buttonProcesarMatlab.Text = "Procesar en Matlab";
            buttonProcesarMatlab.UseVisualStyleBackColor = true;
            buttonProcesarMatlab.Click += buttonProcesarMatlab_Click;
            // 
            // buttonGuardarDatos
            // 
            buttonGuardarDatos.Location = new Point(199, 198);
            buttonGuardarDatos.Name = "buttonGuardarDatos";
            buttonGuardarDatos.Size = new Size(179, 38);
            buttonGuardarDatos.TabIndex = 6;
            buttonGuardarDatos.Text = "Guardar Datos";
            buttonGuardarDatos.UseVisualStyleBackColor = true;
            buttonGuardarDatos.Click += buttonGuardarDatos_Click;
            // 
            // textBoxRutaResultados
            // 
            textBoxRutaResultados.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            textBoxRutaResultados.ForeColor = SystemColors.WindowFrame;
            textBoxRutaResultados.Location = new Point(6, 165);
            textBoxRutaResultados.Name = "textBoxRutaResultados";
            textBoxRutaResultados.Size = new Size(557, 25);
            textBoxRutaResultados.TabIndex = 5;
            textBoxRutaResultados.Text = "C:\\xampp\\htdocs\\04_LR_Connect\\LabConect_WebApp\\02_matlabFiles\\resultados.xml";
            // 
            // textBoxRutaMatlab
            // 
            textBoxRutaMatlab.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            textBoxRutaMatlab.ForeColor = SystemColors.WindowFrame;
            textBoxRutaMatlab.Location = new Point(6, 112);
            textBoxRutaMatlab.Name = "textBoxRutaMatlab";
            textBoxRutaMatlab.Size = new Size(557, 25);
            textBoxRutaMatlab.TabIndex = 4;
            textBoxRutaMatlab.Text = "C:\\xampp\\htdocs\\04_LR_Connect\\LabConect_WebApp\\02_matlabFiles\\growth_plot.m";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(219, 20);
            label5.TabIndex = 3;
            label5.Text = "Ruta del archivo de resultados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(214, 20);
            label4.TabIndex = 2;
            label4.Text = "Ruta del archivo de ejecución:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 1;
            label3.Text = "Ruta del archivo de entrada:";
            // 
            // textBoxRutaEntrada
            // 
            textBoxRutaEntrada.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            textBoxRutaEntrada.ForeColor = SystemColors.WindowFrame;
            textBoxRutaEntrada.Location = new Point(6, 56);
            textBoxRutaEntrada.Name = "textBoxRutaEntrada";
            textBoxRutaEntrada.Size = new Size(557, 25);
            textBoxRutaEntrada.TabIndex = 0;
            textBoxRutaEntrada.Text = "C:\\xampp\\htdocs\\04_LR_Connect\\LabConect_WebApp\\02_matlabFiles\\datos.xml";
            // 
            // groupBoxActualizarBD
            // 
            groupBoxActualizarBD.Controls.Add(labelEstadoActualizarBD);
            groupBoxActualizarBD.Controls.Add(btnActualizarBD);
            groupBoxActualizarBD.Location = new Point(468, 432);
            groupBoxActualizarBD.Name = "groupBoxActualizarBD";
            groupBoxActualizarBD.Size = new Size(576, 77);
            groupBoxActualizarBD.TabIndex = 6;
            groupBoxActualizarBD.TabStop = false;
            groupBoxActualizarBD.Text = "Actualizar Base de Datos";
            // 
            // labelEstadoActualizarBD
            // 
            labelEstadoActualizarBD.AutoSize = true;
            labelEstadoActualizarBD.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEstadoActualizarBD.ForeColor = SystemColors.MenuText;
            labelEstadoActualizarBD.Location = new Point(198, 39);
            labelEstadoActualizarBD.Name = "labelEstadoActualizarBD";
            labelEstadoActualizarBD.Size = new Size(49, 15);
            labelEstadoActualizarBD.TabIndex = 12;
            labelEstadoActualizarBD.Text = "Estado";
            // 
            // btnActualizarBD
            // 
            btnActualizarBD.Location = new Point(6, 26);
            btnActualizarBD.Name = "btnActualizarBD";
            btnActualizarBD.Size = new Size(179, 38);
            btnActualizarBD.TabIndex = 11;
            btnActualizarBD.Text = "Actualizar";
            btnActualizarBD.UseVisualStyleBackColor = true;
            btnActualizarBD.Click += btnActualizarBD_Click;
            // 
            // LabConnect
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 525);
            Controls.Add(groupBoxActualizarBD);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxUltimosDatos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LabConnect";
            Text = "LabConnect";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxUltimosDatos.ResumeLayout(false);
            groupBoxUltimosDatos.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxActualizarBD.ResumeLayout(false);
            groupBoxActualizarBD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private GroupBox groupBox1;
        private Label labelhost;
        private Label label2;
        private TextBox textBoxBaseDatos;
        private TextBox textBoxContrasena;
        private TextBox textBoxUsuario;
        private TextBox textBoxHost;
        private Label labelBaseDatos;
        private Label labelContrasena;
        private Label labelUsuario;
        private Button buttonValidarConexion;
        private Label labelEstadoConexion;
        private GroupBox groupBoxUltimosDatos;
        private Label labelG2Texto;
        private ListBox listBoxUltimosDatos;
        private Button btnActualizarDatos;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxRutaEntrada;
        private ListView listBoxResultados;
        private Label label7;
        private Label labelEstadoMatlab;
        private Button buttonProcesarMatlab;
        private Button buttonGuardarDatos;
        private TextBox textBoxRutaResultados;
        private TextBox textBoxRutaMatlab;
        private GroupBox groupBoxActualizarBD;
        private Label labelEstadoActualizarBD;
        private Button btnActualizarBD;
    }
}
