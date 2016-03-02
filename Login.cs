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
    public partial class frmLogin : Form
    {    
        DataSet DS = new DataSet();
        SqlDataAdapter sqlDA=new SqlDataAdapter();       
        dbaseClass conObj = new dbaseClass();
        int rowCount;
         SevenStarServiceCenterSSSC SSSC = new SevenStarServiceCenterSSSC();
        //<<<<<<<<<<<<< VARIABLE FOR FILE HANDALING  >>>>>>>>>>>>>>>>>>>>>>

        public frmLogin()
        {
            InitializeComponent();

        }       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            //<<<<<<<<<<<<< Key HANDALING  >>>>>>>>>>>>>>>>>>>>>>
            if (keyData == Keys.Escape)/*<<If the user has enterd |Esc| key, following message will display>>*/
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to terminate the system?", "SSSC Management - Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                /*<<Message>>*/
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return true;
                }
                else
                {
                    lblError.Text = "Not Terminated";
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conObj.sqlconn.State == ConnectionState.Closed)
                {
                    conObj.sqlconn.Open();//opening database connection
                }
                string sqllogin = "SELECT * FROM login WHERE user_name='" + txtUName.Text.Trim() + "' AND password='" + txtUPass.Text.Trim() + "'";//sql coding

                sqlDA = new SqlDataAdapter(sqllogin, conObj.sqlconn);//setting sql statment to the data adaptor
                
                sqlDA.Fill(DS, "log");

                if (DS.Tables["log"].Rows.Count > 0)
                {
                    dbaseClass.loginName = txtUName.Text;

                    this.Close();//hide current form
                    SSSC.Show();//showing main frame
                    SSSC.Enabled = true;//enabling main frame
                    SSSC.Focus();
                }
                else
                {
                    //message if the username or password incorrect
                    lblError.Text = "Invalid username or password";
                    txtUName.Text = "";
                    txtUPass.Text = "";
                    txtUName.Focus();
                }
            }
            catch (NullReferenceException E)
            {
                Console.WriteLine(E.Message);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
       
            {         SSSC.Show();
                SSSC.Enabled = false;

                conObj.databaseconnect();
                if (conObj.sqlconn.State == ConnectionState.Closed)
                {
                    conObj.sqlconn.Open();
                }
                string sqlText = "SELECT * FROM login";
                conObj.sqlDA = new SqlDataAdapter(sqlText, conObj.sqlconn);

                conObj.sqlDA.Fill(DS, "stDET");

                rowCount = DS.Tables["stDET"].Rows.Count - 1;

                //closing the connection
                conObj.sqlconn.Close();
                lblError.Text = "";
                btnLogin.Enabled = false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Database Not Connected");
                Application.Exit();
            }
        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUName.Text))
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void txtUPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUName_Leave_1(object sender, EventArgs e)
        {
            string val;
            val = txtUName.Text;
            if (val.Length == 0)
            {
                lblError.Text="User name Can not be a blank";
                txtUName.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e, string value)
        {
            lblError.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

    }
}
