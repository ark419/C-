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
    public partial class UserControl5 : UserControl
    {
        Access access;
        public UserControl5()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.delete(textBox1.Text.Trim(), textBox2.Text.Trim());
        }
    }
}
