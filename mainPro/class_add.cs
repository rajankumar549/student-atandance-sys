using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Wpf;

namespace mainPro
{
    public partial class class_add : Form
    {
        string path = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";
        DataTable d = new DataTable();
        public class_add()
        {
            InitializeComponent();
            
         }

        private DataTable class_load()
        {
            SqlConnection conn = new SqlConnection(path);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use assest;select * from class_name;";
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(d);
            conn.Close();
            
            return d;

        }

        public class_add(int h, int w)
        {

            InitializeComponent();
            Height = h;
            Width = w;
            //comboBox5.DataSource = class_load();
            //comboBox5.DisplayMember = "class_name";
            //comboBox5.ValueMember = "da_name";


        }
        





        void sub_load()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(path);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_" + inp.Text + ";Select * from sub_info ;";
            conn.Open();
            cmd.ExecuteNonQuery();
            ListViewItem ob = new ListViewItem();
            DataTable d = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(d);
            /*  string value;
              int key = 0;*/
              
            foreach (DataRow row in d.Rows)
            {

                listView1.Items.Add( row["sub_name"].ToString().Replace('_',' '));


            }
            conn.Close();

        }
        void combo_sub_load()
        {
            comboBox1.Items.Clear();
            comboBox18.Items.Clear();
            comboBox20.Items.Clear();
            comboBox22.Items.Clear();
            comboBox24.Items.Clear();
            comboBox26.Items.Clear();
            comboBox28.Items.Clear();
            comboBox30.Items.Clear();
            comboBox4.Items.Clear();

            SqlConnection conn = new SqlConnection(path);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_" + inp.Text + ";Select * from sub_info ;";
            conn.Open();
            cmd.ExecuteNonQuery();
            ListViewItem ob = new ListViewItem();
            DataTable d = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(d);
            /*  string value;
              int key = 0;*/

            foreach (DataRow row in d.Rows)
            {

                comboBox1.Items.Add(row["sub_name"].ToString());
                comboBox18.Items.Add(row["sub_name"].ToString());
                comboBox20.Items.Add(row["sub_name"].ToString());
                comboBox22.Items.Add(row["sub_name"].ToString());
                comboBox24.Items.Add(row["sub_name"].ToString());
                comboBox26.Items.Add(row["sub_name"].ToString());
                comboBox28.Items.Add(row["sub_name"].ToString());
                comboBox30.Items.Add(row["sub_name"].ToString());
                comboBox4.Items.Add(row["sub_name"].ToString());
                comboBox17.Items.Add(row["sub_name"].ToString());


            }
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = inp.Text;

            if (Regex.Match(input, "[a-zA-Z]$").Success)
            {
                groupBox2.Visible = false;
                SqlConnection conn = new SqlConnection(path);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "use   Db_" + input + " ;";


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    groupBox2.Visible = true;
                    sub_load();
                    combo_sub_load();



                }
                catch (SqlException ex)
                {
                    if (ex.Number.ToString() == "911")
                    {
                        if (MessageBox.Show("Class name not match any class", "Confermation do you want to create", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            cmd.CommandText = "create database Db_" + input + " ;";

                            try
                            {

                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "use Db_" + input + ";  create table " + input + "(Da varchar(60),slot1 varchar(60),slot2 varchar(60),slot3 varchar(60),slot4 varchar(60),slot5 varchar(60),slot6 varchar(60),slot7 varchar(60),slot8 varchar(60),slot9 varchar(60)); insert into " + inp.Text + " (da) values('mon');insert into " + inp.Text + "(da) values('tue');insert into " + inp.Text + "(da) values('wed');insert into " + inp.Text + "(da) values('thu');insert into " + inp.Text + "(da) values('fri');insert into " + inp.Text + "(da) values('sat'); UPDATE " + inp.Text + " set slot1 = 'default' where slot1 is null;UPDATE " + inp.Text + " set slot2 = 'default' where slot2 is null;UPDATE " + inp.Text + " set slot4 = 'default' where slot4 is null;UPDATE " + inp.Text + " set slot3 = 'default' where slot3 is null;UPDATE " + inp.Text + " set slot5 = 'default' where slot5 is null;UPDATE " + inp.Text + " set slot6 = 'default' where slot6 is null;UPDATE " + inp.Text + " set slot7 = 'default' where slot7 is null;UPDATE " + inp.Text + " set slot8 = 'default' where slot8 is null; UPDATE " + inp.Text + " set slot9 = 'default' where slot9 is null; ";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "create table sub_info(sub_name varchar(20) unique);";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "use assest ; insert into class_name values(@p1,@p2)";
                                cmd.Parameters.AddWithValue("@p1", input);
                                cmd.Parameters.AddWithValue("@p2", "Db_" + input);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Class is added please re-check Your class", "confermation", MessageBoxButtons.OK);
                            }
                            catch
                            {
                                MessageBox.Show("please try again");
                            }



                        }


                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                finally
                {
                    conn.Close();
                }
                this.class_load();
            }
            else
            {
                MessageBox.Show("please enter valid class name");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(path))
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.CommandText = "use " + comboBox1.SelectedValue + ";select * from s_info;";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    comboBox2.Visible = false;

                    comboBox2.DataSource = null;
                    MessageBox.Show("try again");
                    return;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet d_set = new DataSet();
                da.Fill(d_set);
                if(d_set.Tables[0].Rows.Count<1)
                {
                    MessageBox.Show("you cant add subject now bcause us add student already-----");
                    return;
                }
                conn.Close();
            }



            if (Regex.Match(textBox1.Text, "[a-zA-Z]$").Success&&(textBox1.Text!="add"))
            {

                string inp2 = textBox1.Text;
                inp2 = inp2.Replace(' ', '_');
                //  MessageBox.Show(inp);
                SqlConnection conn = new SqlConnection(path);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "use Db_" + inp.Text + ";insert into sub_info values('" + inp2 + "');";

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Text = "add";

                }
                catch (SqlException ex)
                {
                    if (ex.Number.ToString() == "2627")
                    {
                        MessageBox.Show("Duplicate subject can't be added");
                    }
                    else
                    {


                        MessageBox.Show("please try again! subject not add");
                        textBox1.Focus();
                    }
                  
                    return;
                }

                sub_load();
            }
            else
            {
                MessageBox.Show("invalid subject name");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sub_load();

           //String s = new String(' ', 3);
           //   s = s.Replace(' ', 'b').Replace('b', 'c').Replace('c', 'd');
           //   MessageBox.Show(s);
           // String.Replace
            
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
            e.DrawText();
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        void validate(TextBox t1, TextBox t2)
        { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            // radioButton1.Checked = true;


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            //radioButton4.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            // radioButton2.Checked = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton6.Checked = false;
            // radioButton5.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            // radioButton3.Checked = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            // radioButton6.Checked = true;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (!(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true))
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                MessageBox.Show("please select a day first");
                return;
            }
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox2.Text = t1.TheValue;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox3.Text = t1.TheValue;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox19.Text = t1.TheValue;
        }

        private void textBox18_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox18.Text = t1.TheValue;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox20_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox20.Text = t1.TheValue;
        }

