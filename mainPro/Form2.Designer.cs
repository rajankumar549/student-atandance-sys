namespace mainPro
{
    partial class Form2
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
            this.f_name = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_gen = new System.Windows.Forms.RadioButton();
            this.f_gen = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.mob = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(505, 123);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(123, 20);
            this.f_name.TabIndex = 1;
            this.f_name.Text = "First";
            this.f_name.TextChanged += new System.EventHandler(this.Form2_Load);
            this.f_name.Enter += new System.EventHandler(this.textBox1_Enter);
            this.f_name.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(478, 59);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(150, 31);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // l_name
            // 
            this.l_name.Location = new System.Drawing.Point(505, 193);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(123, 20);
            this.l_name.TabIndex = 5;
            this.l_name.Text = "Last";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 705);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(505, 250);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(123, 20);
            this.id.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender";
            // 
            // m_gen
            // 
            this.m_gen.AutoSize = true;
            this.m_gen.Checked = true;
            this.m_gen.Location = new System.Drawing.Point(505, 304);
            this.m_gen.Name = "m_gen";
            this.m_gen.Size = new System.Drawing.Size(48, 17);
            this.m_gen.TabIndex = 10;
            this.m_gen.TabStop = true;
            this.m_gen.Text = "Male";
            this.m_gen.UseVisualStyleBackColor = true;
            // 
            // f_gen
            // 
            this.f_gen.AutoSize = true;
            this.f_gen.Location = new System.Drawing.Point(559, 304);
            this.f_gen.Name = "f_gen";
            this.f_gen.Size = new System.Drawing.Size(59, 17);
            this.f_gen.TabIndex = 11;
            this.f_gen.TabStop = true;
            this.f_gen.Text = "Female";
            this.f_gen.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(505, 348);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 20);
            this.add.TabIndex = 12;
            this.add.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 164);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select";
            // 
            // path
            // 
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(277, 270);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(153, 20);
            this.path.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Uplaod Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(277, 369);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(153, 20);
            this.dob.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Other Info";
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(277, 438);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(100, 20);
            this.other.TabIndex = 20;
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(800, 123);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(100, 20);
            this.pin.TabIndex = 22;
            this.pin.Text = "Pincode";
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(797, 230);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(103, 20);
            this.mob.TabIndex = 24;
            this.mob.Text = "eg.95XXXXXXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(773, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Contact";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(797, 267);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(103, 20);
            this.email.TabIndex = 25;
            this.email.Text = "eg.    abcd@xyz.com";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Afghanistan",
            "Armenia",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "Bhutan",
            "Brunei",
            "Cambodia",
            "China",
            "Cyprus",
            "Georgia",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Israel",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Lebanon",
            "Malaysia",
            "Maldives",
            "Mongolia",
            "Myanmar (Burma)",
            "Nepal",
            "North Korea",
            "Oman",
            "Pakistan",
            "Palestine",
            "Philippines",
            "Qatar",
            "Russia",
            "Saudi Arabia",
            "Singapore",
            "South Korea",
            "Sri Lanka",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Turkey",
            "Turkmenistan",
            "United Arab Emirates (UAE)",
            "Uzbekistan",
            "Vietnam",
            "Yemen",
            ""});
            this.country.Location = new System.Drawing.Point(800, 156);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 21);
            this.country.TabIndex = 26;
            this.country.Text = "Country";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(451, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "Submit data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Infommation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Here you can insert the new teacher\r\n deatils";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "* First Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "First name always stated with capital \r\nletter only";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "It is use to upload the teachers picture";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "* Upload Image";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.country);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.other);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add);
            this.Controls.Add(this.f_gen);
            this.Controls.Add(this.m_gen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.f_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Enter += new System.EventHandler(this.Form2_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton m_gen;
        private System.Windows.Forms.RadioButton f_gen;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox other;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}