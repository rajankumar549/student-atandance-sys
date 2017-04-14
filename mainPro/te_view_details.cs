using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainPro
{
    public partial class te_view_details : Form
    {
        string conn_string = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";
        byte[] photo_aray;
        public te_view_details()
        {
            InitializeComponent();
            
        }

        private void st_view_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_teachearDataSet.t_info' table. You can move, or remove it, as needed.
            this.t_infoTableAdapter.Fill(this.db_teachearDataSet.t_info);
            // TODO: This line of code loads data into the 'assestDataSet.class_name' table. You can move, or remove it, as needed.
            this.class_nameTableAdapter.Fill(this.assestDataSet.class_name);

        }

        

      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (comboBox2.Items.Count >= 1)
            {


                SqlConnection conn = new SqlConnection(conn_string);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataRowView d_view = (DataRowView)comboBox2.SelectedItem;
                if (d_view!=null)
                {



                    try
                    {

                        cmd.CommandText = "use Db_teachear;select * from s_info where s_id = '" + comboBox2.SelectedValue.ToString() + "';";
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        panel1.Visible = false;

                        MessageBox.Show(ex.ToString());
                        return;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet d_set = new DataSet();
                    da.Fill(d_set);
                    conn.Close();
                    DataRow d_row = d_set.Tables[0].Rows[0];


                    textBox1.Text = d_row[0].ToString();
                    textBox2.Text = d_row[1].ToString();
                    textBox6.Text = d_row[2].ToString();
                    photo_aray = (byte[])d_row[3];
                    MemoryStream memorystream = new MemoryStream(photo_aray, 0, photo_aray.Length);


                    Image image = Image.FromStream(memorystream);


                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = image;




                    if (d_row[4].ToString() == "Female")
                    {
                        genf.Checked = true;
                        genm.Checked = false;

                    }
                    else
                    {
                        genf.Checked = false;
                        genm.Checked = true;
                    }


                    textBox4.Text = d_row[5].ToString();

                    textBox5.Text = d_row[6].ToString();

                    label13.Text = d_row[7].ToString();

                    textBox7.Text = d_row[8].ToString();

                    textBox8.Text = d_row[9].ToString();

                    dateTimePicker1.Value = Convert.ToDateTime(d_row[10].ToString());

                    textBox9.Text = d_row[11].ToString();
                    panel1.Visible = true;
                    button1.Enabled = true;
                }
                else
                {
                   // MessageBox.Show("Select student");
                   
                }
            }
            else
            {
                MessageBox.Show("there is no student");
                panel1.Visible = false;

            }

        }

        private void edit_CheckedChanged(object sender, EventArgs e)
        {
            if(edit.Checked==true)
            {
                panel1.Enabled = true;
                upload.Visible= true;
                submit.Visible = true;
                comboBox3.Visible = true;


            }
            else
            {
                panel1.Enabled = !true;
                upload.Visible = !true;
                submit.Visible = !true;
                comboBox3.Visible = !true;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||textBox6.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.SelectedIndex == -1 || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Fill all the entery!!!!\n");
                /* ErrorProvider obj = new ErrorProvider();
                 obj.SetError(f_name, "invalid name");*/
                return;
            }

            if (!Regex.Match(textBox2.Text, "^[A-Z][a-zA-Z]*$").Success|| !Regex.Match(textBox6.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid name!!!!\n");
                return;
            }


            if (!(Regex.Match(textBox5.Text, "^[0-9]*$").Success || textBox5.Text.Length > 6))
            {
                MessageBox.Show("Invalid Pin!!!!\n");
                return;
            }
           
            SqlConnection  con = new SqlConnection(conn_string);

            SqlCommand cmd = new SqlCommand("use Db_teacher; update t_info set f_name=@p1,l_name=@p2,pic=@p3,gen=@p4,address=@p5,pin=@p6,country=@p7,c_no=@p8,email=@p9,dob=@p10,other_info=@p11 where t_id=@p12;",con);
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
            cmd.Parameters.Add("@p12", SqlDbType.VarChar, 20).Value = textBox1.Text;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 50).Value = textBox2.Text;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 50).Value = textBox6.Text;
            cmd.Parameters.AddWithValue("@p3", photo_aray);

            cmd.Parameters.Add("@p4", SqlDbType.VarChar, 10).Value = gen_check();
            cmd.Parameters.Add("@p5", SqlDbType.VarChar, 500).Value = textBox4.Text;
            cmd.Parameters.Add("@p6", SqlDbType.VarChar, 10).Value = textBox5.Text;
            cmd.Parameters.Add("@p7", SqlDbType.VarChar, 50).Value = comboBox3.SelectedItem.ToString();
            cmd.Parameters.Add("@p8", SqlDbType.VarChar, 20).Value = textBox7.Text;
            cmd.Parameters.Add("@p9", SqlDbType.VarChar, 50).Value = textBox8.Text;
            cmd.Parameters.Add("@p10", SqlDbType.VarChar, 50).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@p11", SqlDbType.VarChar, 500).Value = textBox9.Text;


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
          
            MessageBox.Show("Done");
            
            panel1.Enabled=false;
            edit.Checked = false;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image k = new Bitmap(dlg.FileName);
                Bitmap photo = new Bitmap(k, pic.Width, pic.Width);
                pic.Image = photo;

                string imageName = dlg.FileName;
               
                FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                photo_aray = new byte[fstream.Length];
                fstream.Read(photo_aray, 0, Convert.ToInt32(fstream.Length));
                fstream.Close();




            }
        }

        string gen_check()
        {
            string gen = genm.Text;
            if (genf.Checked)
            {
                gen = genf.Text;
            }
            return gen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you really wnt to delete the record","attantion",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(conn_string);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataRowView d_view = (DataRowView)comboBox2.SelectedItem;
                cmd.CommandText = "use Db_teachear;delete t_info where t_id = '" + comboBox2.SelectedValue.ToString() + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
              
                conn.Close();
                MessageBox.Show("work done");
                button1.Enabled = false;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
