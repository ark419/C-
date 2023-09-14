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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            textBox3.TextChanged += TextBox3_TextChanged;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().StartsWith(textBox3.Text.Trim())) {
                //textBox3.BackColor = Color.White;
                label2.Text = " ";
            }

            else
            {
                // textBox3.BackColor = Color.Red;
                label2.Text = "两次密码输入不一致";
                label2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != textBox3.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致");
            }
            else
              if (textBox1.Text.Trim() == "") { MessageBox.Show("请输入用户名!"); textBox1.Focus(); }
            else
                  if (textBox2.Text.Trim() == "") { MessageBox.Show("请输入密码!"); textBox2.Focus(); }
            else
                      if (textBox3.Text.Trim() == "") { MessageBox.Show("请确认密码!"); textBox3.Focus(); }
            else
                          if (textBox4.Text.Trim() == "") { MessageBox.Show("请输入真实姓名!"); textBox4.Focus(); }
            else
                              if (textBox5.Text.Trim() == "") { MessageBox.Show("请输入身份证号码!"); textBox5.Focus(); }
            else
                                  if (textBox6.Text.Trim() == "") { MessageBox.Show("请输入开户金额!"); textBox6.Focus(); }
            else
            {
                Chuhu user = new Chuhu();
                user.accounts = textBox1.Text.Trim();
                user.pass = textBox2.Text.Trim();
                user.name = textBox4.Text.Trim();
                user.card = textBox5.Text.Trim();
                user.money = (float)Convert.ToDouble(textBox6.Text.Trim());
                Access a = new Access();
                a.AddUser(user);
                MessageBox.Show("开户成功");
              //  this.Close();
            }

        }
    
    }
}
