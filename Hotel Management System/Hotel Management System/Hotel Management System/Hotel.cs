using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync(); 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {

                Thread.Sleep(50);

                backgroundWorker1.ReportProgress(i);
            } 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
             
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            this.Text = "Progress: " + e.ProgressPercentage.ToString() + "%"; 
            
            
            if (progressBar1.Value == 10)
            {
                label2.Text = "Reading Modules";
            }

            else if (progressBar1.Value == 40)
            {
                label2.Text = "Starting Modules";
            }

            else if (progressBar1.Value == 60)
            {
                label2.Text = "Done Loading Modules";
            }
            else if (progressBar1.Value == 100)
            {

                userLogin newForm = new userLogin();
                this.Hide();

                newForm.ShowDialog();
                this.Close();
            }



        }
    }
}
