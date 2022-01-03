
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tbpImport.SuspendLayout();
            this.tbpExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpImport);
            this.tbcMain.Controls.Add(this.tbpExport);
            this.tbcMain.Controls.Add(this.tbpReport);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1241, 630);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpImport
            // 
            this.tbpImport.Controls.Add(this.label1);
            this.tbpImport.Location = new System.Drawing.Point(4, 29);
            this.tbpImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpImport.Name = "tbpImport";
            this.tbpImport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpImport.Size = new System.Drawing.Size(1233, 597);
            this.tbpImport.TabIndex = 0;
            this.tbpImport.Text = "Create Import Record";
            this.tbpImport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tbpExport
            // 
            this.tbpExport.Controls.Add(this.label2);
            this.tbpExport.Location = new System.Drawing.Point(4, 29);
            this.tbpExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpExport.Name = "tbpExport";
            this.tbpExport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpExport.Size = new System.Drawing.Size(1233, 597);
            this.tbpExport.TabIndex = 1;
            this.tbpExport.Text = "Create Export Record";
            this.tbpExport.UseVisualStyleBackColor = true;
            // 
            // tbpReport
            // 
            this.tbpReport.Location = new System.Drawing.Point(4, 29);
            this.tbpReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpReport.Name = "tbpReport";
            this.tbpReport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpReport.Size = new System.Drawing.Size(1237, 608);
            this.tbpReport.TabIndex = 2;
            this.tbpReport.Text = "Report";
            this.tbpReport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
           
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 630);
            this.Controls.Add(this.tbcMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1263, 686);
            this.MinimumSize = new System.Drawing.Size(1263, 686);
            this.Name = "Main";
            this.Text = "Product Management Application";
            this.tbcMain.ResumeLayout(false);
            this.tbpImport.ResumeLayout(false);
            this.tbpImport.PerformLayout();
            this.tbpExport.ResumeLayout(false);
            this.tbpExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpImport;
        private System.Windows.Forms.TabPage tbpExport;
        private System.Windows.Forms.TabPage tbpReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}