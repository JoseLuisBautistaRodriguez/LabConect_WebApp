namespace LabConnect
{
    partial class LabConnect_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabConnect_frm));
            groupBoxConexion = new GroupBox();
            lblEstadoConexion = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtURL = new TextBox();
            label2 = new Label();
            txtVariable = new TextBox();
            btnConectar = new Button();
            coneccionalsitio = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            grpDatosExtraidos = new GroupBox();
            btnActualiarDatos = new Button();
            lstDatosExtraidos = new ListView();
            lblDatosExtraidos = new Label();
            groupBoxConexion.SuspendLayout();
            grpDatosExtraidos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConexion
            // 
            groupBoxConexion.Controls.Add(lblEstadoConexion);
            groupBoxConexion.Controls.Add(label3);
            groupBoxConexion.Controls.Add(label4);
            groupBoxConexion.Controls.Add(label1);
            groupBoxConexion.Controls.Add(txtURL);
            groupBoxConexion.Controls.Add(label2);
            groupBoxConexion.Controls.Add(txtVariable);
            groupBoxConexion.Controls.Add(btnConectar);
            groupBoxConexion.Location = new Point(18, 81);
            groupBoxConexion.Name = "groupBoxConexion";
            groupBoxConexion.Size = new Size(524, 200);
            groupBoxConexion.TabIndex = 0;
            groupBoxConexion.TabStop = false;
            groupBoxConexion.Text = "Conexión al Sitio";
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoConexion.ForeColor = SystemColors.WindowFrame;
            lblEstadoConexion.Location = new Point(6, 160);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(288, 18);
            lblEstadoConexion.TabIndex = 14;
            lblEstadoConexion.Text = "Estado de la conexión: Sin conexión";
            lblEstadoConexion.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(463, 20);
            label3.TabIndex = 11;
            label3.Text = "Introduce el sitio al que deseas conectarte y la variable de datos que";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 43);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "buscaras.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.AcceptsTab = true;
            txtURL.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtURL.ForeColor = SystemColors.WindowFrame;
            txtURL.Location = new Point(50, 69);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(462, 27);
            txtURL.TabIndex = 4;
            txtURL.Text = "Introduce el sitio web";
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 111);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre de la Variable:";
            // 
            // txtVariable
            // 
            txtVariable.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtVariable.ForeColor = SystemColors.WindowFrame;
            txtVariable.Location = new Point(174, 108);
            txtVariable.Name = "txtVariable";
            txtVariable.Size = new Size(338, 27);
            txtVariable.TabIndex = 5;
            txtVariable.Text = "Introduce la variable de datos";
            txtVariable.TextChanged += txtVariable_TextChanged;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(363, 151);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(149, 34);
            btnConectar.TabIndex = 6;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // coneccionalsitio
            // 
            coneccionalsitio.AutoSize = true;
            coneccionalsitio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            coneccionalsitio.Location = new Point(18, 42);
            coneccionalsitio.Name = "coneccionalsitio";
            coneccionalsitio.Size = new Size(185, 28);
            coneccionalsitio.TabIndex = 3;
            coneccionalsitio.Text = "LabConnect v1.0.0";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(387, 12);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(39, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sitio";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(432, 12);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(86, 20);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Repositorio";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(18, 12);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 13;
            label5.Text = "Proyecto PAPIME PE115224";
            // 
            // grpDatosExtraidos
            // 
            grpDatosExtraidos.Controls.Add(btnActualiarDatos);
            grpDatosExtraidos.Controls.Add(lstDatosExtraidos);
            grpDatosExtraidos.Controls.Add(lblDatosExtraidos);
            grpDatosExtraidos.Location = new Point(18, 291);
            grpDatosExtraidos.Name = "grpDatosExtraidos";
            grpDatosExtraidos.Size = new Size(524, 160);
            grpDatosExtraidos.TabIndex = 14;
            grpDatosExtraidos.TabStop = false;
            grpDatosExtraidos.Text = "Datos Extraidos";
            // 
            // btnActualiarDatos
            // 
            btnActualiarDatos.Location = new Point(363, 24);
            btnActualiarDatos.Name = "btnActualiarDatos";
            btnActualiarDatos.Size = new Size(149, 36);
            btnActualiarDatos.TabIndex = 2;
            btnActualiarDatos.Text = "Actualizar";
            btnActualiarDatos.UseVisualStyleBackColor = true;
            btnActualiarDatos.Click += btnActualiarDatos_Click;
            // 
            // lstDatosExtraidos
            // 
            lstDatosExtraidos.Location = new Point(10, 73);
            lstDatosExtraidos.Name = "lstDatosExtraidos";
            lstDatosExtraidos.Size = new Size(502, 71);
            lstDatosExtraidos.TabIndex = 1;
            lstDatosExtraidos.UseCompatibleStateImageBehavior = false;
            lstDatosExtraidos.SelectedIndexChanged += lstDatosExtraidos_SelectedIndexChanged;
            // 
            // lblDatosExtraidos
            // 
            lblDatosExtraidos.AutoSize = true;
            lblDatosExtraidos.Location = new Point(10, 40);
            lblDatosExtraidos.Name = "lblDatosExtraidos";
            lblDatosExtraidos.Size = new Size(169, 20);
            lblDatosExtraidos.TabIndex = 0;
            lblDatosExtraidos.Text = "Datos extraidosdel sitio:";
            // 
            // LabConnect_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 623);
            Controls.Add(grpDatosExtraidos);
            Controls.Add(label5);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(coneccionalsitio);
            Controls.Add(groupBoxConexion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LabConnect_frm";
            Text = "LabConnect";
            groupBoxConexion.ResumeLayout(false);
            groupBoxConexion.PerformLayout();
            grpDatosExtraidos.ResumeLayout(false);
            grpDatosExtraidos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxConexion;
        private Label coneccionalsitio;
        private TextBox txtURL;
        private TextBox txtVariable;
        private Button btnConectar;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblEstadoConexion;
        private GroupBox grpDatosExtraidos;
        private Label lblDatosExtraidos;
        private Button btnActualiarDatos;
        private ListView lstDatosExtraidos;
    }
}
