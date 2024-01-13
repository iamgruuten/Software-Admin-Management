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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public static bool Add;
        public static int element;
        int type;
        public static List<HROfficer> office = new List<HROfficer>();        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Add = false;
            string UserSelection = listviewInfo.SelectedItems[0].SubItems[4].Text;
            for(int i = 0; Form1.Employee.Count() > i; i++)
            {
                if(Form1.Employee[i].myEmail == UserSelection)
                {
                    element = i;
                }
            }
            UserInfo edit = new UserInfo();
            edit.ShowDialog();
            reload();
            changer();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //start timer
            var oldtime = DateTime.Now;

            office = new List<HROfficer>();
            HROfficer hr = new HROfficer("Name", 0);
            office.Add(hr);
            HROfficer hr1 = new HROfficer("Age", 1);
            office.Add(hr1);
            HROfficer hr2 = new HROfficer("NIRC", 2);
            office.Add(hr2);
            HROfficer hr3 = new HROfficer("Phone", 3);
            office.Add(hr3);
            HROfficer hr4 = new HROfficer("Email", 4);
            office.Add(hr4);
            HROfficer hr5 = new HROfficer("Address", 5);
            office.Add(hr5);
            bothToolStripMenuItem.Checked = true;
            cbSorted.DataSource = office;
            cbSorted.DisplayMember = "filter";
            cbSorted.ValueMember = "element";
            btnRemove.Enabled = false; //disable Buttons
            btnUpdate.Enabled = false;

            for(int i = 0; i < LoginForm.officer.Count(); i++) //Identify username through email match
            {
                if(LoginForm.officer[i].myEmail == LoginForm.email)
                {
                    lblwelcome.Text = "Welcome " + LoginForm.officer[i].myName + ",";
                }
            }

            reload();
            changer();

            //start Clock
            tClock.Start();
            //end timer

            var newTime = DateTime.Now;
            lbl_timer.Text = $"{(newTime - oldtime).TotalSeconds} Seconds";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Are you sure?", "You are about to Logout", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add = true;
            UserInfo add = new UserInfo();
            add.ShowDialog();
            listviewInfo.Items.Clear();
            reload();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListViewItem i = listviewInfo.SelectedItems[0];
            DialogResult Exit = MessageBox.Show("You are about to delete: " + i.SubItems[0].Text, "Are you sure?", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                
                for (int a = 0; Form1.Employee.Count() > a; a++)
                {
                    if (i.SubItems[2].Text == Form1.Employee[a].myNIRC)
                    {
                        Form1.Employee.Remove(Form1.Employee[a]);
                        listviewInfo.Items.Clear();
                        reload();
                        btnRemove.Enabled = false; btnUpdate.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void listviewInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewInfo.SelectedItems.Count != 0)
            {
                btnUpdate.Enabled = true;
                btnRemove.Enabled = true;
                rbdisable.Enabled = true;
                rbEnable.Enabled = true;

                string UserSelection = listviewInfo.SelectedItems[0].SubItems[4].Text;
                for (int i = 0; Form1.Employee.Count() > i; i++)
                {
                    if (Form1.Employee[i].myEmail == UserSelection)
                    {
                        switch (Form1.Employee[i].myType)
                        {
                            case true:
                                rbdisable.Checked = false;
                                rbEnable.Checked = true;
                                type = i;
                                break;
                            case false:
                                rbdisable.Checked = true;
                                rbEnable.Checked = false;
                                type = i;
                                break;
                        }
                    }
                }
            }
            else
            {
                btnUpdate.Enabled = false;
                btnRemove.Enabled = false;
                rbdisable.Enabled = false;
                rbEnable.Enabled = false;
            }
        }

        private void reload()
        {
            listviewInfo.Items.Clear();
            for (int i = 0; i < Form1.Employee.Count(); i++)
            {
                ListViewItem item = new ListViewItem(Form1.Employee[i].myName);
                item.SubItems.Add(Form1.Employee[i].myAge.ToString());
                item.SubItems.Add(Form1.Employee[i].myNIRC.ToString());
                item.SubItems.Add(Form1.Employee[i].myPhone.ToString());
                item.SubItems.Add(Form1.Employee[i].myEmail);
                item.SubItems.Add(Form1.Employee[i].myAddress);
                item.SubItems.Add(Form1.Employee[i].myType.ToString().ToLower());
                listviewInfo.Items.Add(item);
            }

            listviewInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize Columm width
            listviewInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            rbdisable.Enabled = false;
            rbEnable.Enabled = false;
        }

        public void changer()
        {
            foreach (ListViewItem a in listviewInfo.Items)
            {
                if (a.SubItems[6].Text == "false")
                {
                    a.BackColor = Color.Red;
                }
            }
        }

        private void rbEnable_Click(object sender, EventArgs e)
        {
            if (rbEnable.Checked)
            Form1.Employee[type].myType = true;
            reload();
            changer();
            btnSearch_Click_1(sender, e);

            if (enabledUserToolStripMenuItem.Checked)
            {
                enabledUserToolStripMenuItem_Click(sender, e);
            }
            else if (disabledUserToolStripMenuItem.Checked)
            {
                disabledUserToolStripMenuItem_Click(sender, e);
            }
        }

        private void rbdisable_Click(object sender, EventArgs e)
        {
            if (rbdisable.Checked)
            Form1.Employee[type].myType = false;
            reload();
            changer();
            btnSearch_Click_1(sender, e);

            if (enabledUserToolStripMenuItem.Checked)
            {
                enabledUserToolStripMenuItem_Click(sender, e);
            }
            else if (disabledUserToolStripMenuItem.Checked)
            {
                disabledUserToolStripMenuItem_Click(sender, e);
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name;
            if (txtSerach.Text == "NIRC")
            {
                reload();
            }
            else
            {
                name = txtSerach.Text.ToUpper();
                for (int i = 0; i < Form1.Employee.Count(); i++)
                {
                    if (name == Form1.Employee[i].myNIRC)
                    {
                        listviewInfo.Items.Clear();
                        ListViewItem item = new ListViewItem(Form1.Employee[i].myName);
                        item.SubItems.Add(Form1.Employee[i].myAge.ToString());
                        item.SubItems.Add(Form1.Employee[i].myNIRC.ToString());
                        item.SubItems.Add(Form1.Employee[i].myPhone.ToString());
                        item.SubItems.Add(Form1.Employee[i].myEmail);
                        item.SubItems.Add(Form1.Employee[i].myAddress);
                        item.SubItems.Add(Form1.Employee[i].myType.ToString().ToLower());
                        listviewInfo.Items.Add(item);
                        return;
                    }
                    else if(Form1.Employee.Count() - 1 == i)
                    {
                        listviewInfo.Items.Clear();
                    }
                }
            }
        }

        private void listviewInfo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void enabledUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type(true);
            enabledUserToolStripMenuItem.Checked = true;
        }

        private void disabledUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type(false);
            disabledUserToolStripMenuItem.Checked = true;
        }

        private void bothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in toolStripMenuItem1.DropDownItems)
            {
                item.Checked = false;
            }

            reload();
            changer();
            bothToolStripMenuItem.Checked = true;
        }

        private void Type(bool type)
        {
            foreach (ToolStripMenuItem item in toolStripMenuItem1.DropDownItems)
            {
                item.Checked = false;
            }

            listviewInfo.Items.Clear();
            for (int i = 0; i < Form1.Employee.Count(); i++)
            {
                if (Form1.Employee[i].myType == type)
                {
                    ListViewItem item = new ListViewItem(Form1.Employee[i].myName);
                    item.SubItems.Add(Form1.Employee[i].myAge.ToString());
                    item.SubItems.Add(Form1.Employee[i].myNIRC.ToString());
                    item.SubItems.Add(Form1.Employee[i].myPhone.ToString());
                    item.SubItems.Add(Form1.Employee[i].myEmail);
                    item.SubItems.Add(Form1.Employee[i].myAddress);
                    item.SubItems.Add(Form1.Employee[i].myType.ToString().ToLower());
                    listviewInfo.Items.Add(item);
                }
            }
            changer();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {

                Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            listviewInfo.Items.Clear();
            reload();
            changer();
            if (enabledUserToolStripMenuItem.Checked)
            {
                enabledUserToolStripMenuItem_Click(sender, e);
            }
            else if (disabledUserToolStripMenuItem.Checked)
            {
                disabledUserToolStripMenuItem_Click(sender, e);
            }

            string search = txtSerach.Text.ToUpper();
            int element = Convert.ToInt16(cbSorted.SelectedValue);
            if(!string.IsNullOrEmpty(search))
                    for (int i = listviewInfo.Items.Count - 1; i > -1 ; i--)
                    {
                        if (listviewInfo.Items[i].SubItems[element].Text != search)
                        {
                            listviewInfo.Items[i].Remove();
                        }
                    }
            else
            {
                reload();
                changer();
                if (enabledUserToolStripMenuItem.Checked)
                {
                    enabledUserToolStripMenuItem_Click(sender, e);
                }
                else if (disabledUserToolStripMenuItem.Checked)
                {
                    disabledUserToolStripMenuItem_Click(sender, e);
                }
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reload();
            changer();

            txtSerach.Text = "";
        }
    }
}
