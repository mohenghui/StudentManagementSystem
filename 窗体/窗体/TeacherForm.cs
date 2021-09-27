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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btnTianJia_Click(object sender, EventArgs e)
        {
            string zh = txbname.Text;
            string pwd = txbpwd.Text;

            string sqlstr = string.Format("insert into guanliyuan(zhanghao,mima)values('{0}','{1}')",zh,pwd);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);
            if (i == true)
            {
                MessageBox.Show("添加成功！");
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
