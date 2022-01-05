
namespace Final_CNPM
{
    partial class formListImportRecord
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
            this.dataGridViewListImportRecords = new System.Windows.Forms.DataGridView();
            this.SoPhieuN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListImportRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListImportRecords
            // 
            this.dataGridViewListImportRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListImportRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuN,
            this.NguoiNhap,
            this.NgayNhap,
            this.LyDoNhap});
            this.dataGridViewListImportRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListImportRecords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListImportRecords.Name = "dataGridViewListImportRecords";
            this.dataGridViewListImportRecords.RowHeadersWidth = 62;
            this.dataGridViewListImportRecords.RowTemplate.Height = 28;
            this.dataGridViewListImportRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListImportRecords.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewListImportRecords.TabIndex = 0;
            this.dataGridViewListImportRecords.DoubleClick += new System.EventHandler(this.dataGridViewListImportRecords_DoubleClick);
            // 
            // SoPhieuN
            // 
            this.SoPhieuN.DataPropertyName = "SoPhieuN";
            this.SoPhieuN.HeaderText = "ImportRecordNumber";
            this.SoPhieuN.MinimumWidth = 8;
            this.SoPhieuN.Name = "SoPhieuN";
            this.SoPhieuN.ReadOnly = true;
            this.SoPhieuN.Width = 150;
            // 
            // NguoiNhap
            // 
            this.NguoiNhap.DataPropertyName = "NguoiNhap";
            this.NguoiNhap.HeaderText = "Customer";
            this.NguoiNhap.MinimumWidth = 8;
            this.NguoiNhap.Name = "NguoiNhap";
            this.NguoiNhap.ReadOnly = true;
            this.NguoiNhap.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Date Import";
            this.NgayNhap.MinimumWidth = 8;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 150;
            // 
            // LyDoNhap
            // 
            this.LyDoNhap.DataPropertyName = "LyDoNhap";
            this.LyDoNhap.HeaderText = "Reason Import";
            this.LyDoNhap.MinimumWidth = 8;
            this.LyDoNhap.Name = "LyDoNhap";
            this.LyDoNhap.ReadOnly = true;
            this.LyDoNhap.Width = 150;
            // 
            // formListImportRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListImportRecords);
            this.Name = "formListImportRecord";
            this.Text = "formListImportRecord";
            this.Load += new System.EventHandler(this.formListImportRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListImportRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListImportRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoNhap;
    }
}