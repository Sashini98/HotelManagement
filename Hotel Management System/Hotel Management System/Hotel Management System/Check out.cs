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
    public partial class Check_out : MetroFramework.Forms.MetroForm
    {
        int price, TotalDays;
        double tot,grandTot,Paid;         


        public Check_out()
        {
            InitializeComponent();
        }

        private void Check_out_Load(object sender, EventArgs e)
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
                
                

                string query = "Insert into Room values ('"+txtIDNum.Text+"','"+txtName.Text+"','"+txtAddress.Text+"','"+txtCountry.Text+"',"+txtCntNo.Text+",'"+txtGender.Text+"',"+txtBill.Text+",'"+txtBillDate.Text+"','"+cmbPayment.Text+"','"+txtPayment.Text+"','"+txtPDate.Text+"',"+txtRNo.Text+",'"+cmbRoomType.Text+"',"+txtMale.Text+","+txtFemale.Text+","+txtKids.Text+","+txtMeal.Text+",'"+txtFrom.Text+"','"+txtTo.Text+"',"+txtDays.Text+",'"+txtTot.Text+"','"+txtDiscount.Text+"','"+txtGTot.Text+"','"+txtPaid.Text+"','"+txtBal.Text+ "')";
                OleDbCommand cmd = new OleDbCommand(query, con);



                con.Open();
          
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                con.Close();
     
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIDNum_TextChanged(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Hotel.accdb");
            string query = "Select * from BookRoom where IDNum='"+txtIDNum.Text+"'";
            
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader rdr;

            con.Open();


            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {

                txtIDNum.Text = Convert.ToString(rdr.GetValue(0));
                txtName.Text = Convert.ToString(rdr.GetValue(1));
                txtAddress.Text = Convert.ToString(rdr.GetValue(2));
                txtCountry.Text = Convert.ToString(rdr.GetValue(3));
                txtCntNo.Text = Convert.ToString(rdr.GetValue(4));
                txtGender.Text = Convert.ToString(rdr.GetValue(5));
                cmbGender.Text = Convert.ToString(rdr.GetValue(5));
                cmbRoomType.Text = Convert.ToString(rdr.GetValue(6));
                txtMale.Text = Convert.ToString(rdr.GetValue(7));
                txtFemale.Text = Convert.ToString(rdr.GetValue(8));
                txtKids.Text = Convert.ToString(rdr.GetValue(9));
                

            }

            txtDays.Text = Convert.ToString(TotalDays);

            

            con.Close();
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

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomType.Text == "Single-Standard")
            {
                txtRType.Text = "5000";
                price = 5000;
                
            }

            else if (cmbRoomType.Text == "Double-Standard")
            {
                txtRType.Text = "8500";
                price = 8500;
               
            }

            else if (cmbRoomType.Text == "Triple-Standard")
            {
                txtRType.Text = "11000";
                price = 11000;
                
            }

            else if (cmbRoomType.Text == "Quadraple-Standard")
            {
                txtRType.Text = "13000";
                price = 13000;

            }


            else if (cmbRoomType.Text == "Family-Standard")
            {
                txtRType.Text = "15000";
                price = 15000;

            }

           
            else if (cmbRoomType.Text == "Single-Superior")
            {
                txtRType.Text = "8000";
                price = 8000;

            }

            else if (cmbRoomType.Text == "Double-Superior")
            {
                txtRType.Text = "10000";
                price = 10000;

            }

            else if (cmbRoomType.Text == "Triple-Superior")
            {
                txtRType.Text = "15000";
                price = 15000;

            }

            else if (cmbRoomType.Text == "Quadraple-Superior")
            {
                txtRType.Text = "18000";
                price = 18000;

            }


            else if (cmbRoomType.Text == "Family-Superior")
            {
                txtRType.Text = "20000";
                price = 20000;

            }

            else if (cmbRoomType.Text == "Single-Delux")
            {
                txtRType.Text = "10000";
                price = 10000;

            }

            else if (cmbRoomType.Text == "Double-Delux")
            {
                txtRType.Text = "15000";
                price = 15000;

            }

            else if (cmbRoomType.Text == "Triple-Delux")
            {
                txtRType.Text = "20000";
                price = 20000;

            }

            else if (cmbRoomType.Text == "Quadraple-Delux")
            {
                txtRType.Text = "25000";
                price = 25000;

            }


            else if (cmbRoomType.Text == "Family-Delux")
            {
                txtRType.Text = "35000";
                price = 30000;

            }
        }

         
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGender.Text = Convert.ToString(cmbGender.Text);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void txtDays_TextChanged(object sender, EventArgs e)
        { }

        private void txtTot_TextChanged(object sender, EventArgs e)
        {
            double discount, d, dis;


            d = System.Convert.ToDouble(txtDiscount.Text);
            discount = d / 100;
            dis = (tot * discount);

            grandTot = tot - dis;

            txtGTot.Text = System.Convert.ToString(grandTot);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {}



        private void txtPaid_Leave(object sender, EventArgs e)
        {
            Paid = System.Convert.ToDouble(txtPaid.Text);

            txtBal.Text = System.Convert.ToString(Paid-grandTot);
        }

        private void trip_DateDateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = Convert.ToString(trip_DateDateTimePickerFrom.Text);
            
        }

        private void trip_DateDateTimePickerTo_ValueChanged_1(object sender, EventArgs e)
        {
            txtTo.Text = Convert.ToString(trip_DateDateTimePickerTo.Text);
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DateTime datein, dateout;
            int meal;

            datein = Convert.ToDateTime(trip_DateDateTimePickerFrom.Value);
            dateout = Convert.ToDateTime(trip_DateDateTimePickerTo.Value);

            TotalDays = (dateout - datein).Days;

            txtDays.Text = Convert.ToString(TotalDays);

            meal = System.Convert.ToInt32(txtMeal.Text);


            if (cmbRoomType.Text == "Single-Standard")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Double-Standard")
            {

                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Triple-Standard")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Quadraple-Standard")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }


            else if (cmbRoomType.Text == "Family-Standard")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }


            else if (cmbRoomType.Text == "Single-Superior")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Double-Superior")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Triple-Superior")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Quadraple-Superior")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }


            else if (cmbRoomType.Text == "Family-Superior")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Single-Delux")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Double-Delux")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Triple-Delux")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }

            else if (cmbRoomType.Text == "Quadraple-Delux")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }


            else if (cmbRoomType.Text == "Family-Delux")
            {
                tot = (price * TotalDays) + meal;
                txtTot.Text = System.Convert.ToString(tot);

            }
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        
    }
}
