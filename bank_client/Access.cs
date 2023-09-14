using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace TXETT
{
 
    class Access
    {
        //数据存放地址
        OleDbConnection oleDb = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Desktop\银行数据.mdb");

        public Access()
        {
        }
        public void AddUser(Chuhu user)
        {
            oleDb.Open();
            string sql = "insert into BankTable (accounts,pass,name,card,money2) values('" + user.accounts + "','" + user.pass + "','" + user.name + "','" + user.card + "','" + user.money + "')";
            OleDbCommand comm = new OleDbCommand(sql, oleDb);
            comm.ExecuteNonQuery();
            oleDb.Close();
        }
        public bool GetEnter(string name, string pass)
        {
            oleDb.Open();           
            string sql = "select accounts ,pass from BankTable where accounts='" + name.Trim() + "'and pass='" + pass.Trim() + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            da.Fill(dt); //用适配对象填充表对象  // dataGridView1.DataSource = dt; //将表对象作为DataGridView的数据源
      
            if (dt.Rows.Count == 0)
            {
                oleDb.Close(); return false;
            }
            else
            {
                oleDb.Close(); return true;
            }

        }

        public void Keychange(string name, string oldpass,string newpass)
        {
            Access da = new Access();
            
            if (da.GetEnter(name, oldpass))
            {
             oleDb.Open();
             string Update = "update BankTable set pass='" + newpass + "'where pass= '" + oldpass+ "'";
             OleDbCommand comm = new OleDbCommand(Update, oleDb);
             comm.ExecuteNonQuery();
             MessageBox.Show("密码修改成功");
             oleDb.Close();
            }
            else
            {
                MessageBox.Show("密码修改失败，请检查账号密码是否正确");
            }
        }
        public void Search(string name, string pass)
        {
            Access da = new Access();

            if (da.GetEnter(name, pass))
            {
                oleDb.Open();
                string sql = "select * from BankTable where accounts='" + name.Trim() + "'and pass='" + pass.Trim() + "'";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sql, oleDb); //创建适配对象
                DataTable dt = new DataTable(); //新建表对象
                da1.Fill(dt); //用适配对象填充表对象  // dataGridView1.DataSource = dt; //将表对象作为DataGridView的数据源
                MessageBox.Show("账户余额为："+dt.Rows[0]["money2"].ToString()+"元");
                oleDb.Close();
            }
            else
            {
                MessageBox.Show("请检查账号密码是否正确");
            }
        }
      
        public bool Deposit(string name, float money)
        {
          
            oleDb.Open();
            string Update = "update BankTable set money2=money2+'" + money + "'where accounts='" + name + "'"; 
            OleDbCommand comm = new OleDbCommand(Update, oleDb);
            comm.ExecuteNonQuery();
            oleDb.Close();
            return true;
           
        }
        public bool Withdrawal(string name, float money)
        {
            oleDb.Open();
            string sql = "select * from BankTable where accounts='" + name.Trim() + "'";
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql, oleDb);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            float i = (float)Convert.ToDouble(dt.Rows[0]["money2"].ToString())-money;
            if(i>=0)
            {
                oleDb.Close();
                oleDb.Open();
                string Update = "update BankTable set money2=money2-'" + money + "'where accounts='" + name + "'";
                OleDbCommand comm = new OleDbCommand(Update, oleDb);
                comm.ExecuteNonQuery();
                oleDb.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void delete(string name, string pass)
        {
            Access da = new Access();
            if (da.GetEnter(name, pass))
            {
                oleDb.Open();
                string sql = "select * from BankTable where accounts='" + name.Trim() + "'and pass='" + pass.Trim() + "'";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sql, oleDb); 
                DataTable dt = new DataTable(); 
                da1.Fill(dt);  
                float i=(float)Convert.ToDouble(dt.Rows[0]["money2"].ToString() );
                oleDb.Close();
                if (i==0)
                {
                    string sqlstr = "select accounts from BankTable where accounts='" + name + "'";
                    DataSet ds = new DataSet();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstr, oleDb);
                    adapter.Fill(ds, "BankTable");
                    oleDb.Open();
                    string sql2 = "delete from BankTable where accounts='" + name + "'";
                    OleDbCommand da2 = new OleDbCommand(sql2, oleDb);
                    da2.ExecuteNonQuery();
                    oleDb.Close();
                    MessageBox.Show("销户成功");
                 }
                else
                {
                    MessageBox.Show("账号有余额无法销户");
                }
            }
            else
            {
                MessageBox.Show("请检查账号密码是否正确");
            }
        }
    }
}
