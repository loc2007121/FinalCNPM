
namespace Final_CNPM
{
    partial class formListExport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDoXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuX,
            this.TenTKDaiLy,
            this.NgayXuat,
            this.LiDoXuat});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // SoPhieuX
            // 
            this.SoPhieuX.DataPropertyName = "SoPhieuX";
            this.SoPhieuX.HeaderText = "ExportRecordNumber";
            this.SoPhieuX.MinimumWidth = 8;
            this.SoPhieuX.Name = "SoPhieuX";
            this.SoPhieuX.Width = 150;
            // 
            // TenTKDaiLy
            // 
            this.TenTKDaiLy.DataPropertyName = "TenTKDaiLy";
            this.TenTKDaiLy.HeaderText = "Customer";
            this.TenTKDaiLy.MinimumWidth = 8;
            this.TenTKDaiLy.Name = "TenTKDaiLy";
            this.TenTKDaiLy.Width = 150;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Date Export";
            this.NgayXuat.MinimumWidth = 8;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Width = 150;
            // 
            // LiDoXuat
            // 
            this.LiDoXuat.DataPropertyName = "LiDoXuat";
            this.LiDoXuat.HeaderText = "Reason Export";
            this.LiDoXuat.MinimumWidth = 8;
            this.LiDoXuat.Name = "LiDoXuat";
            this.LiDoXuat.Width = 150;
            // 
            // formListExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formListExport";
            this.Text = "formListExport";
            this.Load += new System.EventHandler(this.formListExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDoXuat;
    }
}