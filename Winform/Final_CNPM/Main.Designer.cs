
namespace Final_CNPM
{
    partial class Main
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpImport = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpExport = new System.Windows.Forms.TabPage();
            this.tbpReport = new System.Windows.Forms.TabPage();
            this.tbcMain.SuspendLayout();
            this.tbpImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpImport);
            this.tbcMain.Controls.Add(this.tbpExport);
            this.tbcMain.Controls.Add(this.tbpReport);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1107, 513);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpImport
            // 
            this.tbpImport.Controls.Add(this.label1);
            this.tbpImport.Location = new System.Drawing.Point(4, 25);
            this.tbpImport.Name = "tbpImport";
            this.tbpImport.Padding = new System.Windows.Forms.Padding(3);
            this.tbpImport.Size = new System.Drawing.Size(1099, 484);
            this.tbpImport.TabIndex = 0;
            this.tbpImport.Text = "Create Import Record";
            this.tbpImport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tbpExport
            // 
            this.tbpExport.Location = new System.Drawing.Point(4, 25);
            this.tbpExport.Name = "tbpExport";
            this.tbpExport.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExport.Size = new System.Drawing.Size(1099, 484);
            this.tbpExport.TabIndex = 1;
            this.tbpExport.Text = "Create Export Record";
            this.tbpExport.UseVisualStyleBackColor = true;
            // 
            // tbpReport
            // 
            this.tbpReport.Location = new System.Drawing.Point(4, 25);
            this.tbpReport.Name = "tbpReport";
            this.tbpReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReport.Size = new System.Drawing.Size(1099, 484);
            this.tbpReport.TabIndex = 2;
            this.tbpReport.Text = "Report";
            this.tbpReport.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 513);
            this.Controls.Add(this.tbcMain);
            this.MaximumSize = new System.Drawing.Size(1125, 560);
            this.MinimumSize = new System.Drawing.Size(1125, 560);
            this.Name = "Main";
            this.Text = "Product Management Application";
            this.tbcMain.ResumeLayout(false);
            this.tbpImport.ResumeLayout(false);
            this.tbpImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpImport;
        private System.Windows.Forms.TabPage tbpExport;
        private System.Windows.Forms.TabPage tbpReport;
        private System.Windows.Forms.Label label1;
    }
}