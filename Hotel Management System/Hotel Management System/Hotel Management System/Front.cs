using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Front : MetroFramework.Forms.MetroForm
    {
        public Front()
        {
            InitializeComponent();
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Book newForm = new Book();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Banquet_Hall newForm = new Banquet_Hall();
            this.Hide();

            newForm.ShowDialog();
            this.Close();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Check_out newForm = new Check_out();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            view newForm = new view();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            view_banquet newForm = new view_banquet();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            cancel newForm = new cancel();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
