using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_CNPM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-GK0E5D1\SQLEXPRESS;Initial Catalog=QuanLiHangHoa;Integrated Security=True");// Change connecttion string here
            string query = "Select * from KETOAN where TenDangNhap = '" + tbxUserName.Text.Trim() + "'and MatKhau = '" + tbxPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                Main formMain = new Main();
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                tbxUserName.Text = "";
                tbxPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
