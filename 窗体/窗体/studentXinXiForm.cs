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
    public partial class studentXinXiForm : Form
    {
        public studentXinXiForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string grade = cmbGrade.Text;
            string sex = cmbsex.Text;

            if (grade == "" || sex == "")
            {
                MessageBox.Show("年级或性别不能为空！");
            }
            else
            {

                SqlConnection conn = new SqlConnection(DBHelper.conStr);
                DataSet ds = new DataSet();
                SqlDataAdapter dap;
                string sqlstr = string.Format("select xuehao,stuname,sex,gradename,tel from student,grade where student.gradeno=grade.gradeno and gradename='{0}' and sex='{1}'", grade, sex);
                dap = new SqlDataAdapter(sqlstr, conn);
                dap.Fill(ds, "XinXi");
                SqlCommandBuilder builder = new SqlCommandBuilder(dap);
                this.dgvXinXi.AutoGenerateColumns = false;
                this.dgvXinXi.DataSource = ds.Tables["XinXi"];
            }
        }

        private void studentXinXiForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sqlstr = "select xuehao,stuname,sex,gradename,tel from student,grade where student.gradeno=grade.gradeno ";
            dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(ds, "XinXi");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dgvXinXi.AutoGenerateColumns = false;
            this.dgvXinXi.DataSource = ds.Tables["XinXi"];
        }

        private void dgvXinXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string xuehao = this.dgvXinXi.SelectedCells[0].Value.ToString();
            string student = this.dgvXinXi.SelectedCells[1].Value.ToString();
            string sqlstr = string.Format("delete from student where xuehao='{0}'",xuehao);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);
            string str = string.Format("delete from score where student='{0}'",student);
            bool j = DBHelper.ExecuteNonQuery(str);
            if (i)
            {
                if (j)
                {
                    MessageBox.Show("删除成功！");
                }
            }

            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sql = "select xuehao,stuname,sex,gradename,tel from student,grade where student.gradeno=grade.gradeno ";
            dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds, "XinXi");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dgvXinXi.AutoGenerateColumns = false;
            this.dgvXinXi.DataSource = ds.Tables["XinXi"];
        }

        private void DgvXinXi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
