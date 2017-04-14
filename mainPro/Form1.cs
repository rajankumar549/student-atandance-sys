using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;
using Wpf;


namespace mainPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this.WindowState= FormWindowState.Maximized;
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width= Screen.PrimaryScreen.Bounds.Width;
            

            /*this.ShowInTaskbar = false;
           this.ControlBox = false;
            this.Text = null;
            // this.MaximizeBox = true;*/
        }

        private void teachearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
           if (o.ActiveMdiChild!=null)
            o.ActiveMdiChild.Close();
            Form2 obj = new Form2();
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;
            obj.Show();
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            Form2 obj = new Form2(Screen.PrimaryScreen.Bounds.Height,Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();
        }

        private void Form1_MaximizedBoundsChanged(object sender, EventArgs e)
        {
           
           /* Form2 obj = new Form2(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();*/
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild!=null)
            o.ActiveMdiChild.Close();
          
          
            Form2 obj = new Form2(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();
            @default obj = new @default();
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;
            obj.Show();
        }

        

        private void classToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();
            class_add obj = new class_add(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;
              obj.Show();

        }

        private void attandaceCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();


            att_check obj = new att_check(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();


            stuudent obj = new stuudent(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();
        }

        private void addNewTeachearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();


            Form2 obj = new Form2(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();
        }

        private void markAttandanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();


            Add_attandance obj = new Add_attandance(Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width);
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.MdiParent = this;

            obj.Show();
        }

        private void viewProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void showTimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wpf.chart ti = new chart();
            ti.ShowDialog();
            Form1 o = this;
            if (o.ActiveMdiChild != null)
                o.ActiveMdiChild.Close();


            chart obj = new chart(Screen.PrimaryScreen.Bounds.Height-50, Screen.PrimaryScreen.Bounds.Width-50);


            obj.ShowDialog();




        }
    }
}
