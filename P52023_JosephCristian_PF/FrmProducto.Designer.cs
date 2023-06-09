﻿namespace P52023_JosephCristian_PF
{
    partial class FrmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.TxtProductoCostoUnitario = new System.Windows.Forms.TextBox();
            this.TxtProductoPrecioVentaUnitario = new System.Windows.Forms.TextBox();
            this.TxtProductoStock = new System.Windows.Forms.TextBox();
            this.TxtProductoCodigoBarras = new System.Windows.Forms.TextBox();
            this.TxtProductoNombre = new System.Windows.Forms.TextBox();
            this.TxtProductoID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVentaUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TxtBuscar.Location = new System.Drawing.Point(139, 35);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(387, 20);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(595, 38);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(131, 17);
            this.CboxVerActivos.TabIndex = 3;
            this.CboxVerActivos.Text = "Ver Productos Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbCategoriaProducto);
            this.groupBox1.Controls.Add(this.TxtProductoCostoUnitario);
            this.groupBox1.Controls.Add(this.TxtProductoPrecioVentaUnitario);
            this.groupBox1.Controls.Add(this.TxtProductoStock);
            this.groupBox1.Controls.Add(this.TxtProductoCodigoBarras);
            this.groupBox1.Controls.Add(this.TxtProductoNombre);
            this.groupBox1.Controls.Add(this.TxtProductoID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Producto";
            // 
            // CbCategoriaProducto
            // 
            this.CbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategoriaProducto.FormattingEnabled = true;
            this.CbCategoriaProducto.Location = new System.Drawing.Point(521, 101);
            this.CbCategoriaProducto.Name = "CbCategoriaProducto";
            this.CbCategoriaProducto.Size = new System.Drawing.Size(276, 21);
            this.CbCategoriaProducto.TabIndex = 16;
            // 
            // TxtProductoCostoUnitario
            // 
            this.TxtProductoCostoUnitario.Location = new System.Drawing.Point(86, 214);
            this.TxtProductoCostoUnitario.Multiline = true;
            this.TxtProductoCostoUnitario.Name = "TxtProductoCostoUnitario";
            this.TxtProductoCostoUnitario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProductoCostoUnitario.Size = new System.Drawing.Size(191, 24);
            this.TxtProductoCostoUnitario.TabIndex = 15;
            // 
            // TxtProductoPrecioVentaUnitario
            // 
            this.TxtProductoPrecioVentaUnitario.Location = new System.Drawing.Point(521, 27);
            this.TxtProductoPrecioVentaUnitario.Name = "TxtProductoPrecioVentaUnitario";
            this.TxtProductoPrecioVentaUnitario.Size = new System.Drawing.Size(301, 20);
            this.TxtProductoPrecioVentaUnitario.TabIndex = 12;
            // 
            // TxtProductoStock
            // 
            this.TxtProductoStock.Location = new System.Drawing.Point(86, 173);
            this.TxtProductoStock.Name = "TxtProductoStock";
            this.TxtProductoStock.Size = new System.Drawing.Size(253, 20);
            this.TxtProductoStock.TabIndex = 11;
            // 
            // TxtProductoCodigoBarras
            // 
            this.TxtProductoCodigoBarras.Location = new System.Drawing.Point(91, 120);
            this.TxtProductoCodigoBarras.Name = "TxtProductoCodigoBarras";
            this.TxtProductoCodigoBarras.Size = new System.Drawing.Size(253, 20);
            this.TxtProductoCodigoBarras.TabIndex = 10;
            // 
            // TxtProductoNombre
            // 
            this.TxtProductoNombre.Location = new System.Drawing.Point(86, 71);
            this.TxtProductoNombre.Name = "TxtProductoNombre";
            this.TxtProductoNombre.Size = new System.Drawing.Size(253, 20);
            this.TxtProductoNombre.TabIndex = 9;
            // 
            // TxtProductoID
            // 
            this.TxtProductoID.Location = new System.Drawing.Point(134, 30);
            this.TxtProductoID.Name = "TxtProductoID";
            this.TxtProductoID.ReadOnly = true;
            this.TxtProductoID.Size = new System.Drawing.Size(205, 20);
            this.TxtProductoID.TabIndex = 8;
            this.TxtProductoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Costo Unitario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Categoria de Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio Venta Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo de Barras:";
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
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Producto:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(730, 530);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 35);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnLimpiar.Location = new System.Drawing.Point(569, 530);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(115, 35);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(420, 530);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 35);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnModificar.Location = new System.Drawing.Point(252, 528);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(115, 35);
            this.BtnModificar.TabIndex = 13;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregar.Location = new System.Drawing.Point(90, 528);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(115, 35);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CProductoNombre,
            this.CProductoCodigoBarras,
            this.CCantidadStock,
            this.CCostoUnitario,
            this.CPrecioVentaUnitario,
            this.CCategoriaDescripcion});
            this.DgLista.Location = new System.Drawing.Point(21, 56);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(913, 220);
            this.DgLista.TabIndex = 18;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick_1);
            this.DgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellContentClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete_1);
            // 
            // CProductoID
            // 
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Codigo";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            this.CProductoID.Width = 80;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.HeaderText = "Nombre";
            this.CProductoNombre.Name = "CProductoNombre";
            this.CProductoNombre.ReadOnly = true;
            this.CProductoNombre.Width = 150;
            // 
            // CProductoCodigoBarras
            // 
            this.CProductoCodigoBarras.DataPropertyName = "ProductoCodigoBarras";
            this.CProductoCodigoBarras.HeaderText = "Codigo Barras";
            this.CProductoCodigoBarras.Name = "CProductoCodigoBarras";
            this.CProductoCodigoBarras.ReadOnly = true;
            // 
            // CCantidadStock
            // 
            this.CCantidadStock.DataPropertyName = "CantidadStock";
            this.CCantidadStock.HeaderText = "Stock";
            this.CCantidadStock.Name = "CCantidadStock";
            this.CCantidadStock.ReadOnly = true;
            this.CCantidadStock.Width = 80;
            // 
            // CCostoUnitario
            // 
            this.CCostoUnitario.DataPropertyName = "CostoUnitario";
            this.CCostoUnitario.HeaderText = "Costo Unitario";
            this.CCostoUnitario.Name = "CCostoUnitario";
            this.CCostoUnitario.ReadOnly = true;
            this.CCostoUnitario.Width = 80;
            // 
            // CPrecioVentaUnitario
            // 
            this.CPrecioVentaUnitario.DataPropertyName = "PrecioVentaUnitario";
            this.CPrecioVentaUnitario.HeaderText = "Precio Venta";
            this.CPrecioVentaUnitario.Name = "CPrecioVentaUnitario";
            this.CPrecioVentaUnitario.ReadOnly = true;
            this.CPrecioVentaUnitario.Width = 80;
            // 
            // CCategoriaDescripcion
            // 
            this.CCategoriaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCategoriaDescripcion.DataPropertyName = "CategoriaDescripcion";
            this.CCategoriaDescripcion.HeaderText = "Categoria";
            this.CCategoriaDescripcion.Name = "CCategoriaDescripcion";
            this.CCategoriaDescripcion.ReadOnly = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 575);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmProducto";
            this.Text = "Gestion de Productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbCategoriaProducto;
        private System.Windows.Forms.TextBox TxtProductoCostoUnitario;
        private System.Windows.Forms.TextBox TxtProductoPrecioVentaUnitario;
        private System.Windows.Forms.TextBox TxtProductoStock;
        private System.Windows.Forms.TextBox TxtProductoCodigoBarras;
        private System.Windows.Forms.TextBox TxtProductoNombre;
        private System.Windows.Forms.TextBox TxtProductoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVentaUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoriaDescripcion;
    }
}