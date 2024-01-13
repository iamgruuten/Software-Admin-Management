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
    public partial class ResetPwd : Form
    {
        public ResetPwd()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtconpwd.Text == txtpwd.Text)
            {
                if (txtconpwd.Text.Length < 8)
                {
                    MessageBox.Show("Password must be 8 character long");
                }
                else
                {
                    Form1.Employee[ForgetPassword.trace].myPassword = txtpwd.Text;
                    MessageBox.Show("Password Change Successfully!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password are not match! Please Retype Password");
            }
        }

        private void txtconpwd_TextChanged(object sender, EventArgs e)
        {
            if(txtconpwd.Text != txtpwd.Text)
            {
                pbCross.Visible = true;
            }
            else
            {
                pbCross.Visible = false;
            }
        }
    }
}
