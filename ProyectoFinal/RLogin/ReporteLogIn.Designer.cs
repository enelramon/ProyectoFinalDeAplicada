namespace ProyectoFinal.RLogin
{
    partial class ReporteLogIn
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
            this.ReporteLogInViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteLogInViewer
            // 
            this.ReporteLogInViewer.ActiveViewIndex = -1;
            this.ReporteLogInViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteLogInViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteLogInViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteLogInViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteLogInViewer.Name = "ReporteLogInViewer";
            this.ReporteLogInViewer.Size = new System.Drawing.Size(627, 427);
            this.ReporteLogInViewer.TabIndex = 0;
            this.ReporteLogInViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 427);
            this.Controls.Add(this.ReporteLogInViewer);
            this.Name = "ReporteLogIn";
            this.Text = "ReporteLogIn";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteLogInViewer;
    }
}