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
    public partial class tianjiachengji : Form
    {
        public tianjiachengji()
        {
            InitializeComponent();
        }

        private void Tb_kemu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tianjiachengji_Load(object sender, EventArgs e)
        {

        }

        private void B_insert_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string kemu = cmbKemu.Text;
            string score = Tb_score.Text;
            if (kemu == "")
            {
                MessageBox.Show("请选择科目！");
            }
            else
            {

                string sqlstr = string.Format("insert into score (student,course,score)values('{0}','{1}','{2}')", name, kemu, score);
                bool i = DBHelper.ExecuteNonQuery(sqlstr);
                if (i == true)
                {
                    MessageBox.Show("添加成功！");
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            string xuehao = txbXueHao.Text;

            string sql = string.Format("select * from student where xuehao='{0}'",xuehao);
            SqlDataReader reader = DBHelper.GetDataReader(sql);
            while (reader.Read())
            {
                string name = reader["stuname"].ToString();
                txbName.Text = name;
            }
            reader.Close();


        }
    }
}
