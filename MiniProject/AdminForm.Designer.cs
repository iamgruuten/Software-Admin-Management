namespace MiniProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStripAdminForm = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listviewInfo = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIRC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Accessible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.rbdisable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSorted = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Label();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripAdminForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(12, 37);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(128, 16);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome [Username],";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(178, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove User";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // menuStripAdminForm
            // 
            this.menuStripAdminForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripAdminForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripAdminForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdminForm.Name = "menuStripAdminForm";
            this.menuStripAdminForm.Size = new System.Drawing.Size(647, 24);
            this.menuStripAdminForm.TabIndex = 5;
            this.menuStripAdminForm.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledUserToolStripMenuItem,
            this.disabledUserToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem1.Text = "Filter Account";
            // 
            // enabledUserToolStripMenuItem
            // 
            this.enabledUserToolStripMenuItem.Name = "enabledUserToolStripMenuItem";
            this.enabledUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enabledUserToolStripMenuItem.Text = "Enabled User";
            this.enabledUserToolStripMenuItem.Click += new System.EventHandler(this.enabledUserToolStripMenuItem_Click);
            // 
            // disabledUserToolStripMenuItem
            // 
            this.disabledUserToolStripMenuItem.Name = "disabledUserToolStripMenuItem";
            this.disabledUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disabledUserToolStripMenuItem.Text = "Disabled User";
            this.disabledUserToolStripMenuItem.Click += new System.EventHandler(this.disabledUserToolStripMenuItem_Click);
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bothToolStripMenuItem.Text = "Both";
            this.bothToolStripMenuItem.Click += new System.EventHandler(this.bothToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Warning: If you an unauthorized officer, please logout immediately";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(413, 298);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "HR Administration";
            // 
            // listviewInfo
            // 
            this.listviewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Age,
            this.NIRC,
            this.Phone,
            this.Email,
            this.Address,
            this.Accessible});
            this.listviewInfo.FullRowSelect = true;
            this.listviewInfo.GridLines = true;
            this.listviewInfo.Location = new System.Drawing.Point(15, 68);
            this.listviewInfo.Name = "listviewInfo";
            this.listviewInfo.Size = new System.Drawing.Size(470, 155);
            this.listviewInfo.TabIndex = 10;
            this.listviewInfo.UseCompatibleStateImageBehavior = false;
            this.listviewInfo.View = System.Windows.Forms.View.Details;
            this.listviewInfo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listviewInfo_ColumnClick);
            this.listviewInfo.SelectedIndexChanged += new System.EventHandler(this.listviewInfo_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "Name";
            this.Username.Width = 63;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // NIRC
            // 
            this.NIRC.Text = "NIRC";
            this.NIRC.Width = 62;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 70;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 97;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 91;
            // 
            // Accessible
            // 
            this.Accessible.Text = "Accessible";
            // 
            // rbEnable
            // 
            this.rbEnable.AutoSize = true;
            this.rbEnable.Checked = true;
            this.rbEnable.Enabled = false;
            this.rbEnable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnable.Location = new System.Drawing.Point(491, 239);
            this.rbEnable.Name = "rbEnable";
            this.rbEnable.Size = new System.Drawing.Size(64, 20);
            this.rbEnable.TabIndex = 11;
            this.rbEnable.TabStop = true;
            this.rbEnable.Text = "Enable";
            this.rbEnable.UseVisualStyleBackColor = true;
            this.rbEnable.Click += new System.EventHandler(this.rbEnable_Click);
            // 
            // rbdisable
            // 
            this.rbdisable.AutoSize = true;
            this.rbdisable.Enabled = false;
            this.rbdisable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdisable.Location = new System.Drawing.Point(555, 239);
            this.rbdisable.Name = "rbdisable";
            this.rbdisable.Size = new System.Drawing.Size(65, 20);
            this.rbdisable.TabIndex = 12;
            this.rbdisable.TabStop = true;
            this.rbdisable.Text = "Disable";
            this.rbdisable.UseVisualStyleBackColor = true;
            this.rbdisable.Click += new System.EventHandler(this.rbdisable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Report Generated:";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(132, 274);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(0, 13);
            this.lbl_timer.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbSorted);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSerach);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 90);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(242, 55);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Search";
            // 
            // cbSorted
            // 
            this.cbSorted.FormattingEnabled = true;
            this.cbSorted.Location = new System.Drawing.Point(90, 50);
            this.cbSorted.Name = "cbSorted";
            this.cbSorted.Size = new System.Drawing.Size(110, 24);
            this.cbSorted.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSerach
            // 
            this.txtSerach.Location = new System.Drawing.Point(91, 19);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(109, 21);
            this.txtSerach.TabIndex = 19;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(28, 18);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(38, 16);
            this.Clock.TabIndex = 20;
            this.Clock.Text = "Clock";
            // 
            // tClock
            // 
            this.tClock.Interval = 1;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clock);
            this.groupBox2.Location = new System.Drawing.Point(508, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 48);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniProject.Properties.Resources.original_logos_2018_May_1826_5afad0a828a18wm;
            this.pictureBox2.Location = new System.Drawing.Point(388, 337);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProject.Properties.Resources.adminlogo;
            this.pictureBox1.Location = new System.Drawing.Point(491, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 432);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbdisable);
            this.Controls.Add(this.rbEnable);
            this.Controls.Add(this.listviewInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.menuStripAdminForm);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripAdminForm;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Administration";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStripAdminForm.ResumeLayout(false);
            this.menuStripAdminForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuStrip menuStripAdminForm;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listviewInfo;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader NIRC;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.RadioButton rbdisable;
        private System.Windows.Forms.ColumnHeader Accessible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSorted;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSerach;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enabledUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReset;
    }
}