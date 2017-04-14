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
    public partial class att_check : Form
    {
        //string path = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";
        DataTable d = new DataTable();
        string conn_string = "Data Source=localhost;" + "Initial Catalog= master;" + "Integrated Security=SSPI;";

        public att_check()
        {
            InitializeComponent();
        }
        public att_check(int h, int w)
        {
            InitializeComponent();
            Height = h;
            Width = w; ;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_csb;select * from _2016csb05 where  date2 between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text+"';";
            
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet a = new DataSet();
            da.Fill(d);
            da.Fill(a);
            dataGridView1.DataSource = a.Tables[0];
            conn.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = null;
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "use Db_csb;select * from _2016csb05 where  date2 between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';";

            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet a = new DataSet();
            da.Fill(d);
            da.Fill(a);
            conn.Close();
            d = a.Tables[0];
            int i, n,j;
            n = Convert.ToInt32(d.Columns.Count.ToString()) - 1;
            DataTable op = new DataTable();
            op.Columns.Add("Name");
            op.Columns.Add("attend");
            op.Columns.Add("total");
            op.Columns.Add("Percentage");

            int now, total2,g_total=0,g_now=0,per;
            for (i = 0; i < n; i++)
            {
                now = 0;
                total2 = 0;
                total(i + 1, ref now, ref total2);
                 per = (now * 100) / total2;
                g_total = total2 + g_total;
                g_now = g_now + now;

                op.Rows.Add(d.Columns[i+1].ColumnName.ToString(),now.ToString(),total2.ToString(),per.ToString()+"%");
            }
            per = (g_now * 100) / g_total;
            op.Rows.Add("Total Percentage", g_now.ToString(), g_total.ToString(),per.ToString()+ "%");



            dataGridView2.DataSource = null;
            dataGridView2.DataSource = op;
        }

        void total(int i,ref int now,ref int total)
        {
            

            foreach (DataRow x in d.Rows)
            {
                //k =k+ "\n" + x[d.Columns[1].ColumnName].ToString();
                if (x[d.Columns[i]].ToString() == "P")
                {
                    now++;
                    total++;
                   // MessageBox.Show(d.Columns[i].ToString());
                }
                else if (x[d.Columns[i]].ToString() == "A")
                {
                    total++;
                    
                   // MessageBox.Show(d.Columns[i].ToString());


                }
                
                else if (x[d.Columns[i]].ToString()== "2P")
                {
                    total += 2;
                    now += 2;
                   // MessageBox.Show(d.Columns[i].ToString());
                }
                
                else
                {
                   // MessageBox.Show(d.Columns[i].ToString());
                }
            }
          //  double per = (now * 100) / total;
            //return per.ToString();
            //MessageBox.Show(per.ToString());
        }
    }
}
