namespace SevenStarServiceCenter
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.VehicleNumber = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVnumber = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbnumber = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.lblError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.Location = new System.Drawing.Point(15, 127);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(60, 13);
            this.lblBillNumber.TabIndex = 0;
            this.lblBillNumber.Text = "Bill Number";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(15, 153);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(46, 13);
            this.lblBillDate.TabIndex = 1;
            this.lblBillDate.Text = "Bill Date";
            // 
            // VehicleNumber
            // 
            this.VehicleNumber.AutoSize = true;
            this.VehicleNumber.Location = new System.Drawing.Point(15, 178);
            this.VehicleNumber.Name = "VehicleNumber";
            this.VehicleNumber.Size = new System.Drawing.Size(82, 13);
            this.VehicleNumber.TabIndex = 2;
            this.VehicleNumber.Text = "Vehicle Number";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(131, 201);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(169, 20);
            this.txtamount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount";
            // 
            // txtVnumber
            // 
            this.txtVnumber.Location = new System.Drawing.Point(131, 175);
            this.txtVnumber.Name = "txtVnumber";
            this.txtVnumber.Size = new System.Drawing.Size(169, 20);
            this.txtVnumber.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 17;
            // 
            // txtbnumber
            // 
            this.txtbnumber.Location = new System.Drawing.Point(131, 124);
            this.txtbnumber.Name = "txtbnumber";
            this.txtbnumber.Size = new System.Drawing.Size(169, 20);
            this.txtbnumber.TabIndex = 17;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(225, 236);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "15/08/2015";
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(131, 150);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(169, 20);
            this.txtdate.TabIndex = 19;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 241);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "lblError";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 104);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtbnumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtVnumber);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehicleNumber);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.lblBillNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.EnabledChanged += new System.EventHandler(this.Payments_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label VehicleNumber;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVnumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbnumber;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}