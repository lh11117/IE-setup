using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win11_IE启动器
{
    public partial class Form1 : Form
    {
        private bool isMax = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lh11117/IE-setup");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 tips = new Form2();
            tips.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 点击panel控件移动窗口
        private Point downPoint;
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Left");
            downPoint = new Point(e.X, e.Y);
        }
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }
        #endregion

        private void label1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!isMax)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
