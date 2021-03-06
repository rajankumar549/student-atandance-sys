﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace mainPro
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
       // SqlDataAdapter adapter;
        //DataSet ds;
       // int rno = 0;
        //MemoryStream ms;
        byte[] photo_aray;
        //byte[] b1;
        string conn_string = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";
        void database_check()
        {
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_teachear;";
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                // MessageBox.Show("work done");
            }

            catch (SqlException ex)
            {
                if (ex.Number.ToString() == "911")
                {
                    MessageBox.Show("There is no data records exixt in your system\n we create the new records files");
                    cmd.CommandText = "create database Db_teachear;";

                    try
                    {

                        cmd.ExecuteNonQuery();
                        database_check();

                    }
                    catch
                    {
                        MessageBox.Show("please try again");
                    }
                }

            }
            finally
            {
                conn.Close();
            }

        }



        void table_check()
        {
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_teachear; SET ROWCOUNT 1;select t_id from t_info order by t_id desc; ";
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                // MessageBox.Show("work done");
                DataTable d = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                MessageBox.Show("work done 1111");
                da.Fill(d);
                if(d.Rows.Count==0)
                {
                    id.Text = "Teach001";
                }
                else
                {
                    id.Text = id_gen(d.Rows[0][0].ToString());
                }
                
            }

            catch (SqlException ex)
            {
                if (ex.Number.ToString() == "208")
                {
                    MessageBox.Show("There is no records exixt in your system\n we create the new records files");
                    cmd.CommandText = "use Db_teachear;create table  t_info(t_id varchar(20) primary key, f_name varchar(50),l_name varchar(50),pic  image, gen varchar(10),address varchar(500),pin varchar(10),country varchar(50), c_no varchar(20), email varchar(50),dob varchar(50),other_info varchar(500))";

                    try
                    {

                        cmd.ExecuteNonQuery();
                        table_check();




                    }
                    catch
                    {
                        MessageBox.Show("please try again");
                    }
                }

            }
            finally
            {
                conn.Close();
            }

        }

        private string id_gen(string v)
        {

            
                int temp = Convert.ToInt32(v.Substring(5)) + 1;
                if (temp < 10)
                {
                    v = "Teach00" + temp;
                }
               else if (temp < 100)
                {
                    v = "Teach0" + temp;
                }
              else   if (temp < 1000)
                {
                    v = "Teach" + temp;
                }


            
            return v;
        }

        public Form2()
        {
            InitializeComponent();
            database_check();
            table_check();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(int h, int w)
        {
            InitializeComponent();
            Height = h;
            Width = w;
            database_check();
            table_check();
        }

        private void Form2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            f_name.Text = "";
            f_name.Width = 200;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            f_name.Width = 100;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f_name.Text == "" || l_name.Text == "" || id.Text == "" || add.Text == "" || pin.Text == "" || country.SelectedIndex == -1 || mob.Text == "" || email.Text == ""||path.Text=="")
            {
                MessageBox.Show("Please Fill all the entery!!!!\n");
               /* ErrorProvider obj = new ErrorProvider();
                obj.SetError(f_name, "invalid name");*/
                return;
            }

            if (!Regex.Match(f_name.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid name!!!!\n");
                return;
            }


            if (!(Regex.Match(pin.Text, "^[0-9]*$").Success || pin.Text.Length > 6))
            {
                MessageBox.Show("Invalid Pin!!!!\n");
                return;
            }

            con = new SqlConnection(conn_string);

            cmd = new SqlCommand("use Db_teachear;insert into t_info values( @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12);", con);
            //cmd.Parameters.AddWithValue("@p1", id.Text);
            //cmd.Parameters.AddWithValue("@p2", f_name.Text);
            //cmd.Parameters.AddWithValue("@p3", l_name.Text);
            //cmd.Parameters.AddWithValue("@p4", photo_aray);
            //cmd.Parameters.AddWithValue("@p5",gen_check() );
            //cmd.Parameters.AddWithValue("@p6", add.Text);
            //cmd.Parameters.AddWithValue("@p7", pin.Text);

            //cmd.Parameters.AddWithValue("@p8",country.SelectedText.ToString());
            //cmd.Parameters.AddWithValue("@p9", mob.Text);

            //cmd.Parameters.AddWithValue("@p10",email.Text);
            //cmd.Parameters.AddWithValue("@p11", dob.Text);
            //cmd.Parameters.AddWithValue("@p12", other.Text);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20).Value = id.Text;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 50).Value = f_name.Text;
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 50).Value = l_name.Text;
            cmd.Parameters.AddWithValue("@p4",photo_aray);

            cmd.Parameters.Add("@p5", SqlDbType.VarChar, 10).Value = gen_check();
            cmd.Parameters.Add("@p6", SqlDbType.VarChar, 500).Value = add.Text;
            cmd.Parameters.Add("@p7", SqlDbType.VarChar, 10).Value = pin.Text;
            cmd.Parameters.Add("@p8", SqlDbType.VarChar, 50).Value = country.SelectedText;
            cmd.Parameters.Add("@p9", SqlDbType.VarChar, 20).Value = mob.Text;
            cmd.Parameters.Add("@p10", SqlDbType.VarChar, 50).Value = email.Text;
            cmd.Parameters.Add("@p11", SqlDbType.VarChar,50).Value = dob.Text;
            cmd.Parameters.Add("@p12", SqlDbType.VarChar, 500).Value = other.Text;


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");





        }

        string gen_check()
        {
            string gen = m_gen.Text;
            if(f_gen.Checked)
            {
                gen = f_gen.Text;
            }
            return gen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image k = new Bitmap(dlg.FileName);
                Bitmap photo = new Bitmap(k, pictureBox1.Width,pictureBox1.Width);
                pictureBox1.Image = photo;
                
                string imageName = dlg.FileName;
                path.Text = imageName;
                FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                photo_aray = new byte[fstream.Length];
                fstream.Read(photo_aray, 0, Convert.ToInt32(fstream.Length));
                fstream.Close();
               



            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

