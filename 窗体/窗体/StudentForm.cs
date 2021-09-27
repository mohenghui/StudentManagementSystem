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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xuehao = txbXuehao.Text;

            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sqlstr = string.Format("select * from score where student=(select stuname from student where xuehao='{0}')", xuehao);
            dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(ds, "score");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["score"];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string xuehao = txbXuehao.Text;
            string sqlstr = string.Format("delete * from score where student=(select stuname from student where xuehao='{0}')", xuehao);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);

            if (i == true)
            {
                MessageBox.Show("添加成功！");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentXinXiForm form = new studentXinXiForm();
            form.Show();
            //form.MdiParent = this;
        }
    }
}
