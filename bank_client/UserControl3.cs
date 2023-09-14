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
    public partial class UserControl3 : UserControl
    {
        Access access;

        public UserControl3()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          access.Search(textBox1.Text, textBox2.Text);
        }
    }
}
