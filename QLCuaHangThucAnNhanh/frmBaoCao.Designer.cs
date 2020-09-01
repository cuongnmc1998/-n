namespace QLCuaHangThucAnNhanh
{
    partial class frmBaoCao
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
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(1039, 486);
            this.rpvBaoCao.TabIndex = 0;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 486);
            this.Controls.Add(this.rpvBaoCao);
            this.Name = "frmBaoCao";
            this.Text = "Báo Cáo Thống Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
    }
}