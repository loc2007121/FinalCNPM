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
        DataTable dataExport_CT = new DataTable("XUATKHO_CT");
        DataTable dataExport = new DataTable("XUATKHO");

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
            command.CommandText = "Select * from XUATKHO";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            DataTable data1 = new DataTable("XK");
            adapter.Fill(data1);
            dataGridView1.DataSource = data1;

        }

        private void formListExport_Load(object sender, EventArgs e)
        {
            PushListExportRecord();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ClassformImport.ExportRecordNumber = dataGridView1.SelectedRows[0].Cells["SoPhieuX"].Value.ToString();
                Close();
            }
        }
    }
}




