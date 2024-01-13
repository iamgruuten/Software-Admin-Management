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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        bool officer = LoginForm.Admin;
        bool Add = AdminForm.Add;
        public static string[] questions = new string[] {"What is your dream job?", "What was your first pet name?", "In what city or town was your mother born?", "What is your childhood's nickname?" };

        private void UserInfo_Load(object sender, EventArgs e)
        {
            cblSecurity.DataSource = questions;
            if (officer == false) //Checks if user is HR officer
            {
                
                lbloutput.Text = "Employee Info"; //Employee
                btnUpdateLogout.Text = "Logout";

                foreach (TextBox textbox in group.Controls.OfType<TextBox>()) //Setting Textbox read only
                {
                    textbox.ReadOnly = true;
                }
                cblSecurity.Enabled = false;
                display(LoginForm.element);
                lblpwdcheck.Visible = false;
            }
            else
            {
                lblremind.Visible = true;
                lblStrength.Visible = true;
                if (Add == false) //Update user
                {
                    lbloutput.Text = "Employee Editor"; //Officer
                    btnUpdateLogout.Text = "Update";

                    display(AdminForm.element);
                }
                else //Add User
                {
                    lbloutput.Text = "Employee Add"; //Officer
                    btnUpdateLogout.Text = "Add";
                }
            }

        }

        private void btnUpdateLogout_Click(object sender, EventArgs e)
        {
            if (officer == false) //Employee
            {
                DialogResult Exit = MessageBox.Show("Are you sure?", "You are about to Logout", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) this.Hide();
            }
            else //HRofficer
            {
                if (Add == false) //a true false statement to identify if its adding or updating
                {
                    DialogResult Exit = MessageBox.Show("Are you sure?", "You are about to update the user", MessageBoxButtons.YesNo);
                    if (Exit == DialogResult.Yes)
                    {
                        if (!IsInfoEmpty())
                        {
                            try
                            {
                                if (ErrorNIRC.Visible == false && ErrorEmail.Visible == false && ErrorPwd.Visible == false)
                                {
                                    Form1.Employee[AdminForm.element].myName = txtName.Text.ToUpper();
                                    Form1.Employee[AdminForm.element].myAddress = txtAddress.Text.ToUpper();
                                    Form1.Employee[AdminForm.element].myAge = int.Parse(txtAge.Text);
                                    Form1.Employee[AdminForm.element].myPhone = int.Parse(txtPhone.Text);
                                    Form1.Employee[AdminForm.element].myNIRC = txtNIRC.Text.ToUpper();
                                    Form1.Employee[AdminForm.element].myEmail = txtEmail.Text.ToLower();
                                    Form1.Employee[AdminForm.element].myPassword = txtPassword.Text;
                                    Form1.Employee[AdminForm.element].mySecurity = cblSecurity.SelectedIndex;
                                    Form1.Employee[AdminForm.element].myAnswer = txtAnswer.Text.ToUpper();
                                    MessageBox.Show("Updated");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please Correct the invalid fields");
                                }
                            }
                            catch { MessageBox.Show("Please Correct the invalid Fields"); }
                        }
                    }

                    
                }
                else //if user is adding
                {
                    DialogResult Exit = MessageBox.Show("Are you sure?", "You are about to add a new user", MessageBoxButtons.YesNo);
                    if (Exit == DialogResult.Yes)
                    {
                        if (!IsInfoEmpty())
                        {
                            try
                            {
                                if (ErrorNIRC.Visible == false && ErrorEmail.Visible == false && ErrorPwd.Visible == false)
                                {
                                    string name = txtName.Text.Trim().ToUpper();
                                    string password = txtPassword.Text.Trim().ToUpper();
                                    int age = int.Parse(txtAge.Text.Trim());
                                    string address = txtAddress.Text.Trim().ToUpper();
                                    int phone = int.Parse(txtPhone.Text.Trim());
                                    string NIRC = txtNIRC.Text.Trim().ToUpper();
                                    string email = txtEmail.Text.ToLower().Trim().ToLower(); //if there's no empty field
                                    int security = cblSecurity.SelectedIndex;
                                    string answer = txtAnswer.Text.ToUpper();
                                    for (int i = 0; i < Form1.Employee.Count(); i++)
                                    {
                                        if (email == Form1.Employee[i].myEmail || NIRC == Form1.Employee[i].myNIRC)
                                        {
                                            MessageBox.Show("Duplicate Records Found");
                                            return;
                                        }
                                        else if (Form1.Employee.Count() - 1 == i)
                                        {
                                            details add = new details(name, password, email, address, phone, age, NIRC, security, answer, true);
                                            Form1.Employee.Add(add);
                                            MessageBox.Show("Added");
                                            this.Close();
                                            return;
                                        }
                                    }

                                    if(Form1.Employee.Count() == 0)
                                    {
                                        details add = new details(name, password, email, address, phone, age, NIRC, security, answer, true);
                                        Form1.Employee.Add(add);
                                        MessageBox.Show("Added");
                                        this.Close();
                                        return;
                                    }
                                } 
                                else
                                {
                                    MessageBox.Show("Please Correct the invalid fields");
                                }
                            }
                            catch { MessageBox.Show("Please Correct the invalid fields"); }
                        }
                    }
                }
            }
        }

        private void display(int element) //Display Information
        {
            txtName.Text = Form1.Employee[element].myName;
            txtAddress.Text = Form1.Employee[element].myAddress;
            txtAge.Text = Form1.Employee[element].myAge.ToString();
            txtPhone.Text = Form1.Employee[element].myPhone.ToString();
            txtNIRC.Text = Form1.Employee[element].myNIRC;
            txtEmail.Text = Form1.Employee[element].myEmail;
            txtPassword.Text = Form1.Employee[element].myPassword;
            cblSecurity.SelectedIndex = Form1.Employee[element].mySecurity;
            txtAnswer.Text = Form1.Employee[element].myAnswer;
        }

        bool IsValidEmail(string email) //Email Validation
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); //valid
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsInfoEmpty()
        {
            bool empty = false;
            foreach (TextBox textbox in group.Controls.OfType<TextBox>()) //Checks for empty field
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Please Ensure All Fields Are Fill Up");
                    empty = true; // if there's empty field
                    return empty;
                }
                else
                {
                    empty = false;
                    return empty;
                }
                //if there's no empty field
            }
            return empty;

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtPhone.Text, out value))
            {
                ErrorPhone.Visible = false;
            }
            else
            { 
            ErrorPhone.Visible = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(IsValidEmail(txtEmail.Text))
            {
                ErrorEmail.Visible = false;
            }
            else
            {
                ErrorEmail.Visible = true;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtAge.Text, out value))
            {
                ErrorAge.Visible = false;
            }
            else
            {
                ErrorAge.Visible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblpwdcheck.Visible = true; 
            if (txtPassword.Text.Length < 3)
            {
                lblpwdcheck.Text = "Weak";
                ErrorPwd.Visible = true;
            }
            else if(txtPassword.Text.Length > 7)
            {
                lblpwdcheck.Text = "Strong";
                ErrorPwd.Visible = false;
            }
            else
            {
                lblpwdcheck.Text = "Medium";
                ErrorPwd.Visible = true;
            }
        }

        private void txtNIRC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIRC.TextLength == 9 && !String.IsNullOrEmpty(txtNIRC.Text) && char.IsLetter(txtNIRC.Text[0]) && char.IsLetter(txtNIRC.Text[8]))
            {
                ErrorNIRC.Visible = false;
            }
            else
            {
                ErrorNIRC.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
