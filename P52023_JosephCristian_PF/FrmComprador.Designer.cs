namespace P52023_JosephCristian_PF
{
    partial class FrmComprador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTipoComprador = new System.Windows.Forms.ComboBox();
            this.TxtCompradorCorreo = new System.Windows.Forms.TextBox();
            this.TxtCompradorTelefono = new System.Windows.Forms.TextBox();
            this.TxtCompradorCedula = new System.Windows.Forms.TextBox();
            this.TxtCompradorNombre = new System.Windows.Forms.TextBox();
            this.TxtCompradorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxVerCompradoresActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgListaComprador = new System.Windows.Forms.DataGridView();
            this.CCodComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedulaComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreoComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCompradorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaComprador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregar.Location = new System.Drawing.Point(91, 512);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(115, 35);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnModificar.Location = new System.Drawing.Point(253, 512);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(115, 35);
            this.BtnModificar.TabIndex = 26;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(421, 514);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 35);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnLimpiar.Location = new System.Drawing.Point(570, 514);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(115, 35);
            this.BtnLimpiar.TabIndex = 24;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(731, 514);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 35);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTipoComprador);
            this.groupBox1.Controls.Add(this.TxtCompradorCorreo);
            this.groupBox1.Controls.Add(this.TxtCompradorTelefono);
            this.groupBox1.Controls.Add(this.TxtCompradorCedula);
            this.groupBox1.Controls.Add(this.TxtCompradorNombre);
            this.groupBox1.Controls.Add(this.TxtCompradorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 246);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Comprador";
            // 
            // CbTipoComprador
            // 
            this.CbTipoComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoComprador.FormattingEnabled = true;
            this.CbTipoComprador.Location = new System.Drawing.Point(546, 165);
            this.CbTipoComprador.Name = "CbTipoComprador";
            this.CbTipoComprador.Size = new System.Drawing.Size(301, 21);
            this.CbTipoComprador.TabIndex = 16;
            // 
            // TxtCompradorCorreo
            // 
            this.TxtCompradorCorreo.Location = new System.Drawing.Point(546, 59);
            this.TxtCompradorCorreo.Name = "TxtCompradorCorreo";
            this.TxtCompradorCorreo.Size = new System.Drawing.Size(301, 20);
            this.TxtCompradorCorreo.TabIndex = 12;
            // 
            // TxtCompradorTelefono
            // 
            this.TxtCompradorTelefono.Location = new System.Drawing.Point(134, 176);
            this.TxtCompradorTelefono.Name = "TxtCompradorTelefono";
            this.TxtCompradorTelefono.Size = new System.Drawing.Size(253, 20);
            this.TxtCompradorTelefono.TabIndex = 11;
            // 
            // TxtCompradorCedula
            // 
            this.TxtCompradorCedula.Location = new System.Drawing.Point(134, 125);
            this.TxtCompradorCedula.Name = "TxtCompradorCedula";
            this.TxtCompradorCedula.Size = new System.Drawing.Size(253, 20);
            this.TxtCompradorCedula.TabIndex = 10;
            // 
            // TxtCompradorNombre
            // 
            this.TxtCompradorNombre.Location = new System.Drawing.Point(134, 73);
            this.TxtCompradorNombre.Name = "TxtCompradorNombre";
            this.TxtCompradorNombre.Size = new System.Drawing.Size(253, 20);
            this.TxtCompradorNombre.TabIndex = 9;
            // 
            // TxtCompradorID
            // 
            this.TxtCompradorID.Location = new System.Drawing.Point(134, 30);
            this.TxtCompradorID.Name = "TxtCompradorID";
            this.TxtCompradorID.ReadOnly = true;
            this.TxtCompradorID.Size = new System.Drawing.Size(253, 20);
            this.TxtCompradorID.TabIndex = 8;
            this.TxtCompradorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo de Comprador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula del Comprador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Comprador:";
            // 
            // CboxVerCompradoresActivos
            // 
            this.CboxVerCompradoresActivos.AutoSize = true;
            this.CboxVerCompradoresActivos.Checked = true;
            this.CboxVerCompradoresActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerCompradoresActivos.Location = new System.Drawing.Point(596, 22);
            this.CboxVerCompradoresActivos.Name = "CboxVerCompradoresActivos";
            this.CboxVerCompradoresActivos.Size = new System.Drawing.Size(145, 17);
            this.CboxVerCompradoresActivos.TabIndex = 21;
            this.CboxVerCompradoresActivos.Text = "Ver Compradores Activos";
            this.CboxVerCompradoresActivos.UseVisualStyleBackColor = true;
            this.CboxVerCompradoresActivos.CheckedChanged += new System.EventHandler(this.CboxVerCompradoresActivos_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TxtBuscar.Location = new System.Drawing.Point(140, 19);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(387, 20);
            this.TxtBuscar.TabIndex = 20;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar";
            // 
            // DgListaComprador
            // 
            this.DgListaComprador.AllowUserToAddRows = false;
            this.DgListaComprador.AllowUserToDeleteRows = false;
            this.DgListaComprador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaComprador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodComprador,
            this.CNombreComprador,
            this.CCedulaComprador,
            this.CTelefonoComprador,
            this.CCorreoComprador,
            this.CCompradorTipo});
            this.DgListaComprador.Location = new System.Drawing.Point(32, 46);
            this.DgListaComprador.Name = "DgListaComprador";
            this.DgListaComprador.ReadOnly = true;
            this.DgListaComprador.Size = new System.Drawing.Size(903, 214);
            this.DgListaComprador.TabIndex = 28;
            this.DgListaComprador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaComprador_CellClick);
            this.DgListaComprador.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgListaComprador_DataBindingComplete);
            // 
            // CCodComprador
            // 
            this.CCodComprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCodComprador.DataPropertyName = "CompradorID";
            this.CCodComprador.HeaderText = "Cod. Comprador";
            this.CCodComprador.Name = "CCodComprador";
            this.CCodComprador.ReadOnly = true;
            this.CCodComprador.Width = 80;
            // 
            // CNombreComprador
            // 
            this.CNombreComprador.DataPropertyName = "NombreComprador";
            this.CNombreComprador.HeaderText = "Nombre";
            this.CNombreComprador.Name = "CNombreComprador";
            this.CNombreComprador.ReadOnly = true;
            this.CNombreComprador.Width = 120;
            // 
            // CCedulaComprador
            // 
            this.CCedulaComprador.DataPropertyName = "CedulaComprador";
            this.CCedulaComprador.HeaderText = "Cedula";
            this.CCedulaComprador.Name = "CCedulaComprador";
            this.CCedulaComprador.ReadOnly = true;
            // 
            // CTelefonoComprador
            // 
            this.CTelefonoComprador.DataPropertyName = "TelefonoComprador";
            this.CTelefonoComprador.HeaderText = "Telefono";
            this.CTelefonoComprador.Name = "CTelefonoComprador";
            this.CTelefonoComprador.ReadOnly = true;
            this.CTelefonoComprador.Width = 80;
            // 
            // CCorreoComprador
            // 
            this.CCorreoComprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCorreoComprador.DataPropertyName = "CorreoComprador";
            this.CCorreoComprador.HeaderText = "Correo";
            this.CCorreoComprador.Name = "CCorreoComprador";
            this.CCorreoComprador.ReadOnly = true;
            // 
            // CCompradorTipo
            // 
            this.CCompradorTipo.DataPropertyName = "DescripcionTipoComprador";
            this.CCompradorTipo.HeaderText = "Tipo";
            this.CCompradorTipo.Name = "CCompradorTipo";
            this.CCompradorTipo.ReadOnly = true;
            // 
            // FrmComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 566);
            this.Controls.Add(this.DgListaComprador);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CboxVerCompradoresActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmComprador";
            this.Text = "FrmComprador";
            this.Load += new System.EventHandler(this.FrmComprador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaComprador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbTipoComprador;
        private System.Windows.Forms.TextBox TxtCompradorCorreo;
        private System.Windows.Forms.TextBox TxtCompradorTelefono;
        private System.Windows.Forms.TextBox TxtCompradorCedula;
        private System.Windows.Forms.TextBox TxtCompradorNombre;
        private System.Windows.Forms.TextBox TxtCompradorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CboxVerCompradoresActivos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgListaComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedulaComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreoComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompradorTipo;
    }
}