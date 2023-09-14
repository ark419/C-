using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXETT
{
    public partial class UserControl4 : UserControl
    {
        Access access;
        public UserControl4()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.Deposit(textBox1.Text.Trim(), (float)Convert.ToDouble(textBox2.Text.Trim()));
            MessageBox.Show("存款成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(access.Withdrawal(textBox1.Text.Trim(), (float)Convert.ToDouble(textBox2.Text.Trim())))
            { 
                MessageBox.Show("取款成功"); 
            }
            else
            {
              MessageBox.Show("余额不足");
            }
        }
        }
}

