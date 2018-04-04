namespace ProyectoFinal.rFactura
{
    partial class ReporteFacturas
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
            this.ReporteFacturaViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteFacturaViewer
            // 
            this.ReporteFacturaViewer.ActiveViewIndex = -1;
            this.ReporteFacturaViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteFacturaViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteFacturaViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteFacturaViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteFacturaViewer.Name = "ReporteFacturaViewer";
            this.ReporteFacturaViewer.Size = new System.Drawing.Size(696, 509);
            this.ReporteFacturaViewer.TabIndex = 0;
            this.ReporteFacturaViewer.Load += new System.EventHandler(this.ReporteFacturaViewer_Load);
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 509);
            this.Controls.Add(this.ReporteFacturaViewer);
            this.Name = "ReporteFactura";
            this.Text = "Reporte de Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteFacturaViewer;
    }
}