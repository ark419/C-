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

    public partial class UserControl6 : UserControl
    {
        Access access;
        public UserControl6()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (access.Withdrawal(textBox1.Text.Trim(), (float)Convert.ToDouble(textBox3.Text.Trim())))
            {
                access.Deposit(textBox2.Text.Trim(), (float)Convert.ToDouble(textBox3.Text.Trim()));
                MessageBox.Show("转账成功");
            }
            else
            {
                MessageBox.Show("余额不足");
            }
        }
    }
}

