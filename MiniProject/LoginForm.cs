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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string email;
        string password;
        int timer = 10;
        public static bool Admin = false;
        public static int element;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text.ToUpper();
            password = txtPassword.Text;
                
            for (int i = 0; i < officer.Count(); i++)
            {
                if (officer[i].myEmail == email) //Checks from HRofficer Array
                {
                        if (officer[i].myPassword == password)
                        {
                            Admin = true;  //To determine account is HROfficer
                            this.Hide();
                            new AdminForm().ShowDialog();
                            this.Show();
                            txtEmail.Text = "";
                            txtPassword.Text = "";
                            tries = 0;
                            return;
                        }
                        else
                        {
                            BruteAttack();
                            return;
                        }
                } 
                else if(officer.Count() - 1 == i)
                {
                    for (int a = 0; a < Form1.Employee.Count(); a++) //checks for employee array
                    {
                        if(Form1.Employee[a].myEmail == email)
                        {
                            if (Form1.Employee[a].myPassword == password)
                            {
                                if (Form1.Employee[a].myType == true)
                                {
                                    Admin = false;  //To determine account is Employee
                                    element = a;
                                    this.Hide();
                                    new UserInfo().ShowDialog();
                                    this.Show();
                                    txtEmail.Text = "";
                                    txtPassword.Text = "";
                                    tries = 0;
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Account is disabled, please contact your administrator");
                                    return;
                                }
                            }
                            else
                            {
                                BruteAttack();
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Account Not Found");
                    return;
                }
            }
 
        }

        public static details[] officer = new details[2]; //preset officer into form
        int tries = 0; //Tries set for brute force
        private void LoginForm_Load(object sender, EventArgs e)
        {
            details HR = new details("LEE@GMAIL.COM", "LEE", "12345");
            details HR1 = new details("TAN@GMAIL.COM", "TAN", "12345");
            officer[0] = HR;
            officer[1] = HR1;
            tries = 0;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SecurityTimer_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                // Display the new time left
                timer = timer - 1;
                btnLogin.Text = timer + " seconds";
            }
            else
            {
                SecurityTimer.Stop();
                btnLogin.Text = "Login";
                btnLogin.Enabled = true;
                tries = 0; //Resets attempts to 0
                timer = 10; //Resets timer to 10 seconds for next lockout
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          new ForgetPassword().ShowDialog(); //Forget Password
        }

        private void BruteAttack()
        {
            MessageBox.Show("Invalid Password");
            txtPassword.Text = "";
            tries = tries + 1;

            if (tries == 3)
            {
                btnLogin.Enabled = false; SecurityTimer.Start();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Text = "something@example.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "something@example.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
}
