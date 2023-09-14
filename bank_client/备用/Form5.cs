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
    public partial class Form5 : Form
    {
        Access access;
        public Form5()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.Deposit(textBox1.Text.Trim(), (float)Convert.ToDouble(textBox2.Text.Trim()));
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            access.Withdrawal(textBox1.Text.Trim(), (float)Convert.ToDouble(textBox2.Text.Trim()));
            this.Close();
        }
    }
}
