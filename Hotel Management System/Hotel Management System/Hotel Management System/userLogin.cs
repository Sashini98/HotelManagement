using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_Management_System
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Hotel.accdb");
            OleDbDataAdapter adt = new OleDbDataAdapter("Select Count(*) from Employee where EmpId='" + txtId.Text + "' and Password='" + txtPasswrd.Text + "'", con);
            DataTable dt = new DataTable();

            adt.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Front newForm = new Front();
                this.Hide();

                newForm.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Please check your Employee ID and password");
            }
        }
    }
}
