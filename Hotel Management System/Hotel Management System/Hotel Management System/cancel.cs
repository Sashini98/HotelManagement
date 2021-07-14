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
    public partial class cancel : MetroFramework.Forms.MetroForm
    {
        public cancel()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void cancel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Hotel.accdb");



                string query = "Delete * from BookRoom where IDNum='" + txtIDNum.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cancelled");
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Hotel.accdb");



                string query = "Delete * from Banquet where IDNum='" + txtIDNum.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cancelled");
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
