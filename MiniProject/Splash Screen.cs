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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timer = 3;
        public static List<details> Employee = new List<details>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Employee = new List<details>();
            //Adding all exisiting employee
            details info = new details("ALEX", "12345678", "ALEX@GMAIL.COM", "WOODLANDS", 91234567, 25, "S0035678C", 0, "ENGINEER", true);
            details info1 = new details("MAX", "12345678", "MAX@GMAIL.COM", "SEMBAWANG", 97234567, 15, "S0035178C", 2, "SINGAPORE", true);
            details info2 = new details("JOHN", "12345678", "JOHN@GMAIL.COM", "WOODLANDS", 98234567, 35, "S0025618C", 1, "COOKIE", true);
            
            Employee.Add(info);
            Employee.Add(info1);
            Employee.Add(info2);
            SplashTime.Start(); //Start timer
        }

        private void SplashTime_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer = timer - 1;
            }
            else
            {
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
                SplashTime.Stop();
            }
        }
    }
}
