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
    public partial class view_banquet : MetroFramework.Forms.MetroForm
    {
        public view_banquet()
        {
            InitializeComponent();
        }

        private void view_banquet_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Hotel.accdb");

            string query = "select * from Banquet";

            OleDbDataAdapter adt = new OleDbDataAdapter(query, con);
            DataTable dt = new DataTable();

            con.Open();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to go back", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Front newForm = new Front();
                this.Hide();

                newForm.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
