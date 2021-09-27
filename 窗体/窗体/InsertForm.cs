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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }
        SqlConnection coon = new SqlConnection(DBHelper.conStr);
        private void 编辑学生信息_Load(object sender, EventArgs e)
        {
          
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // string name = this.Tb_name.Text;
           // string sex = "";
           // if (Rb_man.Checked == true)
           // {
           //     sex = Rb_man.Text;
           // }
           // else
           // {
           //     sex = Rb_woman.Text;
           // }
           // string Grade = this.Cb_grade.Text;
           // string dianhua = this.Tb_phone.Text;
           // string dizhi = this.Tb_adress.Text;
           // string riqi = this.Dtp_date.Value.ToString("yyyy-MM-dd");
           // string youbian = this.Tb_email.Text;
           // string Xuehao = this.Tb_xuehao.Text;
           // string sqlstr = string.Format
           //("insert Student(StuName,Sex,GradeNo,Tel,Adress,[E-mail],XueHao)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", name, sex, Grade, dianhua, dizhi, youbian, Xuehao);
           // bool panding1 = DBHelper.ExecuteNonQuery(sqlstr);
           // if (panding1 == true)
           // {
           //     MessageBox.Show("添加成功");
           // }
           // else {
           //     MessageBox.Show("添加失败");
           // }
            //string Kemu = this.Tb_kemu.Text;
            //string chengji = Tb_score.Text;
            //string kaoshishijian = this.Dtp_testdate.Text;
        }

        private void B_insert_Click(object sender, EventArgs e)
        {
            
            string name = Tb_name.Text;
            string sex = cmbsex.Text;
            string phone = Tb_phone.Text;
            string addresss = Tb_adress.Text;
            string bir = Dtp_date.Text;
            DateTime birthday = DateTime.Parse( bir);
            string email = Tb_email.Text;
            string xuehao = Tb_xuehao.Text;
            string grade = cmbGrade.Text;
            int gradeno = 0;
            if (grade == "大一")
            {
                gradeno = 1;
            }
            if (grade == "大二")
            {
                gradeno = 2;
            }
            if (grade == "大三")
            {
                gradeno = 3;
            }
            if (grade == "大四")
            {
                gradeno = 4;
            }
            string calss = cmbClass.Text;
            int classno = 0;
            if (calss == "18ab班")
            {
                classno = 1;
            }
            if (calss == "18cd班")
            {
                classno = 2;
            }
            if (calss == "18ef班")
            {
                classno = 3;
            }
            if (calss == "18gh班")
            {
                classno = 4;
            }
            if (calss == "18ij班")
            {
                classno = 5;
            }
            string xibu = cmbXiBu.Text;
            int xibuid = 0;
            if (xibu=="计算机系")
            {
                xibuid = 1;
            }
            if (xibu == "机电系")
            {
                xibuid = 2;
            }
            if (xibu == "外国语系")
            {
                xibuid = 3;
            }




            if (name == "" || sex == "" || phone == "" || addresss == "" || bir == "" || email == "" || xuehao == ""||grade==""||xibu=="")
            {
                MessageBox.Show("必填信息不能为空！");
            }
            else
            {

                string sqlstr = string.Format("insert into Student(StuName,Sex,Tel,adress,birthday,Email,xuehao,gradeno,classno,xibuid)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", name, sex, phone, addresss, birthday, email, xuehao,gradeno,classno,xibuid);
                bool i = DBHelper.ExecuteNonQuery(sqlstr);
                if (i == true)
                {
                    MessageBox.Show("添加成功！");
                }
            }
        }

        private void Tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            //数字0~9所对应的keychar为48~57，小数点是46，Backspace是8  
            e.Handled = true;
            //输入0-9和Backspace del 有效  
            if ((e.KeyChar >= 47 && e.KeyChar <= 58) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("请输入数字！");
            } 
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
