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
            groupBox1.SuspendLayout();
            groupBoxUltimosDatos.SuspendLayout();
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
            // LabConnect
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 525);
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
    }
}
