using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainPro
{
    public partial class Add_attandance : Form
    {
        string path = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";
        DataTable d = new DataTable();
        string conn_string = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";

        public Add_attandance()
        {
            InitializeComponent();
            comboBox1.DataSource = class_load();
            comboBox1.DisplayMember = "class_name";
            comboBox1.ValueMember = "da_name";
            int date = DateTime.Now.Day-7;

            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, date);
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;

        }
        public Add_attandance(int h,int w)
        {    
            InitializeComponent();
            Height = h;
            Width = w;
            comboBox1.DataSource = class_load();
            comboBox1.DisplayMember = "class_name";
            comboBox1.ValueMember = "da_name";
            int date = DateTime.Now.Day - 7;

            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, date);
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;


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

        private DataTable student_load()
        {
            DataRowView dhg = (DataRowView)comboBox1.SelectedItem;
            SqlConnection conn = new SqlConnection(path);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use " + dhg["da_name"].ToString() + ";select s_id as 'Roll No',f_name as'First Name',l_name as 'Last Name' from s_info; ";
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet a = new DataSet();
            da.Fill(a);
            conn.Close();

            return a.Tables[0];

        }
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            { 
                c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].Name = "Product ID";
            //dataGridView1.Columns[1].Name = "Product Name";
            //dataGridView1.Columns[2].Name = "Product Price";

            //string[] row = new string[] { "1", "Product 1", "1000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "2", "Product 2", "2000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "3", "Product 3", "3000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };

            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
            dataGridView2.DataSource = student_load();
            UpdateFont();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView2.Columns.Add(btn1);
            btn1.HeaderText = "Click Data";
            btn1.Text = "P";
            btn1.Name = "btn";
            btn1.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dataGridView2.Columns.Add(btn2);
            btn2.HeaderText = "Attandance Mark";
            btn2.Text = "Mark";
            btn2.Name = "btn";
            btn2.UseColumnTextForButtonValue = true;




        }

        private List<string> loadOperators()
        {
            List<string> cl = new List<string>();

           
            cl.Add("P");
            cl.Add("2P");
            cl.Add("A");
            cl.Add("L");
            cl.Add("LE");
            return cl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {


                DataRowView dhg = (DataRowView)comboBox1.SelectedItem;
                DataRowView dhg2 = (DataRowView)comboBox2.SelectedItem;
                SqlConnection conn = new SqlConnection(path);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "use " + dhg["da_name"].ToString() + ";select * from _" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " where  date2='"+dateTimePicker1.Text+"';";
              
                conn.Open();

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet a = new DataSet();
                da.Fill(a);
                conn.Close();
                if(a.Tables[0].Rows.Count.ToString()=="0")
                {

                    cmd.CommandText = "use " + dhg["da_name"].ToString() + ";insert into _" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() +" values ('"+dateTimePicker1.Text+"'"+ get_null()+ ") ";
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    

                    cmd.CommandText = "use " + dhg["da_name"].ToString() + ";update _" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " set "+dhg2["sub_name"].ToString() +"= '"+dataGridView2.Rows[e.RowIndex].Cells[(e.ColumnIndex-1)].Value.ToString()+"' where date2 = '" + dateTimePicker1.Text +"';";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Done";



                }
                else
                {

                    conn.Open();
                    cmd.CommandText = "use " + dhg["da_name"].ToString() + ";update _" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " set " + dhg2["sub_name"].ToString() + "='" + dataGridView2.Rows[e.RowIndex].Cells[(e.ColumnIndex - 1)].Value.ToString() + "' where date2 = '" + dateTimePicker1.Text + "';";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Done";

                }
               // MessageBox.Show("use " + dhg["da_name"].ToString() + "; insert into _" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() +" values('"+dateTimePicker1.Text+"'"+ get_null()+ ")");
                



            }











            else if (e.ColumnIndex == 3)
            {
               // MessageBox.Show(dataGridView2.Rows[1].Cells[3].Value.ToString().Trim());
                if (dataGridView2.Rows[e.RowIndex ].Cells[e.ColumnIndex].Value.ToString() == "P")
                {
                    DataGridViewButtonCell a = new DataGridViewButtonCell();
                    a.Value = "A";
                    dataGridView2.Rows[e.RowIndex ].Cells[e.ColumnIndex] = a;
                   // MessageBox.Show(dataGridView2.Rows[0].Cells[3].Value.ToString().Trim());
                }
                else if(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex ].Value.ToString() == "A")
                {
                    DataGridViewButtonCell a = new DataGridViewButtonCell();
                    a.Value = "2P";
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex] = a;
                }
                else if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "2P")
                {
                    DataGridViewButtonCell a = new DataGridViewButtonCell();
                    a.Value = "L";
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex] = a;
                }
                else if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "L")
                {
                    DataGridViewButtonCell a = new DataGridViewButtonCell();
                    a.Value = "P";
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex] = a;
                }
               

            }
            //if (e.ColumnIndex == 3)
            //{ int i = 0;
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {    if(i==e.RowIndex)
            //        {

            //        }
            //        // need to get info. This should show u what im looking for. 
            //        string name = row.Cells[0].Value.ToString();  // first column
            //        string price = row.Cells[1].Value.ToString();  // second column
            //                                                       //etc

            //    }

            //}

        }


        private string get_null()
        {
            DataRowView dhg = (DataRowView)comboBox1.SelectedItem;
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use " + dhg["da_name"].ToString() + "; select * from sub_info;";
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet a = new DataSet();
            da.Fill(d);
            da.Fill(a);
            conn.Close();
            //int i;
            string temp = " ";
            foreach (DataRow x in a.Tables[0].Rows)
            {
                temp = temp +" ,'null'";
               // MessageBox.Show(temp);


            }

            return temp;

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 40;
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                height += dr.Height;
            }

            dataGridView2.Height = height;
        }

      

        private DataTable get_sub()
        {
            DataRowView dhg = (DataRowView)comboBox1.SelectedItem;
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use " + dhg["da_name"].ToString() + "; select * from sub_info;";
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet a = new DataSet();
            da.Fill(d);
            da.Fill(a);
            
            conn.Close();
           

            return a.Tables[0];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable xy = new DataTable();
            xy = get_sub();
            comboBox2.DataSource = xy;
           // comboBox2.Items.Clear();
          //  comboBox2.DataSource = xy;
            comboBox2.DisplayMember = "sub_name";
            comboBox2.ValueMember = "sub_name";
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
