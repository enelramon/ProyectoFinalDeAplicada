namespace ProyectoFinal.RCliente
{
    partial class ReporteCliente
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
            this.ReporteClienteViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteClienteViewer
            // 
            this.ReporteClienteViewer.ActiveViewIndex = -1;
            this.ReporteClienteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteClienteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteClienteViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteClienteViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteClienteViewer.Name = "ReporteClienteViewer";
            this.ReporteClienteViewer.Size = new System.Drawing.Size(737, 430);
            this.ReporteClienteViewer.TabIndex = 0;
            this.ReporteClienteViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 430);
            this.Controls.Add(this.ReporteClienteViewer);
            this.Name = "ReporteCliente";
            this.Text = "Reporte de Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteClienteViewer;
    }
}