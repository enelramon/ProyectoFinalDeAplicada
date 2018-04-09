namespace ProyectoFinal.rFactura
{
    partial class reporte
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
            this.ReporteDeFacturaViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteDeFacturaViewer
            // 
            this.ReporteDeFacturaViewer.ActiveViewIndex = -1;
            this.ReporteDeFacturaViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteDeFacturaViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteDeFacturaViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteDeFacturaViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteDeFacturaViewer.Name = "ReporteDeFacturaViewer";
            this.ReporteDeFacturaViewer.Size = new System.Drawing.Size(800, 450);
            this.ReporteDeFacturaViewer.TabIndex = 0;
            this.ReporteDeFacturaViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReporteDeFacturaViewer);
            this.Name = "reporte";
            this.Text = "reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteDeFacturaViewer;
    }
}