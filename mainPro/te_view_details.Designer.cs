namespace mainPro
{
    partial class te_view_details
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
            this.classnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assestDataSet = new mainPro.assestDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.db_teachearDataSet = new mainPro.Db_teachearDataSet();
            this.dbteachearDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_nameTableAdapter = new mainPro.assestDataSetTableAdapters.class_nameTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genf = new System.Windows.Forms.RadioButton();
            this.genm = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.class_nameTableAdapter1 = new mainPro.assestDataSetTableAdapters.class_nameTableAdapter();
            this.edit = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_infoTableAdapter = new mainPro.Db_teachearDataSetTableAdapters.t_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classnameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_teachearDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbteachearDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classnameBindingSource
            // 
            this.classnameBindingSource.DataMember = "class_name";
            this.classnameBindingSource.DataSource = this.assestDataSetBindingSource;
            // 
            // assestDataSetBindingSource
            // 
            this.assestDataSetBindingSource.DataSource = this.assestDataSet;
            this.assestDataSetBindingSource.Position = 0;
            // 
            // assestDataSet
            // 
            this.assestDataSet.DataSetName = "assestDataSet";
            this.assestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teachear Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tinfoBindingSource;
            this.comboBox2.DisplayMember = "t_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(510, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "t_id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // db_teachearDataSet
            // 
            this.db_teachearDataSet.DataSetName = "Db_teachearDataSet";
            this.db_teachearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbteachearDataSetBindingSource
            // 
            this.dbteachearDataSetBindingSource.DataSource = this.db_teachearDataSet;
            this.dbteachearDataSetBindingSource.Position = 0;
            // 
            // class_nameTableAdapter
            // 
            this.class_nameTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.genf);
            this.panel1.Controls.Add(this.genm);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(130, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 346);
            this.panel1.TabIndex = 5;
            // 
            // genf
            // 
            this.genf.AutoSize = true;
            this.genf.Location = new System.Drawing.Point(413, 110);
            this.genf.Name = "genf";
            this.genf.Size = new System.Drawing.Size(59, 17);
            this.genf.TabIndex = 31;
            this.genf.TabStop = true;
            this.genf.Text = "Female";
            this.genf.UseVisualStyleBackColor = true;
            // 
            // genm
            // 
            this.genm.AutoSize = true;
            this.genm.Location = new System.Drawing.Point(321, 110);
            this.genm.Name = "genm";
            this.genm.Size = new System.Drawing.Size(48, 17);
            this.genm.TabIndex = 30;
            this.genm.TabStop = true;
            this.genm.Text = "Male";
            this.genm.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(421, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 20);
            this.textBox6.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "label13";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Select Country",
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
            "Yemen"});
            this.comboBox3.Location = new System.Drawing.Point(380, 235);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 21);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.Visible = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(552, 192);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(138, 49);
            this.submit.TabIndex = 26;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(133, 198);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 24;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Visible = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(644, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(625, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(138, 20);
            this.textBox9.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(552, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 20);
            this.textBox8.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(321, 273);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(138, 20);
            this.textBox7.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(321, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(321, 133);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 55);
            this.textBox4.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(321, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(538, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Other Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(557, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(465, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(211, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mobile No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(226, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(229, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pincode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(232, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(232, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(244, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(259, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(22, 17);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(186, 204);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // class_nameTableAdapter1
            // 
            this.class_nameTableAdapter1.ClearBeforeFill = true;
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.Location = new System.Drawing.Point(805, 15);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(44, 17);
            this.edit.TabIndex = 25;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.CheckedChanged += new System.EventHandler(this.edit_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(855, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tinfoBindingSource
            // 
            this.tinfoBindingSource.DataMember = "t_info";
            this.tinfoBindingSource.DataSource = this.dbteachearDataSetBindingSource;
            // 
            // t_infoTableAdapter
            // 
            this.t_infoTableAdapter.ClearBeforeFill = true;
            // 
            // te_view_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.edit);
            this.Name = "te_view_details";
            this.Text = "st_view_details";
            this.Load += new System.EventHandler(this.st_view_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classnameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_teachearDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbteachearDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource assestDataSetBindingSource;
        private assestDataSet assestDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private Db_teachearDataSet db_teachearDataSet;
        private System.Windows.Forms.BindingSource dbteachearDataSetBindingSource;
        private System.Windows.Forms.BindingSource classnameBindingSource;
        private assestDataSetTableAdapters.class_nameTableAdapter class_nameTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox edit;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic;
        private assestDataSetTableAdapters.class_nameTableAdapter class_nameTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton genf;
        private System.Windows.Forms.RadioButton genm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tinfoBindingSource;
        private Db_teachearDataSetTableAdapters.t_infoTableAdapter t_infoTableAdapter;
    }
}