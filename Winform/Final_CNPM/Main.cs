using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_CNPM
{
    public partial class Main : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataImport_CT = new DataTable("NHAPKHO_CT"); 
        DataTable dataImport = new DataTable("NHAPKHO");

        DataTable dataExport_CT = new DataTable("XUATKHO_CT");
        DataTable dataExport = new DataTable("XUATKHO");

        SqlCommand tempCommand = new SqlCommand();
        SqlDataAdapter tempAdater = new SqlDataAdapter();
        SqlDataAdapter adapterExport = new SqlDataAdapter();
        SqlDataAdapter adapterChoose = new SqlDataAdapter();
        int position;


        public Main()
        {
            InitializeComponent();
            connection.ConnectionString = Properties.Settings.Default.ConnectionString.ToString();
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            command.Connection = connection;
            tempCommand.Connection = connection;
        }

        void PushCompany()
        {
            tempCommand.CommandText = "SELECT TenDangNhap, TenDaiLy FROM DAILY";
            tempCommand.Parameters.Clear();
            tempAdater.SelectCommand = tempCommand;
            DataTable dataCompany = new DataTable("DL");
            tempAdater.Fill(dataCompany);
            tbxCustomer.DataSource = dataCompany;
            tbxCustomer.ValueMember = "TenDangNhap";
            tbxCustomer.DisplayMember = "TenDaiLy";

        }

        void PushProductCode()
        {
            tempCommand.CommandText = "SELECT MaHang, TenHang FROM HANGHOA";
            tempCommand.Parameters.Clear();
            tempAdater.SelectCommand = tempCommand;
            DataTable dataProduct = new DataTable("HH");
            tempAdater.Fill(dataProduct);
            MaHang.DataSource = dataProduct;
            MaHang.ValueMember = "MaHang";
            MaHang.DisplayMember = "TenHang";
        }

        void PushCTImportRecord(string spx)
        {

            PushProductCode();
            command.CommandText = "Select SoPhieuN, STT, MaHang, SLNhap, DGNHap,TKNguoiNhap, SLNhap*DGNhap as ThanhTien From NHAPKHO_CT Where SoPhieuN = @SPN";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@SPN", spx);
            adapter.SelectCommand = command;
            dataImport_CT.Clear();
            adapter.Fill(dataImport_CT);
            dataGriViewImport.DataSource = dataImport_CT;

            double total = 0;
            for(int i = 0; i < dataImport_CT.Rows.Count; i++)
            {
                //double quantity = Convert.ToDouble(dataImport_CT.Rows[i]["SLNhap"]);
                total += Convert.ToDouble(dataImport_CT.Rows[i]["SLNhap"]) * Convert.ToDouble(dataImport_CT.Rows[i]["DGNhap"]);

            }
            tbxTotalImport.Text = total.ToString();
        }

        void PushOneImportRecord(string spn)
        {
            tempCommand.CommandText = "Select * From NHAPKHO Where SoPhieuN = @SPN";
            tempCommand.Parameters.Clear();
            tempCommand.Parameters.AddWithValue("@SPN", spn);
            tempAdater.SelectCommand = tempCommand;
            DataTable dataImport = new DataTable("OneImportRecord");
            tempAdater.Fill(dataImport);
            if(dataImport.Rows.Count > 0)
            {
                tbxImportRecordNumber.Text = dataImport.Rows[0]["SoPhieuN"].ToString();
                tbxDateCreateImport.Value = Convert.ToDateTime(dataImport.Rows[0]["NgayNhap"]);
                tbxCompany.Text = dataImport.Rows[0]["NguoiNhap"].ToString();
                tbxReasonCodeImport.Text = dataImport.Rows[0]["LyDoNhap"].ToString();

            }
        }

        void PushImportRecords()
        {
            tempCommand.CommandText = "Select * From NHAPKHO";
            tempCommand.Parameters.Clear();
            tempAdater.SelectCommand = tempCommand;
            dataImport.Clear();
            tempAdater.Fill(dataImport);
        }

        void MoveToImportRecord(int i)
        {
            tbxImportRecordNumber.Text = dataImport.Rows[i]["SoPhieuN"].ToString();
            tbxDateCreateImport.Value = Convert.ToDateTime(dataImport.Rows[i]["NgayNhap"]);
            tbxCompany.Text = dataImport.Rows[i]["NguoiNhap"].ToString();
            tbxReasonCodeImport.Text = dataImport.Rows[i]["LyDoNhap"].ToString();

        }

        private void dataGriViewImport_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGriViewImport.Rows[e.Row.Index - 1].Cells["SoPhieuN"].Value = tbxImportRecordNumber.Text;
        }





        private void btnFirstExport_Click(object sender, EventArgs e)
        {
            if (dataExport.Rows.Count>0)
            {
                position = 0;
                MoveToExportRecord(position);
                PushCTExportRecord(tbxExportRecordNumber.Text.ToString());

            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if(dataImport.Rows.Count > 0)
            {
                position = 0;
                MoveToImportRecord(position);
                PushCTImportRecord(tbxImportRecordNumber.Text.ToString());
               
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if(position < dataImport.Rows.Count)
            {
                position = dataImport.Rows.Count - 1;
                MoveToImportRecord(position);
                PushCTImportRecord(tbxImportRecordNumber.Text.ToString());
                
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(position > 0)
            {
                position -= 1;
                MoveToImportRecord(position);
                PushCTImportRecord(tbxImportRecordNumber.Text.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position < dataImport.Rows.Count - 1)
            {
                position += 1;
                MoveToImportRecord(position);
                PushCTImportRecord(tbxImportRecordNumber.Text.ToString());
                
            }
        }

        private void btnChooseRecordImport_Click(object sender, EventArgs e)
        {
            formListImportRecord form = new formListImportRecord();
            form.ShowDialog();
            if(ClassformImport.ImportRecordNumber != null)
            {
                PushOneImportRecord(ClassformImport.ImportRecordNumber);
                PushCTImportRecord(ClassformImport.ImportRecordNumber);
            }
        }

        private void btnCreateImport_Click(object sender, EventArgs e)
        {

            tempCommand.CommandText = "Insert into NHAPKHO values(" + "N'" + tbxImportRecordNumber.Text + "', '" + tbxDateCreateImport.Value.Date + "', N'" + tbxCompany.Text + "', N'" + tbxReasonCodeImport.Text + "')";
            tempCommand.ExecuteNonQuery();
            MessageBox.Show("You have created a Import Record Numver");
            PushImportRecords();
            PushCTImportRecord(tbxImportRecordNumber.Text);


        }

        void PushCustomer()
        {
            tempCommand.CommandText = "SELECT TenDangNhap, TenDaiLy FROM DAILY";
            tempCommand.Parameters.Clear();
            tempAdater.SelectCommand = tempCommand;
            DataTable dataCompany = new DataTable("DL");
            tempAdater.Fill(dataCompany);
            tbxCustomer.DataSource = dataCompany;
            tbxCustomer.ValueMember = "TenDangNhap";
            tbxCustomer.DisplayMember = "TenDaiLy";

        }

     
        

        void PushCTExportRecord(string spx)
        {

            PushProductCode();
            command.CommandText = "Select SoPhieuX, STT, MaHang, TKNguoiXuat, SLXuat, DGXuat, SLXuat * DGXuat as ThanhTienX From XUATKHO_CT Where SoPhieuX = @SPX";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@SPX", spx);
            adapterExport.SelectCommand = command;
            dataExport_CT.Clear();
            adapterExport.Fill(dataExport_CT);
            dataGridViewExport.DataSource = dataExport_CT;

            double total = 0;
            for (int i = 0; i < dataExport_CT.Rows.Count; i++)
            {
                
                total += Convert.ToDouble(dataExport_CT.Rows[i]["SLXuat"]) * Convert.ToDouble(dataExport_CT.Rows[i]["DGXuat"]);

            }
            tbxTotalExport.Text = total.ToString();
        }

        void PushOneExportRecord(string spx)
        {
            tempCommand.CommandText = "Select * From XUATKHO Where SoPhieuX = @SPX";
            tempCommand.Parameters.Clear();
            tempCommand.Parameters.AddWithValue("@SPX", spx);
            tempAdater.SelectCommand = tempCommand;
            DataTable dataExport = new DataTable("OneExportRecord");
            tempAdater.Fill(dataExport);
            if (dataExport.Rows.Count > 0)
            {
                tbxExportRecordNumber.Text = dataExport.Rows[0]["SoPhieuX"].ToString();
                dateTimeExport.Value = Convert.ToDateTime(dataExport.Rows[0]["NgayXuat"]);
                tbxCustomer.Text = dataExport.Rows[0]["TenTKDaiLy"].ToString();
                tbxReasonExport.Text = dataExport.Rows[0]["LyDoXuat"].ToString();

            }
        }

        void PushExportRecords()
        {
            tempCommand.CommandText = "Select * From XUATKHO";
            tempCommand.Parameters.Clear();
            tempAdater.SelectCommand = tempCommand;
            dataExport.Clear();
            tempAdater.Fill(dataExport);
        }

        void MoveToExportRecord(int i)
        {
            tbxExportRecordNumber.Text = dataExport.Rows[i]["SoPhieuX"].ToString();
            dateTimeExport.Value = Convert.ToDateTime(dataExport.Rows[i]["NgayXuat"]);
            tbxCustomer.Text = dataExport.Rows[i]["TenTKDaiLy"].ToString();
            tbxReasonExport.Text = dataExport.Rows[i]["LyDoXuat"].ToString();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            PushCustomer();
            PushExportRecords();
            if (dataExport.Rows.Count > 0)
            {
                position = 0;
                MoveToExportRecord(position);
                PushCTExportRecord(tbxExportRecordNumber.Text.ToString());
            }
            PushCompany();
            PushImportRecords();
            if (dataImport.Rows.Count > 0)
            {
                position = 0;
                MoveToImportRecord(position);
                PushCTImportRecord(tbxImportRecordNumber.Text.ToString());
            }


        }
     

        private void btnLastExport_Click(object sender, EventArgs e)
        {
            if (position < dataExport.Rows.Count)
            {
                position = dataExport.Rows.Count - 1;
                MoveToExportRecord(position);
                PushCTExportRecord(tbxExportRecordNumber.Text.ToString());

            }
        }

        private void btnPreviousExport_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position -= 1;
                MoveToExportRecord(position);
                PushCTExportRecord(tbxExportRecordNumber.Text.ToString());
            }
        }

        private void btnNextExport_Click(object sender, EventArgs e)
        {
            if (position < dataExport.Rows.Count - 1)
            {
                position += 1;
                MoveToExportRecord(position);
                PushCTExportRecord(tbxExportRecordNumber.Text.ToString());

            }
        }

        private void btnChooseRecordExport_Click(object sender, EventArgs e)
        {
            formListExport form = new formListExport();
            form.ShowDialog();
            if (ClassformImport.ExportRecordNumber != null)
            {
                PushOneExportRecord(ClassformImport.ExportRecordNumber);
                PushCTExportRecord(ClassformImport.ExportRecordNumber);
            }
        }

        private void btnCreateExport_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dateTimeExport.Text);
            tempCommand.CommandText = "Insert into XUATKHO values(" + "N'" + tbxExportRecordNumber.Text + "', '" + dateTimeExport.Value.Date + "', N'" + tbxCustomer.Text + "', N'" + tbxReasonExport.Text + "')";
            tempCommand.ExecuteNonQuery();
            MessageBox.Show("You have created a Export Record Numver");

            PushExportRecords();
            PushCTExportRecord(tbxExportRecordNumber.Text);

        }

        private void dataGriViewImport_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(dataGriViewImport.Rows[e.RowIndex].Cells["SLNhap"].Value) * Convert.ToDouble(dataGriViewImport.Rows[e.RowIndex].Cells["DGNhap"].Value);
                dataGriViewImport.Rows[e.RowIndex].Cells["ThanhTien"].Value = total;


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataImport_CT);
            }
            catch { }
        }

        private void dataGridViewExport_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridViewExport.Rows[e.Row.Index - 1].Cells["SoPhieuX"].Value = tbxExportRecordNumber.Text;
        }

        private void dataGridViewExport_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(dataGridViewExport.Rows[e.RowIndex].Cells["SLXuat"].Value) * Convert.ToDouble(dataGridViewExport.Rows[e.RowIndex].Cells["DGXuat"].Value);
                dataGridViewExport.Rows[e.RowIndex].Cells["ThanhTienX"].Value = total;


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterExport);
                adapterExport.Update(dataExport_CT);
            }
            catch { }
        }
    }
}