        private void textBox23_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox23.Text = t1.TheValue;
        }

        private void textBox22_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox22.Text = t1.TheValue;
        }

        private void textBox25_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox25.Text = t1.TheValue;
        }

        private void textBox24_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox24.Text = t1.TheValue;
        }

        private void textBox27_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox27.Text = t1.TheValue;
        }

        private void textBox26_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox26.Text = t1.TheValue;
        }

        private void textBox29_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox29.Text = t1.TheValue;
        }

        private void textBox28_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox28.Text = t1.TheValue;
        }

        private void textBox31_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox31.Text = t1.TheValue;
        }

        private void textBox30_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox30.Text = t1.TheValue;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox5.Text = t1.TheValue;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox4.Text = t1.TheValue;
        }

        private void textBox21_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox21.Text = t1.TheValue;
        }

       
        private void textBox19_Enter(object sender, EventArgs e)
        {
            time t1 = new time();
            t1.ShowDialog();
            textBox19.Text = t1.TheValue;
        }

        void final(TextBox t1, TextBox t2, ComboBox sub, ComboBox teach ,string slot)
        {
            if(t1.Text == "" || t2.Text == "" || sub.SelectedIndex == -1 || teach.SelectedIndex == -1)
            {
                MessageBox.Show("please enter valid entry");
            }
            else
            {
                string data = "$" + t1.Text + "$" + t2.Text + "$" + sub.SelectedItem.ToString() + "$" + teach.SelectedItem.ToString() + "$";
                string test="";
                SqlConnection conn = new SqlConnection(path);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();

                cmd.CommandText = "use Db_"+inp.Text+";select slot2 from   "+inp.Text+ "   where Da = '" + day() + "';";
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                DataTable d = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(d);
                foreach (DataRow row in d.Rows)
                {
                     test= row["slot2"].ToString();
               }
                test = test.Replace('$', ' ');
                if(MessageBox.Show("do you sure to continue to replace\n" + test,"alert",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    cmd.CommandText = " UPDATE " + inp.Text + " set slot2 = '" + data + "' where Da='" + day() + "';";
                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("done");
                }
                else
                {

                }
                conn.Close();








            }
        }

       string day()
        {
            if(radioButton1.Checked==true)
            {
                return "mon";
            }
            if (radioButton5.Checked == true)
            {
                return "tue";
            }
            if (radioButton4.Checked == true)
            {
                return "wed";

            }
            if (radioButton3.Checked == true)
            {
                return "thu";
            }
            if (radioButton2.Checked == true)
            {
                return "fri";
            }
            else
            {
                return "sat";
            }
          
        }


        private void button4_Click(object sender, EventArgs e)
        {
            final(textBox2, textBox3, comboBox1, comboBox2, "slot1");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /* if(textBox18.Text==""||textBox19.Text==""||comboBox17.SelectedIndex==-1||comboBox18.SelectedIndex==-1)
             {
                 MessageBox.Show("please enter valid entry");
             }
             else
             {

               // string data = "$"+te



             }*/
            final(textBox19, textBox18, comboBox18, comboBox17,"slot2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            final(textBox21, textBox20, comboBox20, comboBox19, "slot3");
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            final(textBox23, textBox22, comboBox22, comboBox21, "slot4");
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            final(textBox25, textBox24, comboBox24, comboBox23, "slot5");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            final(textBox27, textBox26, comboBox26, comboBox25, "slot6");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            final(textBox29, textBox28, comboBox28, comboBox27, "slot7");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            final(textBox31, textBox30, comboBox30, comboBox29, "slot8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            final(textBox5, textBox4, comboBox4, comboBox3, "slot9");
        }

        private void class_add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_teachearDataSet.t_info' table. You can move, or remove it, as needed.
            this.t_infoTableAdapter.Fill(this.db_teachearDataSet.t_info);
            // TODO: This line of code loads data into the 'assestDataSet.class_name' table. You can move, or remove it, as needed.
            this.class_nameTableAdapter.Fill(this.assestDataSet.class_name);

        }
    }
}

