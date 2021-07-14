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
    public partial class Book : MetroFramework.Forms.MetroForm
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            cmbRoomType.Items.Add("Single-Standard");
            cmbRoomType.Items.Add("Double-Standard");
            cmbRoomType.Items.Add("Triple-Standard");
            cmbRoomType.Items.Add("Quadraple-Standard");
            cmbRoomType.Items.Add("Family-Standard");
            cmbRoomType.Items.Add("Single-Superior");
            cmbRoomType.Items.Add("Double-Superior");
            cmbRoomType.Items.Add("Triple-Superior");
            cmbRoomType.Items.Add("Quadraple-Superior");
            cmbRoomType.Items.Add("Family-Superior");
            cmbRoomType.Items.Add("Single-Delux");
            cmbRoomType.Items.Add("Double-Delux");
            cmbRoomType.Items.Add("Triple-Delux");
            cmbRoomType.Items.Add("Quadraple-Delux");
            cmbRoomType.Items.Add("Family-Delux");


            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Hotel.accdb");



                string query = "Insert into BookRoom values (" + txtIDNum.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "','" + txtCountry.Text + "'," + txtCntNo.Text + ",'" + txtGender.Text + "','" + cmbRoomType.Text + "'," + txtMale.Text + "," + txtFemale.Text + "," + txtKids.Text + ",'" + txtFrom.Text + "','" + txtTo.Text +"')";
                OleDbCommand cmd = new OleDbCommand(query, con);



                con.Open();




                cmd.ExecuteNonQuery();

                MessageBox.Show("Room Booking Success......!!!!");
                con.Close();
    
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGender.Text = Convert.ToString(cmbGender.Text);
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

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

        private void trip_DateDateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = Convert.ToString(trip_DateDateTimePickerTo.Text);
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
                    errWrong.SetError(txtIDNum, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtIDNum, "Empty");
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
                errWrong.SetError(txtAddress, "Empty");
            }
        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            if (txtCountry.TextLength != 0)
            {
                errWrong.Clear();
            }

            else
            {
                errWrong.SetError(txtCountry, "Empty");
            }
        }

        private void txtCntNo_Leave(object sender, EventArgs e)
        {
            if (txtCntNo.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtCntNo.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtCntNo, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtCntNo, "Empty");
            }
        }

        private void Book_Leave(object sender, EventArgs e)
        {

        }

        private void txtMale_Leave(object sender, EventArgs e)
        {
            if (txtMale.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtMale.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtMale, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtMale, "Empty");
            }
        }

        private void txtFemale_Leave(object sender, EventArgs e)
        {
            if (txtFemale.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtFemale.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtFemale, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtFemale, "Empty");
            }
        }

        private void txtKids_Leave(object sender, EventArgs e)
        {
            if (txtKids.TextLength != 0)
            {
                try
                {
                    int ID = int.Parse(txtKids.Text);
                    errWrong.Clear();
                }

                catch (Exception ex)
                {
                    errWrong.SetError(txtKids, "Wrong Format");

                }
            }

            else
            {
                errWrong.SetError(txtKids, "Empty");
            }
        }

        
    }
}
