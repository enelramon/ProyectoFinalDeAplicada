namespace ProyectoFinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Loginbutton = new System.Windows.Forms.Button();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.UsuariologtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogInerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_Login_32;
            this.Loginbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Loginbutton.Location = new System.Drawing.Point(82, 173);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(130, 49);
            this.Loginbutton.TabIndex = 9;
            this.Loginbutton.Text = "Log in";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(55, 129);
            this.ClavetextBox.MaxLength = 6;
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(190, 20);
            this.ClavetextBox.TabIndex = 8;
            // 
            // UsuariologtextBox
            // 
            this.UsuariologtextBox.Location = new System.Drawing.Point(55, 76);
            this.UsuariologtextBox.Name = "UsuariologtextBox";
            this.UsuariologtextBox.Size = new System.Drawing.Size(190, 20);
            this.UsuariologtextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // LogInerrorProvider
            // 
            this.LogInerrorProvider.ContainerControl = this;
            this.LogInerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("LogInerrorProvider.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(322, 305);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariologtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.LogInerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox UsuariologtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider LogInerrorProvider;
    }
}

