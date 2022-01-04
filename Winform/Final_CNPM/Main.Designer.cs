
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
            this.tbpExport = new System.Windows.Forms.TabPage();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxAccountantName = new System.Windows.Forms.TextBox();
            this.tbxProductCode = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxExportRecordNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpReport = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxImportRecordNumber = new System.Windows.Forms.TextBox();
            this.tbxIDImport = new System.Windows.Forms.TextBox();
            this.tbxProductCodeImport = new System.Windows.Forms.TextBox();
            this.tbxReasonCodeImport = new System.Windows.Forms.TextBox();
            this.tbxQuantityImport = new System.Windows.Forms.TextBox();
            this.tbxPriceImport = new System.Windows.Forms.TextBox();
            this.tbpImport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGriViewImport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateImport = new System.Windows.Forms.Button();
            this.btnDeleteImport = new System.Windows.Forms.Button();
            this.btnUpdateImport = new System.Windows.Forms.Button();
            this.btnPhotoImport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTotalImport = new System.Windows.Forms.TextBox();
            this.btnChooseRecordImport = new System.Windows.Forms.Button();
            this.tbxDateCreateImport = new System.Windows.Forms.DateTimePicker();
            this.SoPhieuN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcMain.SuspendLayout();
            this.tbpExport.SuspendLayout();
            this.tbpReport.SuspendLayout();
            this.tbpImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriViewImport)).BeginInit();
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
            // tbpExport
            // 
            this.tbpExport.Controls.Add(this.tbxPrice);
            this.tbpExport.Controls.Add(this.tbxQuantity);
            this.tbpExport.Controls.Add(this.tbxAccountantName);
            this.tbpExport.Controls.Add(this.tbxProductCode);
            this.tbpExport.Controls.Add(this.tbxID);
            this.tbpExport.Controls.Add(this.tbxExportRecordNumber);
            this.tbpExport.Controls.Add(this.label8);
            this.tbpExport.Controls.Add(this.label7);
            this.tbpExport.Controls.Add(this.label6);
            this.tbpExport.Controls.Add(this.label5);
            this.tbpExport.Controls.Add(this.label4);
            this.tbpExport.Controls.Add(this.label3);
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
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(252, 310);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(338, 26);
            this.tbxPrice.TabIndex = 11;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(252, 264);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(338, 26);
            this.tbxQuantity.TabIndex = 10;
            // 
            // tbxAccountantName
            // 
            this.tbxAccountantName.Location = new System.Drawing.Point(252, 218);
            this.tbxAccountantName.Name = "tbxAccountantName";
            this.tbxAccountantName.Size = new System.Drawing.Size(338, 26);
            this.tbxAccountantName.TabIndex = 9;
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.Location = new System.Drawing.Point(252, 172);
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.Size = new System.Drawing.Size(338, 26);
            this.tbxProductCode.TabIndex = 8;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(252, 126);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(338, 26);
            this.tbxID.TabIndex = 7;
            // 
            // tbxExportRecordNumber
            // 
            this.tbxExportRecordNumber.Location = new System.Drawing.Point(252, 80);
            this.tbxExportRecordNumber.Name = "tbxExportRecordNumber";
            this.tbxExportRecordNumber.Size = new System.Drawing.Size(338, 26);
            this.tbxExportRecordNumber.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Accountant Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Export Record Number";
            // 
            // tbpReport
            // 
            this.tbpReport.Controls.Add(this.dataGridView1);
            this.tbpReport.Location = new System.Drawing.Point(4, 29);
            this.tbpReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpReport.Name = "tbpReport";
            this.tbpReport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpReport.Size = new System.Drawing.Size(1233, 597);
            this.tbpReport.TabIndex = 2;
            this.tbpReport.Text = "Report";
            this.tbpReport.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Export Record Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Product Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Reason Import";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price";
            // 
            // tbxImportRecordNumber
            // 
            this.tbxImportRecordNumber.Location = new System.Drawing.Point(254, 81);
            this.tbxImportRecordNumber.Name = "tbxImportRecordNumber";
            this.tbxImportRecordNumber.Size = new System.Drawing.Size(338, 26);
            this.tbxImportRecordNumber.TabIndex = 19;
            // 
            // tbxIDImport
            // 
            this.tbxIDImport.Location = new System.Drawing.Point(254, 127);
            this.tbxIDImport.Name = "tbxIDImport";
            this.tbxIDImport.Size = new System.Drawing.Size(338, 26);
            this.tbxIDImport.TabIndex = 20;
            // 
            // tbxProductCodeImport
            // 
            this.tbxProductCodeImport.Location = new System.Drawing.Point(254, 173);
            this.tbxProductCodeImport.Name = "tbxProductCodeImport";
            this.tbxProductCodeImport.Size = new System.Drawing.Size(338, 26);
            this.tbxProductCodeImport.TabIndex = 21;
            // 
            // tbxReasonCodeImport
            // 
            this.tbxReasonCodeImport.Location = new System.Drawing.Point(254, 219);
            this.tbxReasonCodeImport.Name = "tbxReasonCodeImport";
            this.tbxReasonCodeImport.Size = new System.Drawing.Size(338, 26);
            this.tbxReasonCodeImport.TabIndex = 22;
            // 
            // tbxQuantityImport
            // 
            this.tbxQuantityImport.Location = new System.Drawing.Point(254, 265);
            this.tbxQuantityImport.Name = "tbxQuantityImport";
            this.tbxQuantityImport.Size = new System.Drawing.Size(338, 26);
            this.tbxQuantityImport.TabIndex = 23;
            // 
            // tbxPriceImport
            // 
            this.tbxPriceImport.Location = new System.Drawing.Point(254, 311);
            this.tbxPriceImport.Name = "tbxPriceImport";
            this.tbxPriceImport.Size = new System.Drawing.Size(338, 26);
            this.tbxPriceImport.TabIndex = 24;
            // 
            // tbpImport
            // 
            this.tbpImport.Controls.Add(this.tbxDateCreateImport);
            this.tbpImport.Controls.Add(this.btnChooseRecordImport);
            this.tbpImport.Controls.Add(this.btnTotalImport);
            this.tbpImport.Controls.Add(this.label16);
            this.tbpImport.Controls.Add(this.btnPhotoImport);
            this.tbpImport.Controls.Add(this.btnUpdateImport);
            this.tbpImport.Controls.Add(this.btnDeleteImport);
            this.tbpImport.Controls.Add(this.btnCreateImport);
            this.tbpImport.Controls.Add(this.label1);
            this.tbpImport.Controls.Add(this.dataGriViewImport);
            this.tbpImport.Controls.Add(this.tbxPriceImport);
            this.tbpImport.Controls.Add(this.tbxQuantityImport);
            this.tbpImport.Controls.Add(this.tbxReasonCodeImport);
            this.tbpImport.Controls.Add(this.tbxProductCodeImport);
            this.tbpImport.Controls.Add(this.tbxIDImport);
            this.tbpImport.Controls.Add(this.tbxImportRecordNumber);
            this.tbpImport.Controls.Add(this.label9);
            this.tbpImport.Controls.Add(this.label10);
            this.tbpImport.Controls.Add(this.label11);
            this.tbpImport.Controls.Add(this.label12);
            this.tbpImport.Controls.Add(this.label13);
            this.tbpImport.Controls.Add(this.label14);
            this.tbpImport.Controls.Add(this.label15);
            this.tbpImport.Location = new System.Drawing.Point(4, 29);
            this.tbpImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpImport.Name = "tbpImport";
            this.tbpImport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpImport.Size = new System.Drawing.Size(1233, 597);
            this.tbpImport.TabIndex = 0;
            this.tbpImport.Text = "Create Import Record";
            this.tbpImport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGriViewImport
            // 
            this.dataGriViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriViewImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuN,
            this.STT,
            this.MaHang,
            this.DGNhap,
            this.SLNhap,
            this.ThanhTien});
            this.dataGriViewImport.Location = new System.Drawing.Point(608, 127);
            this.dataGriViewImport.Name = "dataGriViewImport";
            this.dataGriViewImport.RowHeadersWidth = 62;
            this.dataGriViewImport.RowTemplate.Height = 28;
            this.dataGriViewImport.Size = new System.Drawing.Size(617, 396);
            this.dataGriViewImport.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date Create";
            // 
            // btnCreateImport
            // 
            this.btnCreateImport.Location = new System.Drawing.Point(52, 481);
            this.btnCreateImport.Name = "btnCreateImport";
            this.btnCreateImport.Size = new System.Drawing.Size(111, 42);
            this.btnCreateImport.TabIndex = 27;
            this.btnCreateImport.Text = "Create";
            this.btnCreateImport.UseVisualStyleBackColor = true;
            // 
            // btnDeleteImport
            // 
            this.btnDeleteImport.Location = new System.Drawing.Point(480, 481);
            this.btnDeleteImport.Name = "btnDeleteImport";
            this.btnDeleteImport.Size = new System.Drawing.Size(111, 42);
            this.btnDeleteImport.TabIndex = 28;
            this.btnDeleteImport.Text = "Delete";
            this.btnDeleteImport.UseVisualStyleBackColor = true;
            // 
            // btnUpdateImport
            // 
            this.btnUpdateImport.Location = new System.Drawing.Point(266, 481);
            this.btnUpdateImport.Name = "btnUpdateImport";
            this.btnUpdateImport.Size = new System.Drawing.Size(111, 42);
            this.btnUpdateImport.TabIndex = 29;
            this.btnUpdateImport.Text = "Update";
            this.btnUpdateImport.UseVisualStyleBackColor = true;
            // 
            // btnPhotoImport
            // 
            this.btnPhotoImport.Location = new System.Drawing.Point(1114, 81);
            this.btnPhotoImport.Name = "btnPhotoImport";
            this.btnPhotoImport.Size = new System.Drawing.Size(111, 42);
            this.btnPhotoImport.TabIndex = 30;
            this.btnPhotoImport.Text = "Photo";
            this.btnPhotoImport.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(945, 570);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Total ";
            // 
            // btnTotalImport
            // 
            this.btnTotalImport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTotalImport.ForeColor = System.Drawing.Color.Red;
            this.btnTotalImport.Location = new System.Drawing.Point(999, 564);
            this.btnTotalImport.Name = "btnTotalImport";
            this.btnTotalImport.ReadOnly = true;
            this.btnTotalImport.Size = new System.Drawing.Size(226, 26);
            this.btnTotalImport.TabIndex = 32;
            // 
            // btnChooseRecordImport
            // 
            this.btnChooseRecordImport.Location = new System.Drawing.Point(608, 81);
            this.btnChooseRecordImport.Name = "btnChooseRecordImport";
            this.btnChooseRecordImport.Size = new System.Drawing.Size(146, 42);
            this.btnChooseRecordImport.TabIndex = 33;
            this.btnChooseRecordImport.Text = "Choose Record";
            this.btnChooseRecordImport.UseVisualStyleBackColor = true;
            // 
            // tbxDateCreateImport
            // 
            this.tbxDateCreateImport.Location = new System.Drawing.Point(254, 350);
            this.tbxDateCreateImport.Name = "tbxDateCreateImport";
            this.tbxDateCreateImport.Size = new System.Drawing.Size(338, 26);
            this.tbxDateCreateImport.TabIndex = 34;
            // 
            // SoPhieuN
            // 
            this.SoPhieuN.DataPropertyName = "SoPhieuN";
            this.SoPhieuN.HeaderText = "Import Record Number";
            this.SoPhieuN.MinimumWidth = 8;
            this.SoPhieuN.Name = "SoPhieuN";
            this.SoPhieuN.Width = 150;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "ID";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Product Code";
            this.MaHang.MinimumWidth = 8;
            this.MaHang.Name = "MaHang";
            this.MaHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaHang.Width = 210;
            // 
            // DGNhap
            // 
            this.DGNhap.DataPropertyName = "DGNhap";
            this.DGNhap.HeaderText = "Price";
            this.DGNhap.MinimumWidth = 8;
            this.DGNhap.Name = "DGNhap";
            this.DGNhap.Width = 150;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SLNhap";
            this.SLNhap.HeaderText = "Import Quantity";
            this.SLNhap.MinimumWidth = 8;
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Total";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
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
            this.tbpExport.ResumeLayout(false);
            this.tbpExport.PerformLayout();
            this.tbpReport.ResumeLayout(false);
            this.tbpImport.ResumeLayout(false);
            this.tbpImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriViewImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpExport;
        private System.Windows.Forms.TabPage tbpReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxAccountantName;
        private System.Windows.Forms.TextBox tbxProductCode;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxExportRecordNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbpImport;
        private System.Windows.Forms.TextBox tbxPriceImport;
        private System.Windows.Forms.TextBox tbxQuantityImport;
        private System.Windows.Forms.TextBox tbxReasonCodeImport;
        private System.Windows.Forms.TextBox tbxProductCodeImport;
        private System.Windows.Forms.TextBox tbxIDImport;
        private System.Windows.Forms.TextBox tbxImportRecordNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPhotoImport;
        private System.Windows.Forms.Button btnUpdateImport;
        private System.Windows.Forms.Button btnDeleteImport;
        private System.Windows.Forms.Button btnCreateImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGriViewImport;
        private System.Windows.Forms.Button btnChooseRecordImport;
        private System.Windows.Forms.TextBox btnTotalImport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker tbxDateCreateImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}