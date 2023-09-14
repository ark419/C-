using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TXETT
{
    public partial class Form1 : Form
    {
         Access access;
        [DllImport("user32 ")]
        public static extern bool LockWorkStation();
        public Form1()
        {
            InitializeComponent();
            access = new Access();
        }

         private void 创建账户ToolStripMenuItem_Click(object sender, EventArgs e)
         {
          opentab(new UserControl1(), sender);
         }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opentab(new UserControl2(), sender);
        }

        private void 查询余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opentab(new UserControl3(), sender);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            opentab(new UserControl4(), sender);
        }

        private void 销户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opentab(new UserControl5(), sender);
        }
        private void 转账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opentab(new UserControl6(), sender);
        }

        private bool opentab(UserControl usc, object sender) {

            TabPage tab = new TabPage();
            tab.Name = usc.Name;
            tab.Text = ((ToolStripMenuItem)sender).Text ;
            tab.Controls.Add( usc);
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iLastIndex = tabControl1.SelectedIndex;
            int iNextIndex = 0;
            int a = 1;
            if (tabControl1.TabPages.Count < 1)
            {
                return;
            }
            if ( iLastIndex  > a)
            {
                iNextIndex = tabControl1.SelectedIndex - 1;
                tabControl1.TabPages.RemoveAt(iLastIndex);
                tabControl1.SelectedIndex = iNextIndex;
            }
            else
            {
                iNextIndex = tabControl1.SelectedIndex;
                tabControl1.TabPages.RemoveAt(iLastIndex);
                tabControl1.SelectedIndex = iNextIndex;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void skinMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
   
}
    
