namespace Hotel_Management_System
{
    partial class Banquet_Hall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label t;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banquet_Hall));
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.txtPpl = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.trip_DateDateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtCntNo = new System.Windows.Forms.MaskedTextBox();
            this.errWrong = new System.Windows.Forms.ErrorProvider(this.components);
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            t = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(63, 361);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 18);
            label3.TabIndex = 349;
            label3.Text = "Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(63, 211);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 18);
            label1.TabIndex = 339;
            label1.Text = "Contact no:";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.Location = new System.Drawing.Point(63, 255);
            t.Name = "t";
            t.Size = new System.Drawing.Size(43, 18);
            t.TabIndex = 353;
            t.Text = "Hall :";
            t.Click += new System.EventHandler(this.t_Click);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(64, 300);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 18);
            label13.TabIndex = 348;
            label13.Text = "No Of People :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(63, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 18);
            label2.TabIndex = 343;
            label2.Text = "ID Number:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(63, 123);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(93, 18);
            first_NameLabel.TabIndex = 330;
            first_NameLabel.Text = "Guest Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(63, 161);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 18);
            addressLabel.TabIndex = 332;
            addressLabel.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(63, 412);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(110, 18);
            label8.TabIndex = 357;
            label8.Text = "Payment mode:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(64, 462);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 18);
            label9.TabIndex = 358;
            label9.Text = "Payment:";
            // 
            // cmbHall
            // 
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(197, 255);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(102, 21);
            this.cmbHall.TabIndex = 4;
            this.cmbHall.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // txtPpl
            // 
            this.txtPpl.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPpl.Location = new System.Drawing.Point(198, 300);
            this.txtPpl.Name = "txtPpl";
            this.txtPpl.Size = new System.Drawing.Size(101, 23);
            this.txtPpl.TabIndex = 5;
            this.txtPpl.TextChanged += new System.EventHandler(this.txtPpl_Leave);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(302, 361);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(136, 23);
            this.txtFrom.TabIndex = 342;
            // 
            // trip_DateDateTimePickerFrom
            // 
            this.trip_DateDateTimePickerFrom.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trip_DateDateTimePickerFrom.Location = new System.Drawing.Point(197, 361);
            this.trip_DateDateTimePickerFrom.Name = "trip_DateDateTimePickerFrom";
            this.trip_DateDateTimePickerFrom.Size = new System.Drawing.Size(102, 23);
            this.trip_DateDateTimePickerFrom.TabIndex = 6;
            this.trip_DateDateTimePickerFrom.ValueChanged += new System.EventHandler(this.trip_DateDateTimePickerFrom_ValueChanged);
            // 
            // txtIDNum
            // 
            this.txtIDNum.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNum.Location = new System.Drawing.Point(197, 76);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(242, 23);
            this.txtIDNum.TabIndex = 0;
            this.txtIDNum.Leave += new System.EventHandler(this.txtIDNum_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(197, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 23);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_Leave);
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(197, 409);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(242, 21);
            this.cmbPayment.TabIndex = 7;
            // 
            // txtHall
            // 
            this.txtHall.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHall.Location = new System.Drawing.Point(302, 254);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(137, 23);
            this.txtHall.TabIndex = 362;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.color = System.Drawing.Color.Transparent;
            this.btnSave.colorActive = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 1;
            this.btnSave.ImageZoom = 40;
            this.btnSave.LabelPosition = 41;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(621, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 126);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.color = System.Drawing.Color.White;
            this.btnExit.colorActive = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImagePosition = 1;
            this.btnExit.ImageZoom = 40;
            this.btnExit.LabelPosition = 41;
            this.btnExit.LabelText = "Back";
            this.btnExit.Location = new System.Drawing.Point(621, 214);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 129);
            this.btnExit.TabIndex = 364;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(866, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 365;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.pictureBox3;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(197, 457);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(242, 23);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_Leave);
            // 
            // txtCntNo
            // 
            this.txtCntNo.Location = new System.Drawing.Point(197, 214);
            this.txtCntNo.Mask = "0000000000";
            this.txtCntNo.Name = "txtCntNo";
            this.txtCntNo.Size = new System.Drawing.Size(242, 20);
            this.txtCntNo.TabIndex = 3;
            // 
            // errWrong
            // 
            this.errWrong.ContainerControl = this;
            // 
            // Banquet_Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 538);
            this.ControlBox = false;
            this.Controls.Add(this.txtCntNo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHall);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.cmbHall);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(t);
            this.Controls.Add(label13);
            this.Controls.Add(this.txtPpl);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.trip_DateDateTimePickerFrom);
            this.Controls.Add(this.txtIDNum);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Name = "Banquet_Hall";
            this.Text = "Banquet_Hall";
            this.Load += new System.EventHandler(this.Banquet_Hall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.TextBox txtPpl;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.DateTimePicker trip_DateDateTimePickerFrom;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.TextBox txtHall;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.MaskedTextBox txtCntNo;
        private System.Windows.Forms.ErrorProvider errWrong;
    }
}