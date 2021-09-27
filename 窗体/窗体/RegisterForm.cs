using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 窗体
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string phone = txbPhone.Text;
            

            if (name == "" ||  phone == "" )
            {
                if (name == "")
                {
                    MessageBox.Show("姓名不能为空！");
                }
                if (phone == "")
                {
                    MessageBox.Show("电话不能为空！");
                }
            }
            else
            {
                bool flag = false;
                string str = "select studentPhone from studentzh";
                SqlDataReader reader = DBHelper.GetDataReader(str);
                while (reader.Read())
                {
                    string studentPhone = reader["studentPhone"].ToString();
                    if (studentPhone == txbPhone.Text)
                    {
                        MessageBox.Show("电话号码已注册！");
                        flag = true;
                        reader.Close();
                    }
                }
                reader.Close();

                if (!flag)
                {
                    string sqlstr = string.Format("insert into studentzh(studentname,studentphone)values('{0}','{1}')",name,phone);
                    bool i = DBHelper.ExecuteNonQuery(sqlstr);
                    if (i == true)
                    {
                        MessageBox.Show("注册成功！");
                        reader.Close();
                    }
                }
            }

            //if (txt_name2.Text == txt_name3.Text)
            //{
            //    int qx = 0;
            //    if (radioButton1.Checked)
            //    {
            //        qx = 0;
            //    }
            //    if (radioButton2.Checked)
            //    {
            //        qx = 1;
            //    }
            //    string lll = "insert guanliyuan (zhanghao,mima,quble) values ('" + txt_name.Text + "','" + txt_name2.Text + "','" + qx + "')";
            //    string stlongf = @"select * from guanliyuan where zhanghao = '" + txt_name.Text + "' and mima = '" + txt_name2.Text + "' and quble = " + qx + "";
            //    DBHelper.ExecuteNoQuery(lll);
            //    DataTable dt = new DataTable();
            //    dt = DBHelper.ExecuteQuery(stlongf);
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("注册成功！");
            //        LoginForm LoginForm = new LoginForm();
            //        LoginForm.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("注册失败！请重试！");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("两次密码输入不一致！请重新输入！");
            //    txt_name2.Text = "";
            //    txt_name3.Text = "";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
