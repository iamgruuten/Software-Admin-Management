using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        string email;
        public static int trace;
        int block = 3;
        private void btnReset_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text.ToLower();

            for(int i = 0; i < Form1.Employee.Count(); i++)
            {
                if(Form1.Employee[i].myEmail == email)
                {
                    if (Form1.Employee[i].myType == true)
                    {
                        txtAnswer.Enabled = true;
                        cbSecurity.SelectedIndex = Form1.Employee[i].mySecurity;
                        txtEmail.Enabled = false;
                        btnReset.Enabled = false;
                        btnConfirm.Enabled = true;
                        trace = i;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Account is locked, Please contact your administrator");
                        return;
                    }
                }
                else if(Form1.Employee.Count() - 1 == i)
                {
                    MessageBox.Show("Account Not Found");
                    return;
                }
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            cbSecurity.DataSource = UserInfo.questions;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.ToUpper() == Form1.Employee[trace].myAnswer)
            {
                new ResetPwd().ShowDialog();
                this.Close();
            }
            else
            {
                block = block - 1;
                if (block == 0)
                {
                    Form1.Employee[trace].myType = false;
                    MessageBox.Show("Your Account has been disabled due to the number of attempts. Please contact your administrator", "Blocked");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have " + block + " tries left", "Invalid Answer!");
                }
            }
        }
    }
}
