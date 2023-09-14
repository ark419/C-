using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXETT
{
    public partial class Form6 : Form
    {
        Access access;
        public Form6()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.delete(textBox1.Text.Trim(), textBox2.Text.Trim());
            this.Close();
        }
    }
}
