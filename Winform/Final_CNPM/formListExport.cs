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
    public partial class formListExport : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataImport_CT = new DataTable("NHAPKHO_CT");
        DataTable dataImport = new DataTable("NHAPKHO");

        SqlCommand tempCommand = new SqlCommand();
        SqlDataAdapter tempAdater = new SqlDataAdapter();
        public formListExport()
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
        void PushListExportRecord()
        {
            command.CommandText = "Select * from NHAPKHO";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            DataTable data = new DataTable("NK");
            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void formListExport_Load(object sender, EventArgs e)
        {
            PushListExportRecord();
        }

        private void dataGridViewListImportRecords_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ClassformImport.ImportRecordNumber = dataGridView1.SelectedRows[0].Cells["SoPhieuN"].Value.ToString();
                Close();
            }
        }
    }
}




