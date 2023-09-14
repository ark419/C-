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
    public partial class Form3 : Form
       
    {
        Access access;
        public Form3()
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.Keychange(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              this.Close();
         }
    }
}
