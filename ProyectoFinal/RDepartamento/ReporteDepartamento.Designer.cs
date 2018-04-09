namespace ProyectoFinal.RDepartamento
{
    partial class ReporteDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteDepartamento));
            this.DepartamentoViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DepartamentoViewer
            // 
            this.DepartamentoViewer.ActiveViewIndex = -1;
            this.DepartamentoViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartamentoViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DepartamentoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartamentoViewer.Location = new System.Drawing.Point(0, 0);
            this.DepartamentoViewer.Name = "DepartamentoViewer";
            this.DepartamentoViewer.Size = new System.Drawing.Size(800, 450);
            this.DepartamentoViewer.TabIndex = 0;
            this.DepartamentoViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartamentoViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteDepartamento";
            this.Text = "Reporte de Departamento";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DepartamentoViewer;
    }
}