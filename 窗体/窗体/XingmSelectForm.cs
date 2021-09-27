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
    public partial class XingmSelectForm : Form
    {
        public XingmSelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbname.Text;

            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sqlstr = string.Format("select * from score where  student='{0}'", name);
            dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(ds, "score");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["score"];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = txbname.Text;
            string sqlstr = string.Format("delete from student where  stuname='{0}'", name);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);
            
            sqlstr = string.Format("delete from score where  student='{0}'", name);
            i = DBHelper.ExecuteNonQuery(sqlstr);
            if (i == true)
            {
                MessageBox.Show("删除成功！");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string name = txbname.Text;
            string scorename = textBox1.Text;
            string fenshu = textBox2.Text;
            int fenshu1 = int.Parse(fenshu);
            string sqlstr = string.Format("update score set score='{0}' where student='{1}' and course='{2}'", fenshu1,name,scorename);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);
            i = DBHelper.ExecuteNonQuery(sqlstr);
            if (i == true)
            {
                MessageBox.Show("更新成功！");
            }
        }
    }
}
