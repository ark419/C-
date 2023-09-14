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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            access = new Access();
        }
        Access access;
        private void button1_Click_1(object sender, EventArgs e)
        {
            access.Keychange(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
        }
    }
}
