namespace ProyectoFinal.Productos
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DemasCamposerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepartamentocomboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.COnsultabutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemasCamposerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DepartamentoId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(102, 167);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(139, 20);
            this.DescripciontextBox.TabIndex = 5;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(102, 29);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.IdnumericUpDown.TabIndex = 6;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(102, 65);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.PrecionumericUpDown.TabIndex = 7;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(102, 91);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.CantidadnumericUpDown.TabIndex = 9;
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            this.IderrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("IderrorProvider.Icon")));
            // 
            // DemasCamposerrorProvider
            // 
            this.DemasCamposerrorProvider.ContainerControl = this;
            this.DemasCamposerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("DemasCamposerrorProvider.Icon")));
            // 
            // DepartamentocomboBox
            // 
            this.DepartamentocomboBox.FormattingEnabled = true;
            this.DepartamentocomboBox.Location = new System.Drawing.Point(101, 126);
            this.DepartamentocomboBox.Name = "DepartamentocomboBox";
            this.DepartamentocomboBox.Size = new System.Drawing.Size(140, 21);
            this.DepartamentocomboBox.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Image = global::ProyectoFinal.Properties.Resources.icons8_Search_16;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(166, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Buscar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // COnsultabutton
            // 
            this.COnsultabutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Brief_321;
            this.COnsultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.COnsultabutton.Location = new System.Drawing.Point(274, 236);
            this.COnsultabutton.Name = "COnsultabutton";
            this.COnsultabutton.Size = new System.Drawing.Size(80, 51);
            this.COnsultabutton.TabIndex = 13;
            this.COnsultabutton.Text = "Consulta";
            this.COnsultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.COnsultabutton.UseVisualStyleBackColor = true;
            this.COnsultabutton.Click += new System.EventHandler(this.COnsultabutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.Location = new System.Drawing.Point(188, 236);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 51);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(102, 236);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 51);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Add_New_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 236);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 51);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(388, 299);
            this.Controls.Add(this.DepartamentocomboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.COnsultabutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rProductos";
            this.Text = "Registro de Productos ";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemasCamposerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button COnsultabutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
        private System.Windows.Forms.ErrorProvider DemasCamposerrorProvider;
        private System.Windows.Forms.ComboBox DepartamentocomboBox;
    }
}