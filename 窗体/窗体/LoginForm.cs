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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = this.txbname.Text;
            string passWord = this.txbpwd.Text;
            string selectedType = this.cmbLeixin.Text;

            if (txbname.Text == "" || txbpwd.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                if (cmbLeixin.Text == "学生")
                {
                    string sqlstr = string.Format("select Studentname,StudentPhone from studentzh where Studentname='{0}'", txbname.Text);
                    SqlDataReader reader = DBHelper.GetDataReader(sqlstr);
                    while (reader.Read())
                    {
                        string name = reader["Studentname"].ToString();
                        string psd = reader["StudentPhone"].ToString();

                        //管理员登录
                        if (txbname.Text == name && txbpwd.Text == psd && cmbLeixin.Text == "学生")
                        {  
                            MessageBox.Show("登录成功！");
                            StudentForm student = new StudentForm();
                            student.Show();
                            this.Hide();
                          
                        }
                        else
                        {
                            MessageBox.Show("登录失败！");
                        }

                    }
                    reader.Close();
                }
                else if (cmbLeixin.Text == "管理员")
                {
                    string sqlstr = "select * from guanliyuan";
                    SqlDataReader reader = DBHelper.GetDataReader(sqlstr);
                    while (reader.Read())
                    {
                        string zh = reader["zhanghao"].ToString();
                        string mima = reader["mima"].ToString();

                        //管理员登录
                        if (txbname.Text == zh && txbpwd.Text == mima && cmbLeixin.Text == "管理员")
                        {
                            MessageBox.Show("登录成功！");
                            ManageForm teacher = new ManageForm();
                            teacher.Show();
                            this.Hide();

                        }
                      
                    }
                    reader.Close();
                
                }
            
            }
            
            //string stlongf = @"select * from guanliyuan where zhanghao = '" + userName + "' and mima = '" + passWord + "' and quble = " + lll + "";
            //DataTable dt = new DataTable();
            //dt = DBHelper.ExecuteQuery(stlongf);
            //if (dt.Rows.Count > 0 && selectedType == "学生")
            //{
            //    StudentForm form8 = new StudentForm();
            //    form8.Show();
            //    this.Hide();
            //}
            //else if (dt.Rows.Count > 0 && selectedType == "管理员")
            //{
            //    ManageForm form2 = new ManageForm();
            //    form2.Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("账号或密码错误！");
            //if (userName == "" || passWord == "")
            //{
            //    MessageBox.Show("用户名和密码不能为空！");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


    }
}
