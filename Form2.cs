using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win11_IE启动器
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.cn/chrome");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*public BaseForm_hasBar_large()
        {
            InitializeComponent();
            this.TopBar.MouseDown += TopBar_MouseDown;
            this.TopBar.MouseMove += TopBar_MouseMove;
        }*/

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
    }
}
