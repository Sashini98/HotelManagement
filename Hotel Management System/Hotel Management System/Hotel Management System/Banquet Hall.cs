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
    public partial class Banquet_Hall : MetroFramework.Forms.MetroForm
    {
        public Banquet_Hall()
        {
            InitializeComponent();
        }

        private void t_Click(object sender, EventArgs e){}

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHall.Text == "Hall 1")
            {
                txtHall.Text = "100,000";
                
            }

            else if (cmbHall.Text == "Hall 2")
            {
                txtHall.Text = "125,000";

            }

            else if (cmbHall.Text == "Hall 3")
            {
                txtHall.Text = "150,000";

            }

            else if (cmbHall.Text == "Hall 4")
            {
                txtHall.Text = "175,000";

            }

            else if (cmbHall.Text == "Hall 5")
            {
                txtHall.Text = "200,000";

            }

            else if (cmbHall.Text == "Hall 6")
            {
                txtHall.Text = "225,000";

            }
        }

        private void Banquet_Hall_Load(object sender, EventArgs e)
        {
            cmbHall.Items.Add("Hall 1");
            cmbHall.Items.Add("Hall 2");
            cmbHall.Items.Add("Hall 3");
            cmbHall.Items.Add("Hall 4");
            cmbHall.Items.Add("Hall 5");
            cmbHall.Items.Add("Hall 6");

            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Cheque");
            cmbPayment.Items.Add("Credit Card");
            cmbPayment.Items.Add("Debit Card");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Hotel.accdb");



                string query = "Insert into Banquet values (" + txtIDNum.Text + ",'" + txtName.Text + "','" + txtAddress.Text +  "'," + txtCntNo.Text + ",'" +cmbHall.Text + "'," + txtPpl.Text +  ",'" + txtFrom.Text + "','"+cmbPayment.Text+"','"+txtPayment.Text+ "')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                   con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show(" Success......!!!!");
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void trip_DateDateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = Convert.ToString(trip_DateDateTimePickerFrom.Text);
        }

        private void txtIDNum_Leave(object sender, EventArgs e)
        {
            if (txtIDNum.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtIDNum.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtIDNum,"Wrong Format");
                
                }
            }

                else
                {
                    errWrong.SetError(txtIDNum,"Empty");
                }
            
            }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.TextLength != 0)
            {
                    errWrong.Clear();
            }

            else
            {
                errWrong.SetError(txtName, "Empty");
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.TextLength != 0)
            {
                    errWrong.Clear();
            }

            else
            {
                errWrong.SetError(txtAddress , "Empty");
            }
        }

        private void txtPpl_Leave(object sender, EventArgs e)
        {
            if (txtPpl.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtPpl.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtPpl, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtPpl, "Empty");
            }
        }

        private void txtPayment_Leave(object sender, EventArgs e)
        {
            if (txtPayment.TextLength != 0)
            {
                errWrong.Clear();
            }

            else
            {
                errWrong.SetError(txtPayment, "Empty");
            }
        }

        }

       
        
    }

