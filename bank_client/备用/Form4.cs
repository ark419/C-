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
    public partial class Form4 : Form
    {
        Access access;
        public Form4()
             
        {
            InitializeComponent();
            access = new Access();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.Search(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
