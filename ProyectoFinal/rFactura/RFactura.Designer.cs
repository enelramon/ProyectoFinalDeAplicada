namespace ProyectoFinal.rFactura
{
    partial class RFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.FormaDePagocomboBox = new System.Windows.Forms.ComboBox();
            this.DescripciponFacturatextBox = new System.Windows.Forms.TextBox();
            this.FacturadataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfectivonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.Importe = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.IDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DemaserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NUevobutton = new System.Windows.Forms.Button();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.DetallecomboBox = new System.Windows.Forms.ComboBox();
            this.ProductoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.CLienteIDcomboBox = new System.Windows.Forms.ComboBox();
            this.IDcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NombreCLientetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ClienteId";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Forma de pago";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Devuelta";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Efectivo Recibido";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechadateTimePicker.Location = new System.Drawing.Point(398, 46);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // FormaDePagocomboBox
            // 
            this.FormaDePagocomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormaDePagocomboBox.FormattingEnabled = true;
            this.FormaDePagocomboBox.Location = new System.Drawing.Point(98, 95);
            this.FormaDePagocomboBox.Name = "FormaDePagocomboBox";
            this.FormaDePagocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FormaDePagocomboBox.TabIndex = 15;
            this.FormaDePagocomboBox.SelectedIndexChanged += new System.EventHandler(this.FormaDePagocomboBox_SelectedIndexChanged);
            // 
            // DescripciponFacturatextBox
            // 
            this.DescripciponFacturatextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripciponFacturatextBox.Location = new System.Drawing.Point(98, 159);
            this.DescripciponFacturatextBox.Multiline = true;
            this.DescripciponFacturatextBox.Name = "DescripciponFacturatextBox";
            this.DescripciponFacturatextBox.Size = new System.Drawing.Size(299, 89);
            this.DescripciponFacturatextBox.TabIndex = 16;
            // 
            // FacturadataGridView
            // 
            this.FacturadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FacturadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Cantidad,
            this.Precio,
            this.Descripcion,
            this.FacturaId,
            this.Id,
            this.ImporteDg});
            this.FacturadataGridView.Location = new System.Drawing.Point(12, 335);
            this.FacturadataGridView.Name = "FacturadataGridView";
            this.FacturadataGridView.Size = new System.Drawing.Size(593, 210);
            this.FacturadataGridView.TabIndex = 17;
            // 
            // ProductoId
            // 
            this.ProductoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 60;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // FacturaId
            // 
            this.FacturaId.DataPropertyName = "FacturaId";
            this.FacturaId.HeaderText = "FacturaId";
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            this.FacturaId.Width = 60;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // ImporteDg
            // 
            this.ImporteDg.DataPropertyName = "Importe";
            this.ImporteDg.HeaderText = "Importe";
            this.ImporteDg.Name = "ImporteDg";
            this.ImporteDg.ReadOnly = true;
            this.ImporteDg.Width = 70;
            // 
            // EfectivonumericUpDown
            // 
            this.EfectivonumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EfectivonumericUpDown.Location = new System.Drawing.Point(175, 592);
            this.EfectivonumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.EfectivonumericUpDown.Name = "EfectivonumericUpDown";
            this.EfectivonumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.EfectivonumericUpDown.TabIndex = 18;
            this.EfectivonumericUpDown.ValueChanged += new System.EventHandler(this.EfectivonumericUpDown_ValueChanged);
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DevueltatextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DevueltatextBox.Location = new System.Drawing.Point(325, 592);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.ReadOnly = true;
            this.DevueltatextBox.Size = new System.Drawing.Size(87, 20);
            this.DevueltatextBox.TabIndex = 19;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MontotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MontotextBox.Location = new System.Drawing.Point(475, 592);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(87, 20);
            this.MontotextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "ID Detalle";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImportetextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImportetextBox.Location = new System.Drawing.Point(475, 299);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 50;
            // 
            // Importe
            // 
            this.Importe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(426, 302);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 49;
            this.Importe.Text = "Importe";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Agregarbutton.Location = new System.Drawing.Point(359, 296);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(53, 23);
            this.Agregarbutton.TabIndex = 48;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PreciotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PreciotextBox.Location = new System.Drawing.Point(475, 264);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Descripcion";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripcionProductotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(235, 264);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(212, 20);
            this.DescripcionProductotextBox.TabIndex = 44;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(287, 298);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.CantidadnumericUpDown.TabIndex = 42;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "ProductoId";
            // 
            // IDerrorProvider
            // 
            this.IDerrorProvider.ContainerControl = this;
            this.IDerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("IDerrorProvider.Icon")));
            // 
            // DemaserrorProvider
            // 
            this.DemaserrorProvider.ContainerControl = this;
            this.DemaserrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("DemaserrorProvider.Icon")));
            // 
            // ProductoerrorProvider
            // 
            this.ProductoerrorProvider.ContainerControl = this;
            this.ProductoerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ProductoerrorProvider.Icon")));
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.Location = new System.Drawing.Point(327, 634);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(82, 44);
            this.Eliminarbutton.TabIndex = 23;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(224, 634);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(82, 44);
            this.Guardarbutton.TabIndex = 22;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NUevobutton
            // 
            this.NUevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NUevobutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Add_New_32;
            this.NUevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NUevobutton.Location = new System.Drawing.Point(121, 634);
            this.NUevobutton.Name = "NUevobutton";
            this.NUevobutton.Size = new System.Drawing.Size(82, 44);
            this.NUevobutton.TabIndex = 21;
            this.NUevobutton.Text = "Nuevo";
            this.NUevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NUevobutton.UseVisualStyleBackColor = true;
            this.NUevobutton.Click += new System.EventHandler(this.NUevobutton_Click);
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuariotextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UsuariotextBox.Location = new System.Drawing.Point(25, 592);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(87, 20);
            this.UsuariotextBox.TabIndex = 55;
            // 
            // DetallecomboBox
            // 
            this.DetallecomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetallecomboBox.Enabled = false;
            this.DetallecomboBox.FormattingEnabled = true;
            this.DetallecomboBox.Location = new System.Drawing.Point(92, 298);
            this.DetallecomboBox.Name = "DetallecomboBox";
            this.DetallecomboBox.Size = new System.Drawing.Size(111, 21);
            this.DetallecomboBox.TabIndex = 56;
            this.DetallecomboBox.SelectedIndexChanged += new System.EventHandler(this.DetallecomboBox_SelectedIndexChanged);
            // 
            // ProductoIdcomboBox
            // 
            this.ProductoIdcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductoIdcomboBox.FormattingEnabled = true;
            this.ProductoIdcomboBox.Location = new System.Drawing.Point(92, 264);
            this.ProductoIdcomboBox.Name = "ProductoIdcomboBox";
            this.ProductoIdcomboBox.Size = new System.Drawing.Size(111, 21);
            this.ProductoIdcomboBox.TabIndex = 57;
            this.ProductoIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoIdcomboBox_SelectedIndexChanged);
            // 
            // CLienteIDcomboBox
            // 
            this.CLienteIDcomboBox.FormattingEnabled = true;
            this.CLienteIDcomboBox.Location = new System.Drawing.Point(98, 60);
            this.CLienteIDcomboBox.Name = "CLienteIDcomboBox";
            this.CLienteIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CLienteIDcomboBox.TabIndex = 58;
            this.CLienteIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.CLienteIDcomboBox_SelectedIndexChanged);
            // 
            // IDcomboBox
            // 
            this.IDcomboBox.FormattingEnabled = true;
            this.IDcomboBox.Location = new System.Drawing.Point(98, 30);
            this.IDcomboBox.Name = "IDcomboBox";
            this.IDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.IDcomboBox.TabIndex = 59;
            this.IDcomboBox.SelectedIndexChanged += new System.EventHandler(this.IDcomboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Nombre CLiente";
            // 
            // NombreCLientetextBox
            // 
            this.NombreCLientetextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NombreCLientetextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NombreCLientetextBox.Location = new System.Drawing.Point(98, 126);
            this.NombreCLientetextBox.Name = "NombreCLientetextBox";
            this.NombreCLientetextBox.ReadOnly = true;
            this.NombreCLientetextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreCLientetextBox.TabIndex = 61;
            // 
            // RFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(610, 698);
            this.Controls.Add(this.NombreCLientetextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IDcomboBox);
            this.Controls.Add(this.CLienteIDcomboBox);
            this.Controls.Add(this.ProductoIdcomboBox);
            this.Controls.Add(this.DetallecomboBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DescripcionProductotextBox);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NUevobutton);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.DevueltatextBox);
            this.Controls.Add(this.EfectivonumericUpDown);
            this.Controls.Add(this.FacturadataGridView);
            this.Controls.Add(this.DescripciponFacturatextBox);
            this.Controls.Add(this.FormaDePagocomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RFactura";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FormaDePagocomboBox;
        private System.Windows.Forms.TextBox DescripciponFacturatextBox;
        private System.Windows.Forms.DataGridView FacturadataGridView;
        private System.Windows.Forms.NumericUpDown EfectivonumericUpDown;
        private System.Windows.Forms.TextBox DevueltatextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Button NUevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider IDerrorProvider;
        private System.Windows.Forms.ErrorProvider DemaserrorProvider;
        private System.Windows.Forms.ErrorProvider ProductoerrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDg;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.ComboBox DetallecomboBox;
        private System.Windows.Forms.ComboBox ProductoIdcomboBox;
        private System.Windows.Forms.ComboBox IDcomboBox;
        private System.Windows.Forms.ComboBox CLienteIDcomboBox;
        private System.Windows.Forms.TextBox NombreCLientetextBox;
        private System.Windows.Forms.Label label10;
    }
}