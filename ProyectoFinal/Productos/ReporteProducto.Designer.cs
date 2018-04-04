namespace ProyectoFinal.Productos
{
    partial class ReporteProducto
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
            this.ReporteProductoViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteProductoViewer
            // 
            this.ReporteProductoViewer.ActiveViewIndex = -1;
            this.ReporteProductoViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteProductoViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteProductoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteProductoViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteProductoViewer.Name = "ReporteProductoViewer";
            this.ReporteProductoViewer.Size = new System.Drawing.Size(656, 477);
            this.ReporteProductoViewer.TabIndex = 0;
            this.ReporteProductoViewer.Load += new System.EventHandler(this.ReporteProductoViewer_Load);
            // 
            // ReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 477);
            this.Controls.Add(this.ReporteProductoViewer);
            this.Name = "ReporteProducto";
            this.Text = "Reporte de Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteProductoViewer;
    }
}