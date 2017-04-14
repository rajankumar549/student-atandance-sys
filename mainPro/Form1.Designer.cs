namespace mainPro
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attandaceCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeachearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPrifileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTimeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttandanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attandaceCheckToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.classToolStripMenuItem,
            this.markAttandanceToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attandaceCheckToolStripMenuItem
            // 
            this.attandaceCheckToolStripMenuItem.Name = "attandaceCheckToolStripMenuItem";
            this.attandaceCheckToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.attandaceCheckToolStripMenuItem.Text = "Attandace check";
            this.attandaceCheckToolStripMenuItem.Click += new System.EventHandler(this.attandaceCheckToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.dleteStudentToolStripMenuItem,
            this.viewProfileToolStripMenuItem1,
            this.editProfileToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add NewStudent";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // dleteStudentToolStripMenuItem
            // 
            this.dleteStudentToolStripMenuItem.Enabled = false;
            this.dleteStudentToolStripMenuItem.Name = "dleteStudentToolStripMenuItem";
            this.dleteStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dleteStudentToolStripMenuItem.Text = "Dlete Student";
            // 
            // viewProfileToolStripMenuItem1
            // 
            this.viewProfileToolStripMenuItem1.Enabled = false;
            this.viewProfileToolStripMenuItem1.Name = "viewProfileToolStripMenuItem1";
            this.viewProfileToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.viewProfileToolStripMenuItem1.Text = "View Profile";
            this.viewProfileToolStripMenuItem1.Click += new System.EventHandler(this.viewProfileToolStripMenuItem1_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Enabled = false;
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTeachearToolStripMenuItem,
            this.editProfileToolStripMenuItem1,
            this.deleteProfileToolStripMenuItem,
            this.viewPrifileToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // addNewTeachearToolStripMenuItem
            // 
            this.addNewTeachearToolStripMenuItem.Name = "addNewTeachearToolStripMenuItem";
            this.addNewTeachearToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewTeachearToolStripMenuItem.Text = "Add new teachear";
            this.addNewTeachearToolStripMenuItem.Click += new System.EventHandler(this.addNewTeachearToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem1
            // 
            this.editProfileToolStripMenuItem1.Enabled = false;
            this.editProfileToolStripMenuItem1.Name = "editProfileToolStripMenuItem1";
            this.editProfileToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.editProfileToolStripMenuItem1.Text = "Edit Profile";
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Enabled = false;
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            // 
            // viewPrifileToolStripMenuItem
            // 
            this.viewPrifileToolStripMenuItem.Enabled = false;
            this.viewPrifileToolStripMenuItem.Name = "viewPrifileToolStripMenuItem";
            this.viewPrifileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewPrifileToolStripMenuItem.Text = "View Prifile";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTimeTableToolStripMenuItem,
            this.aDDClassToolStripMenuItem});
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // showTimeTableToolStripMenuItem
            // 
            this.showTimeTableToolStripMenuItem.Name = "showTimeTableToolStripMenuItem";
            this.showTimeTableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showTimeTableToolStripMenuItem.Text = "Show time Table";
            this.showTimeTableToolStripMenuItem.Click += new System.EventHandler(this.showTimeTableToolStripMenuItem_Click);
            // 
            // aDDClassToolStripMenuItem
            // 
            this.aDDClassToolStripMenuItem.Name = "aDDClassToolStripMenuItem";
            this.aDDClassToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aDDClassToolStripMenuItem.Text = "ADD Class";
            this.aDDClassToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem1_Click);
            // 
            // markAttandanceToolStripMenuItem
            // 
            this.markAttandanceToolStripMenuItem.Name = "markAttandanceToolStripMenuItem";
            this.markAttandanceToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.markAttandanceToolStripMenuItem.Text = "Mark Attandance";
            this.markAttandanceToolStripMenuItem.Click += new System.EventHandler(this.markAttandanceToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Enabled = false;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 332);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_MaximizedBoundsChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attandaceCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTeachearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTimeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAttandanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPrifileToolStripMenuItem;
    }
}