using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using SevenStarServiceCenter.Database;

namespace SevenStarServiceCenter
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        dbaseClass conObj = new dbaseClass();
        SqlDataAdapter sqlDA = new SqlDataAdapter();  

        private void Payments_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void Payments_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {             
            if((txtbnumber.Text.Trim()=="")&&(txtVnumber.Text.Trim()=="")&&(txtamount.Text.Trim()==""))
            {
                lblError.Visible = true;
                lblError.Text = "Empty Form cannot be saved";
                txtbnumber.Focus();

            }
            else if (txtbnumber.Text.Trim() == "")
            {
                lblError.Visible = true;
                lblError.Text="Missed in Bill Number ";
                txtbnumber.Focus();
            }
            else if (txtVnumber.Text.Trim() == "")
            {
                lblError.Visible = true;
                lblError.Text="Missed in Vehicle Number ";
                txtVnumber.Focus();
            }
            else if (txtamount.Text.Trim() == "")
            {
                lblError.Visible = true;
                lblError.Text="Missed in Amount ";
                txtamount.Focus();
            }
            else
            {
                try 
                {    
                    if (conObj.sqlconn.State == ConnectionState.Closed)
                    {
                        conObj.sqlconn.Open();//opening database connection
                    }
                    string sqllogin = "INSERT INTO Payments(Bill_Number,Bill_Date,Vehicle_Number,Amount) VALUES('"+txtbnumber.Text.Trim()+"','"+txtdate.Text.Trim()+"','"+txtVnumber.Text.Trim()+"','"+txtamount.Text.Trim()+"')";

                    sqlDA = new SqlDataAdapter(sqllogin, conObj.sqlconn);//setting sql statment to the data adaptor
                    
                    SqlDataAdapter ss = new SqlDataAdapter();
                    MessageBox.Show("Added successfully");
                    DialogResult dialogResult = MessageBox.Show("Do you want to print?", "Print", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        printDialog1.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }
                    conObj.sqlconn.Close();
                }   
                catch(Exception)
                {           
                    lblError.Visible = true;
                    lblError.Text = "Error";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblError.Text = "";
        }       
    }
}
